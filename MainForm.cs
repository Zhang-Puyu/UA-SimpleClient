using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Opc.Ua;
using Opc.Ua.Client;
using Siemens.UAClientHelper;
using System.Security.Cryptography.X509Certificates;
using TypeInfo = Opc.Ua.TypeInfo;

namespace UaClient_Foundation
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Fields 字段
        /// </summary>
        #region Fields
        private UAClientHelperAPI myClientHelperAPI;
        private EndpointDescription mySelectedEndpoint;//所选择节点信息
        private Session mySession;//服务器客户端连接绘会话
        private ReferenceDescriptionCollection myReferenceDescriptionCollection;//节点引用类型
        private Subscription mySubscription;//管理订阅，取消订阅添加监视项等等
        private MonitoredItem myMonitoredItem;//监视节点
        private UAClientCertForm myCertForm;
        private UAClientMatrixForm myMatrixForm;

        private Int16 itemCount;//监视项计数
        private Dictionary<NodeId, MonitoredItemNotification> mySubscribedItems;//已订阅字典
        private List<string> lastMatrixInput;
        #endregion

        /// <summary>
        /// Form Construction
        /// </summary>
        #region Construction
        public MainForm()
        {
            InitializeComponent();
            myClientHelperAPI = new UAClientHelperAPI();
            BrowsePage.Enabled = false;
            RwPage.Enabled = false;
            SubscribePage.Enabled = false;

            itemCount = 0;
            mySubscribedItems = new Dictionary<NodeId, MonitoredItemNotification>();
            lastMatrixInput = new List<string>();
        }
        #endregion


        /// <summary>
        /// Event handlers called by the UI
        /// </summary>
        #region UI响应
        private void EndpointButton_Click(object sender, EventArgs e)
        {
            bool foundEndpoints = false;
            EndpointListView.Items.Clear();
            string discoveryUrl = DiscoveryTextBox.Text;//服务器URL

            try
            {
                //获取OPC UA服务端的描述信息
                ApplicationDescriptionCollection servers = myClientHelperAPI.FindServers(discoveryUrl);

                foreach (ApplicationDescription ad in servers)
                {
                    foreach (string url in ad.DiscoveryUrls)
                    {
                        try
                        {
                            EndpointDescriptionCollection endpoints = myClientHelperAPI.GetEndpoints(url);//获取服务器端点信息
                            foundEndpoints = foundEndpoints || endpoints.Count > 0;
                            foreach (EndpointDescription ep in endpoints)
                            {
                                string securityPolicy = ep.SecurityPolicyUri.Remove(0, 42);//提取出实际的安全策略信息
                                string key = "[" + ad.ApplicationName + "] " + " [" + ep.SecurityMode + "] " + " [" + securityPolicy + "] " + " [" + ep.EndpointUrl + "]";
                                if (!EndpointListView.Items.ContainsKey(key))
                                {
                                    EndpointListView.Items.Add(key, key, 0).Tag = ep;
                                }

                            }
                        }
                        catch (ServiceResultException sre)
                        {
                            //如果在 ad.DiscoveryUrls 中的某个 URL 无法访问，myClientHelperAPI 将抛出异常
                            MessageBox.Show(sre.Message, "Error");
                        }

                    }
                    if (!foundEndpoints)
                    {
                        MessageBox.Show("Could not get any Endpoints", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void DiscoveryTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EndpointButton_Click(this, new EventArgs());
            }
        }

        private void EndpointListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            mySelectedEndpoint = (EndpointDescription)e.Item.Tag;//将Tag 属性值转换为 EndpointDescription 类型
        }

        private void AnonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AnonRadioButton.Checked)
            {
                UserTextBox.Enabled = false;
                PwTextBox.Enabled = false;
            }
        }

        private void UserPwRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (UserPwRadioButton.Checked)
            {
                UserTextBox.Enabled = true;
                PwTextBox.Enabled = true;
            }
        }

        private void EpConnectButton_Click(object sender, EventArgs e)
        {
            // 检查连接是否存在，如果存在，解除订阅且断开连接
            if (mySession != null && !mySession.Disposed)
            {
                try
                {
                    mySubscription.Delete(true);
                }
                catch
                {
                }
                myClientHelperAPI.Disconnect();
                mySession = myClientHelperAPI.Session;

                ResetUI();
            }
            else
            {
                try
                {
                    // KeepAliveNotification事件会在与服务器的会话期间定期发送保持活动信号时触发
                    // CertificateValidationNotification事件会在与服务器建立安全通信时验证服务器证书时触发
                    myClientHelperAPI.KeepAliveNotification += new KeepAliveEventHandler(Notification_KeepAlive);
                    myClientHelperAPI.CertificateValidationNotification += new CertificateValidationEventHandler(Notification_ServerCertificate);//验证服务器证书

                    // 是否选择了端点
                    if (mySelectedEndpoint != null)
                    {
                        // 创建链接
                        myClientHelperAPI.Connect(mySelectedEndpoint, UserPwRadioButton.Checked, UserTextBox.Text, PwTextBox.Text).Wait();
                        // 提取会话对象对OPCUA会话进行直接交互
                        mySession = myClientHelperAPI.Session;

                        //UI设置
                        EpConnectButton.Text = "断开所选端点";
                        BrowsePage.Enabled = true;
                        RwPage.Enabled = true;
                        SubscribePage.Enabled = true;
                        myCertForm = null;
                        myMatrixForm = null;
                        // 暂时未用到的界面
                        // structPage.Enabled = true;
                        // methodPage.Enabled = true;

                        MessageBox.Show("连接成功", "Success");
                    }
                    else
                    {
                        MessageBox.Show("请在连接前选择一个端点", "Error");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    myCertForm = null;
                    myMatrixForm = null;
                    ResetUI();
                    MessageBox.Show(ex.InnerException.Message, "Error");
                }
            }
        }

        private void BrowsePage_Enter(object sender, EventArgs e)
        {
            if (myReferenceDescriptionCollection == null)
            {
                try
                {
                    myReferenceDescriptionCollection = myClientHelperAPI.BrowseRoot();  // 获取根节点下所有引用

                    // 对每个引用创建一个树形节点
                    foreach (ReferenceDescription refDesc in myReferenceDescriptionCollection)
                    {
                        NodeTreeView.Nodes.Add(refDesc.DisplayName.ToString()).Tag = refDesc;

                        //添加空节点，便于展开后动态添加子节点
                        foreach (TreeNode node in NodeTreeView.Nodes)
                        {
                            node.Nodes.Add("");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void OpcTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = !e.TabPage.Enabled;
            if (!e.TabPage.Enabled)
            {
                MessageBox.Show("请先连接至服务端", "Error");
            }
        }

        private void NodeTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();

            ReferenceDescriptionCollection referenceDescriptionCollection;      //  引用类型列表
            ReferenceDescription refDesc = (ReferenceDescription)e.Node.Tag;    //  节点间引用关系

            try
            {
                referenceDescriptionCollection = myClientHelperAPI.BrowseNode(refDesc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }

            foreach (ReferenceDescription tempRefDesc in referenceDescriptionCollection)
            {
                //  Notifier 是 OPC UA 中一种特殊的节点类型，用于向客户端推送数据变化、事件、状态等信息。
                if (tempRefDesc.ReferenceTypeId != ReferenceTypeIds.HasNotifier)
                {
                    e.Node.Nodes.Add(tempRefDesc.DisplayName.ToString()).Tag = tempRefDesc;
                }
            }

            //添加到树形图内
            foreach (TreeNode node in e.Node.Nodes)
            {
                node.Nodes.Add("");
                ReferenceDescription ref1 = (ReferenceDescription)node.Tag;

                //  字典存储不同节点类型
                Dictionary<NodeClass, string> imageIndexesForNodeClass = new Dictionary<NodeClass, string>()
                {
                    {NodeClass.Unspecified, "opc_warning"},
                    {NodeClass.DataType, "opc_datatype"},
                    {NodeClass.Object, "opc_object"},
                    {NodeClass.Variable, "opc_variable"},
                    {NodeClass.Method, "opc_method"},
                    {NodeClass.ObjectType, "opc_objecttype"},
                    {NodeClass.VariableType, "opc_variabletype"},
                    {NodeClass.ReferenceType, "opc_reftype"},
                    {NodeClass.View, "opc_view"}
                };

                string imagetype = ".png";

                //定义引用ID的文件夹类型(61)和属性类型(68)
                ExpandedNodeId folderRefId = new ExpandedNodeId(61);
                ExpandedNodeId propertyRefId = new ExpandedNodeId(68);

                string FunctionalGroupType = "ns=2;i=1005";

                //将图像索引imagelist设置为10
                if (imageIndexesForNodeClass.ContainsKey(ref1.NodeClass) && imageList1.Images.Keys.Contains(imageIndexesForNodeClass[ref1.NodeClass] + imagetype))
                {
                    int index = 10;
                    string imagekey = "";

                    // 判断节点的引用类型
                    // 如果NodeClass是一个对象并且它的引用类型是“folder”或“FunctionalGroupType”
                    if (ref1.TypeDefinition == folderRefId || ref1.TypeDefinition.ToString() == FunctionalGroupType)
                    {
                        imagekey = "opc_treefolder" + imagetype;
                    }

                    // NodeClass为变量（Variable），且具有引用类型属性（Property）。
                    else if (ref1.TypeDefinition == propertyRefId)
                    {
                        imagekey = "opc_property" + imagetype;
                    }

                    // NodeClass为数据类型定义
                    else
                    {
                        imagekey = imageIndexesForNodeClass[ref1.NodeClass] + imagetype;
                    }
                    index = imageList1.Images.IndexOfKey(imagekey);
                    node.ImageIndex = index;
                    node.SelectedImageIndex = index;
                }
            }
        }

        private void NodeTreeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            DescriptionGridView.Rows.Clear();

            try
            {
                ReferenceDescription refDesc = (ReferenceDescription)e.Node.Tag;//提取出所点击节点的引用类型
                Node node = myClientHelperAPI.ReadNode(refDesc.NodeId.ToString());//从服务器读取指定节点的值
                VariableNode variableNode = new VariableNode();

                // 根据节点类别显示不同的节点信息
                string[] row1 = new string[] { "Node Id", refDesc.NodeId.ToString() };
                string[] row2 = new string[] { "Namespace Index", refDesc.NodeId.NamespaceIndex.ToString() };
                string[] row3 = new string[] { "Identifier Type", refDesc.NodeId.IdType.ToString() };
                string[] row4 = new string[] { "Identifier", refDesc.NodeId.Identifier.ToString() };
                string[] row5 = new string[] { "Browse Name", refDesc.BrowseName.ToString() };//浏览名称
                string[] row6 = new string[] { "Display Name", refDesc.DisplayName.ToString() };//显示名称
                string[] row7 = new string[] { "Node Class", refDesc.NodeClass.ToString() };//节点类别
                string[] row8 = new string[] { "Description", "null" };//节点描述
                try
                {
                    row8 = new string[] { "Description", node.Description.ToString() };
                }
                catch
                {
                    row8 = new string[] { "Description", "null" };
                }

                // 判断引用的类型定义是否在本地命名空间中
                string typeDefinition = "";
                if ((NodeId)refDesc.TypeDefinition.NamespaceIndex == 0)
                {
                    typeDefinition = refDesc.TypeDefinition.ToString();
                }
                else
                {
                    typeDefinition = "Struct/UDT: " + refDesc.TypeDefinition.ToString();
                }
                string[] row9 = new string[] { "Type Definition", typeDefinition };
                string[] row10 = new string[] { "Write Mask", node.WriteMask.ToString() };//可写属性掩码
                string[] row11 = new string[] { "User Write Mask", node.UserWriteMask.ToString() };//用户可写属性掩码

                // 判断是否为变量类型
                if (node.NodeClass == NodeClass.Variable)
                {
                    variableNode = (VariableNode)node.DataLock;
                    List<NodeId> nodeIds = new List<NodeId>();
                    IList<string> displayNames = new List<string>();
                    IList<ServiceResult> errors = new List<ServiceResult>();
                    NodeId nodeId = new NodeId(variableNode.DataType);
                    nodeIds.Add(nodeId);
                    mySession.ReadDisplayName(nodeIds, out displayNames, out errors);
                    int valueRank = variableNode.ValueRank;
                    List<string> arrayDimension = new List<string>();

                    string[] row12 = new string[] { "Data Type", displayNames[0] };//数据类型
                    string[] row13 = new string[] { "Value Rank", valueRank.ToString() };//节点值的维度

                    // 判断数组维度
                    if (valueRank > 0)
                    {
                        for (int i = 0; i < valueRank; i++)
                        {
                            //ElementAtOrDefault(i) 是一个 LINQ 方法，获取序列中指定索引处的元素
                            arrayDimension.Add(variableNode.ArrayDimensions.ElementAtOrDefault(i).ToString());
                        }
                    }
                    else
                    {
                        arrayDimension.Add("Scalar");
                    }

                    // 将数组 arrayDimension 中的元素用分号; 连接成一个字符串
                    string[] row14 = new string[] { "Array Dimensions", String.Join(";", arrayDimension.ToArray()) };//数组维度
                    string[] row15 = new string[] { "Access Level", variableNode.AccessLevel.ToString() };//访问级别
                    string[] row16 = new string[] { "Minimum Sampling Interval", variableNode.MinimumSamplingInterval.ToString() };//最小采样间隔
                    string[] row17 = new string[] { "Historizing", variableNode.Historizing.ToString() };//历史记录

                    object[] rows = new object[] { row1, row2, row3, row4, row5, row6, row7, row8, row9, row10, row11, row12, row13, row14, row15, row16, row17 };
                    foreach (string[] rowArray in rows)
                    {
                        DescriptionGridView.Rows.Add(rowArray);
                    }
                }
                else
                {
                    object[] rows = new object[] { row1, row2, row3, row4, row5, row6, row7, row8, row9, row10, row11 };
                    foreach (string[] rowArray in rows)
                    {
                        DescriptionGridView.Rows.Add(rowArray);
                    }
                }

                DescriptionGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void CopyNodeIdBtn_Click(object sender, EventArgs e)
        {
            if (DescriptionGridView.Rows.Count != 0)
            {
                try
                {
                    foreach (DataGridViewRow row in DescriptionGridView.Rows)
                    {
                        if (row.Cells[0].Value.Equals("Node Id"))
                        {
                            Clipboard.SetText(row.Cells[1].Value.ToString());
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("Please select a node in the tree view.");
            }
        }

        //单节点读取
        private void ReadButton_Click(object sender, EventArgs e)
        {
            ReadTextBox.Text = "";
            NodeId nodeId = new NodeId(ReadIdTextBox.Text);

            if (!GetArrayInformation(
                nodeId,
                out VariableNode variableNode,
                out BuiltInType arraydataType,
                out NodeId dataTypeId,
                out uint arraySize,
                out int valueRank))
                return;

            List<String> nodeIdStrings = new List<String>();
            List<String> values = new List<String>();
            nodeIdStrings.Add(ReadIdTextBox.Text);

            try
            {
                values = myClientHelperAPI.ReadValues(nodeIdStrings);
                if (valueRank == ValueRanks.Scalar)
                {
                    ReadTextBox.Text = values.ElementAt<String>(0);//LINQ方法访问首位元素
                }
                else //矩阵类型
                {
                    String[] matrixValues = new string[arraySize];
                    matrixValues = values.ElementAt<String>(0).Split('\0'); //将字符串类型的节点值按照 '\0' 分割成多个字符串
                    string[,] matrixArray = new string[arraySize, 3];//arraySize 行和 3 列，存储该元素在矩阵中的索引、值和数据类型
                    GetMatrixIndeces(variableNode, arraySize, out string[] matrixIndexArray);
                    for (int i = 0; i < arraySize; i++)
                    {
                        matrixArray[i, 0] = matrixIndexArray[i];
                        matrixArray[i, 1] = matrixValues[i];
                        matrixArray[i, 2] = arraydataType.ToString();
                    }
                    myMatrixForm = new UAClientMatrixForm(matrixArray, sender);
                    ReadMatrixButton.Visible = true;
                    if (valueRank == ValueRanks.OneDimension)
                    {
                        string valuesArray = values.ElementAt<string>(0).Replace("\0", ";");
                        ReadTextBox.Text = valuesArray;
                    }
                    else
                    {
                        ReadTextBox.Text = "Click on the three dots to display the values.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        //多节点读取
        private void MulReadButton_Click(object sender, EventArgs e)
        {
            //清除显示数据
            ReadTextBox1.Text = "";
            ReadTextBox2.Text = "";
            ReadTextBox3.Text = "";

            //输入，node节点数组
            NodeId[] nodeIdArray = new NodeId[3];
            nodeIdArray[0] = ReadIdTextBox1.Text;
            nodeIdArray[1] = ReadIdTextBox2.Text;
            nodeIdArray[2] = ReadIdTextBox2.Text;

            //节点文本数组
            string[] nodeIdStrArr = new string[3];
            nodeIdStrArr[0] = ReadIdTextBox1.Text;
            nodeIdStrArr[1] = ReadIdTextBox2.Text;
            nodeIdStrArr[2] = ReadIdTextBox3.Text;

            //输出，textbox数组
            TextBox[] valReadArray = new TextBox[3];
            valReadArray[0] = ReadTextBox1;
            valReadArray[1] = ReadTextBox2;
            valReadArray[2] = ReadTextBox3;

            for (int i = 0; i < 3; i++)
            {
                if (!GetArrayInformation(
               nodeIdArray[i],
               out VariableNode variableNode,
               out BuiltInType arraydataType,
               out NodeId dataTypeId,
               out uint arraySize,
               out int valueRank))
                    return;

                List<String> nodeIdStrings = new List<String>();
                List<String> values = new List<String>();
                nodeIdStrings.Add(nodeIdStrArr[i]);

                try
                {
                    values = myClientHelperAPI.ReadValues(nodeIdStrings);
                    if (valueRank == ValueRanks.Scalar)
                    {
                        valReadArray[i].Text = values.ElementAt<String>(0);//LINQ方法访问首位元素
                    }
                    else //矩阵类型
                    {
                        String[] matrixValues = new string[arraySize];
                        matrixValues = values.ElementAt<String>(0).Split('\0'); //将字符串类型的节点值按照 '\0' 分割成多个字符串
                        string[,] matrixArray = new string[arraySize, 3];//arraySize 行和 3 列，存储该元素在矩阵中的索引、值和数据类型
                        GetMatrixIndeces(variableNode, arraySize, out string[] matrixIndexArray);
                        for (int j = 0; j < arraySize; j++)
                        {
                            matrixArray[j, 0] = matrixIndexArray[j];
                            matrixArray[j, 1] = matrixValues[j];
                            matrixArray[j, 2] = arraydataType.ToString();
                        }
                        myMatrixForm = new UAClientMatrixForm(matrixArray, sender);
                        ReadMatrixButton.Visible = true;
                        if (valueRank == ValueRanks.OneDimension)
                        {
                            string valuesArray = values.ElementAt<string>(0).Replace("\0", ";");
                            nodeIdStrArr[i] = valuesArray;
                        }
                        else
                        {
                            nodeIdStrArr[i] = "点击三个点的按钮显示值";
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (nodeIdStrArr[i] == null)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
            }
        }

        private void MatrixCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (WriteIdTextBox.Text == "")
            {
                MessageBox.Show("没有输入NodeID。");
                return;
            }
            if (MatrixCheckBox.Checked)
            {
                WriteTextBox.Visible = false;
                MatrixLabel.Visible = true;
                NodeId nodeId = new NodeId(WriteIdTextBox.Text);
                if (!GetArrayInformation(
                    nodeId,
                    out VariableNode variableNode,
                    out BuiltInType arraydataType,
                    out NodeId dataTypeId,
                    out uint arraySize,
                    out int valueRank))
                    return;
                if (valueRank >= ValueRanks.OneDimension)
                {
                    string[,] matrixArray = new string[arraySize, 3];
                    for (int i = 0; i < arraySize; i++)
                    {
                        GetMatrixIndeces(variableNode, arraySize, out string[] matrixIndexArray);
                        matrixArray[i, 0] = matrixIndexArray[i];
                        matrixArray[i, 1] = "";
                        matrixArray[i, 2] = arraydataType.ToString();
                    }
                    using (UAClientMatrixForm matrixDialog = new UAClientMatrixForm(matrixArray, sender))
                    {
                        if (matrixDialog.ShowDialog() == DialogResult.OK)
                        {
                            lastMatrixInput = matrixDialog.valuesToWrite;
                        }
                    }
                }
                else if (valueRank == ValueRanks.Scalar)
                {
                    MatrixCheckBox.Checked = false;
                    MessageBox.Show($"The entered NodeId [{nodeId}] is a scalar.", "Error");
                }
            }
            else
            {
                WriteTextBox.Visible = true;
                MatrixLabel.Visible = false;
            }
        }

        //单节点写入
        private void WriteButton_Click(object sender, EventArgs e)
        {
            if (WriteIdTextBox.Text == "")
            {
                MessageBox.Show("没有输入Node ID", "Error");
            }
            else
            {
                NodeId nodeId = new NodeId(WriteIdTextBox.Text);
                if (!GetArrayInformation(
                    nodeId,
                    out VariableNode variableNode,
                    out BuiltInType arraydataType,
                    out NodeId dataTypeId,
                    out uint arraySize,
                    out int valueRank))
                    return;
                var toWrite = new Dictionary<NodeId, IEnumerable<string>>();//var 弱化定义类型 IEnumerable可枚举类型

                if (WriteTextBox.Text == "" && !MatrixCheckBox.Checked && valueRank == ValueRanks.Scalar)
                {
                    MessageBox.Show("没有输入任何值", "Error");
                    return;
                }
                else if (!lastMatrixInput.Any() && MatrixCheckBox.Checked && valueRank >= ValueRanks.OneDimension)
                {
                    MessageBox.Show("没有输入任何值", "Error");
                    MatrixCheckBox.Checked = false;
                    return;
                }
                else if (!MatrixCheckBox.Checked && valueRank >= ValueRanks.OneDimension)
                {
                    MessageBox.Show($"输入的 NodeId [{nodeId}] 是一个数组或矩阵. 请勾选复选框.", "Error");
                    return;
                }
                else if (MatrixCheckBox.Checked && valueRank == ValueRanks.Scalar)
                {
                    MessageBox.Show($"输入的 NodeId [{nodeId}] 是单个变量. 请取消勾选复选框.", "Error");
                    return;
                }
                else if (valueRank == ValueRanks.Scalar)
                {
                    toWrite.Add(nodeId, new List<string>() { WriteTextBox.Text });
                }
                else // 写入数组或矩阵
                {
                    List<string> valueList = new List<string>();
                    foreach (string value in lastMatrixInput)
                    {
                        if (String.IsNullOrEmpty(value))
                        {
                            valueList.Add(TypeInfo.GetDefaultValue(dataTypeId, ValueRanks.Scalar).ToString());
                        }
                        else
                        {
                            valueList.Add(value);
                        }
                    }
                    toWrite.Add(nodeId, valueList);
                }
                try
                {
                    if (MatrixCheckBox.Checked)
                    {
                        MatrixCheckBox.Checked = false;
                    }
                    myClientHelperAPI.WriteValues(toWrite);
                    lastMatrixInput.Clear();
                    WriteTextBox.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }


        //多节点写入
        private void MulWriteButton_Click(object sender, EventArgs e)
        {
            //节点数组
            TextBox[] nodeIdArr = new TextBox[3];
            nodeIdArr[0] = WriteIdTextBox1;
            nodeIdArr[1] = WriteIdTextBox2;
            nodeIdArr[2] = WriteIdTextBox3;

            //输入，textbox数组
            TextBox[] valWriteArray = new TextBox[3];
            valWriteArray[0] = WriteTextBox1;
            valWriteArray[1] = WriteTextBox2;
            valWriteArray[2] = WriteTextBox3;

            NodeId[] nodeIdToWrite = new NodeId[3];


            for (int i = 0; i < 3; i++)
            {
                if (nodeIdArr[i].Text == "" || valWriteArray[i].Text == "")
                {
                    MessageBox.Show("您在第" + (i + 1) + "行未输入完全，Node ID或写入值为空", "error");
                }
                else
                {
                    nodeIdToWrite[i] = new NodeId(nodeIdArr[i].Text);
                    if (!GetArrayInformation(
                    nodeIdToWrite[i],
                    out VariableNode variableNode,
                    out BuiltInType arraydataType,
                    out NodeId dataTypeId,
                    out uint arraySize,
                    out int valueRank))
                        return;

                    var toWrite = new Dictionary<NodeId, IEnumerable<string>>();//var 弱化定义类型 IEnumerable可枚举类型

                    if (valueRank == ValueRanks.Scalar || nodeIdArr[i].Text == null || valWriteArray[i].Text == null)
                    {
                        toWrite.Add(nodeIdToWrite[i], new List<string>() { valWriteArray[i].Text });
                        myClientHelperAPI.WriteValues(toWrite);
                    }
                    else
                    {
                        MessageBox.Show("您输入的可能为数组或矩阵，请在上方单节读写入框进行操作", "Error");
                    }
                }
            }
            WriteTextBox1.Clear();
            WriteTextBox2.Clear();
            WriteTextBox3.Clear();
        }

        private void SubscribeButton_Click(object sender, EventArgs e)
        {
            string subscriptionName = "TagSubscription";
            NodeId monitoredItemNodeId = new NodeId(SubNodeIdTextBox.Text);//监控节点ID
            if (mySubscription == null)
            {
                try
                {
                    //使用不同的监视项名称以正确分配到通知事件
                    itemCount++;//监视项
                    string monitoredItemName = "myItem" + itemCount.ToString();
                    //间隔1000ms，对subscriptionName进行订阅
                    mySubscription = myClientHelperAPI.Subscribe(1000, subscriptionName);
                    //创建监视项，指定监视模式
                    myMonitoredItem = myClientHelperAPI.AddMonitoredItem(mySubscription, SubNodeIdTextBox.Text, monitoredItemName, 1);
                    //添加监视项变化通知事件，监控数据发生变化时触发，Notification_MonitoredItem为委托实例的处理方法
                    myClientHelperAPI.ItemChangedNotification += new MonitoredItemNotificationEventHandler(Notification_MonitoredItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            else
            {
                List<MonitoredItem> monitoredItems = mySubscription.MonitoredItems.ToList();
                foreach (MonitoredItem monitoredItem in monitoredItems)//遍历是否已经存在订阅
                {
                    if (monitoredItem.StartNodeId != monitoredItemNodeId)
                    {
                        try
                        {
                            //使用不同的监视项名称以正确分配到通知事件
                            itemCount++;
                            string monitoredItemName = "myItem" + itemCount.ToString();
                            //添加监视项
                            myMonitoredItem = myClientHelperAPI.AddMonitoredItem(mySubscription, SubNodeIdTextBox.Text, monitoredItemName, 1);
                            //添加监视项变化通知事件
                            myClientHelperAPI.ItemChangedNotification += new MonitoredItemNotificationEventHandler(Notification_MonitoredItem);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error");
                        }
                    }
                }
            }
        }

        //取消订阅
        private void UnsubscribeButton_Click(object sender, EventArgs e)
        {
            //判断是否已经取消订阅
            if (mySubscription != null)
            {
                myClientHelperAPI.RemoveSubscription(mySubscription);
                mySubscription = null;
                itemCount = 0;
                SubscriptionTextBox.Text = "";
                mySubscribedItems.Clear();
            }
        }
        #endregion


        /// <summary>
        /// 全局OPCUA事件控制方法
        /// </summary>
        #region OPCUA事件控制方法

        //服务器证书
        private void Notification_ServerCertificate(CertificateValidator cert, CertificateValidationEventArgs e)
        {
            //Handle certificate here
            //To accept a certificate manually move it to the root folder (Start > mmc.exe > add snap-in > certificates)
            //Or handle via UAClientCertForm

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CertificateValidationEventHandler(Notification_ServerCertificate), cert, e);
                return;
            }

            try
            {
                //Search for the server's certificate in store; if found -> accept
                X509Store store = new X509Store(StoreName.Root, StoreLocation.CurrentUser);
                store.Open(OpenFlags.ReadOnly);
                X509CertificateCollection certCol = store.Certificates.Find(X509FindType.FindByThumbprint, e.Certificate.Thumbprint, true);
                store.Close();
                if (certCol.Capacity > 0)
                {
                    e.Accept = true;
                }

                //Show cert dialog if cert hasn't been accepted yet
                else
                {
                    if (!e.Accept & myCertForm == null)
                    {
                        myCertForm = new UAClientCertForm(e);
                        myCertForm.ShowDialog();
                    }
                }
            }
            catch
            {
                ;
            }
        }

        //保持连接
        private void Notification_KeepAlive(ISession sender, KeepAliveEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new KeepAliveEventHandler(Notification_KeepAlive), sender, e);
                return;
            }

            try
            {
                // check for events from discarded sessions.
                if (!Object.ReferenceEquals(sender, mySession))
                {
                    return;
                }

                // check for disconnected session.
                if (!ServiceResult.IsGood(e.Status))
                {
                    // try reconnecting using the existing session state
                    mySession.Reconnect();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                ResetUI();
            }
        }

        ///监控事件
        ///<summary>
        ///监视项变化通知回调函数，用于处理监视项变化事件
        ///</summary>
        ///<param name="monitoredItem"> 监视项对象，表示被监视的节点</param>
        ///<param name="e"> 监视项变化通知的参数</param>
        ///<returns>无返回值</returns>
        private void Notification_MonitoredItem(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            //获取监视项具体节点
            NodeId monitoredItemNodeId = monitoredItem.ResolvedNodeId;//ResolvedNodeId 属性可以帮助将别名解析为实际的 NodeId

            //确保在UI线程上调用回调函数
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new MonitoredItemNotificationEventHandler(Notification_MonitoredItem), monitoredItem, e);
                return;
            }

            //从监控事件中获取监视项变化通知的值
            MonitoredItemNotification notification = e.NotificationValue as MonitoredItemNotification;
            if (notification == null)
            {
                return;
            }

            //将监视项变化通知的值储存到字典中
            if (!mySubscribedItems.ContainsKey(monitoredItemNodeId))
            {
                mySubscribedItems.Add(monitoredItemNodeId, notification);
            }
            else
            {
                mySubscribedItems[monitoredItemNodeId] = notification;
            }

            //更新UI文本
            SubscriptionTextBox.Text = "";
            int counter = 1;
            foreach (var valuePair in mySubscribedItems)
            {
                if (counter == 1)
                {
                    SubscriptionTextBox.Text += "Item name: myItem" + counter.ToString();
                }
                else
                {
                    SubscriptionTextBox.Text += Environment.NewLine + "Item name: myItem" + counter.ToString();
                }
                SubscriptionTextBox.Text += Environment.NewLine + "Value: " + Utils.Format("{0}", valuePair.Value.Value.WrappedValue.ToString());
                SubscriptionTextBox.Text += Environment.NewLine + "Source timestamp: " + valuePair.Value.Value.SourceTimestamp.ToString();//源时间戳
                SubscriptionTextBox.Text += Environment.NewLine + "Server timestamp: " + valuePair.Value.Value.ServerTimestamp.ToString();//服务器时间戳
                SubscriptionTextBox.Text += Environment.NewLine + "Status code: " + valuePair.Value.Value.StatusCode.ToString();
                SubscriptionTextBox.Text += Environment.NewLine;
                counter += 1;
            }

        }
        #endregion

        /// <summary>
        /// UI处理私有方法
        /// </summary>
        #region 私有UI处理方法
        private void ResetUI()
        {
            //descriptionGridView.Rows.Clear();
            //nodeTreeView.Nodes.Clear();
            //myReferenceDescriptionCollection = null;
            //structGridView.Rows.Clear();
            //inputArgumentsGridView.Rows.Clear();
            //outputArgumentsGridView.Rows.Clear();
            //myStructList = null;

            //subscriptionTextBox.Text = "";
            //subscriptionIdTextBox.Text = "";
            //ReadIdTextBox.Text = "";
            //WriteIdTextBox.Text = "";
            //ReadTextBox.Text = "";
            //WriteTextBox.Text = "";
            EpConnectButton.Text = "连接至所选端点";

            BrowsePage.Enabled = false;
            RwPage.Enabled = false;
            SubscribePage.Enabled = false;
            //structPage.Enabled = false;
            //methodPage.Enabled = false;

            OpcTabControl.SelectedIndex = 0;
        }

        /// <summary>
        /// 获取节点的信息，包括节点的数据类型、数组长度、数组维度等等。
        /// </summary>
        private bool GetArrayInformation(NodeId nodeId, out VariableNode variableNode, out BuiltInType dataType, out NodeId dataTypeId, out uint arraylength, out int valueRank)
        {
            arraylength = 0;
            Node node = null;
            variableNode = null;
            dataType = BuiltInType.Null; // OPC UA定义的一种枚举类型,表示OPC UA中的基本数据类型
            dataTypeId = null;
            valueRank = 0;

            try
            {
                node = mySession.ReadNode(nodeId);
            }
            catch (ServiceResultException ex)
            {
                if (node != null)
                {
                    MessageBox.Show(string.Format("读取节点的值失败，错误消息为：{0}", ex.Message), "Error");
                    return false;
                }
            }
            if (node != null)
            {
                variableNode = (VariableNode)node.DataLock;
                dataType = TypeInfo.GetBuiltInType(variableNode.DataType);// 获取节点的数据类型
                dataTypeId = variableNode.DataType;
                if (dataType == BuiltInType.Null)
                {
                    try
                    {
                        // 获取父节点的数据类型
                        dataTypeId = GetParentDataType(dataTypeId, mySession);
                        dataType = TypeInfo.GetBuiltInType(dataTypeId);
                        if (dataType == BuiltInType.Null) // 确保输入的节点ID不是结构体类型
                        {
                            MessageBox.Show("输入的节点ID可能是结构体类型，请使用读/写结构体的方法。", "Error");
                            return false;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("该节点ID的数据类型不可转换，可能是结构体类型。", "Error");
                        return false;
                    }
                }
                valueRank = variableNode.ValueRank;

                // 检查是否为矩阵类型
                if (valueRank > ValueRanks.OneDimension)
                {
                    arraylength = 1;
                    for (int i = 0; i < valueRank; i++)
                    {
                        // ElementAtOrDefault：LINQ方法，用于获取序列中指定索引处的元素
                        // ArrayDimensions：节点每个维度的长度
                        arraylength *= variableNode.ArrayDimensions.ElementAtOrDefault(i);
                    }
                }
                else //为数组
                {
                    arraylength = variableNode.ArrayDimensions.ElementAtOrDefault(0);
                }
            }

            return true;
        }

        /// <summary>
        /// matrixIndexArray 数组包含了矩阵中每个元素的索引值，可用于在 OPC UA 服务器上读取和写入这些元素的值
        /// </summary>
        private void GetMatrixIndeces(VariableNode variableNode, uint arraySize, out string[] matrixIndexArray)
        {
            matrixIndexArray = new string[arraySize];

            //将一维数组转换为多维，求其索引值即每个元素的坐标
            for (int i = 0; i < arraySize; i++)//一维数组中第i个元素的索引值
            {
                List<long> indexes = new List<long>();
                long remainder = i;

                //算出每一维度上的索引值，并将其加入到indexes数组中
                for (int j = variableNode.ArrayDimensions.Count - 1; j >= 0; j--)//取第j-1个维度，例如[3,2,4]的第1个维度
                {
                    uint dimension = variableNode.ArrayDimensions[j];//每一维度大小，例如第一个维度大小为3
                    indexes.Insert(0, remainder % dimension);
                    remainder /= dimension;
                }
                String matrixIndex = "[" + String.Join("][", indexes) + "]";
                matrixIndexArray[i] = matrixIndex;
            }
        }

        private static NodeId GetParentDataType(NodeId nodeId, Session theSessionToBrowseIn)
        {
            ReferenceDescriptionCollection referenceDescriptionCollection;
            byte[] continuationPoint;
            theSessionToBrowseIn.Browse(null, null, nodeId, 1, BrowseDirection.Inverse, ReferenceTypeIds.HasSubtype, true, 0, out continuationPoint, out referenceDescriptionCollection);
            NodeId nodeIdParentDataType = (NodeId)referenceDescriptionCollection[0].NodeId;

            if (nodeIdParentDataType.NamespaceIndex != 0)
            {
                nodeIdParentDataType = GetParentDataType(nodeIdParentDataType, theSessionToBrowseIn);
            }

            return nodeIdParentDataType;
        }
        #endregion
    }
}