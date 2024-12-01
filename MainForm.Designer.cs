namespace UaClient_Foundation
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.OpcTabControl = new System.Windows.Forms.TabControl();
            this.ConnectPage = new System.Windows.Forms.TabPage();
            this.EndpointListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EpConnectButton = new System.Windows.Forms.Button();
            this.PwTextBox = new System.Windows.Forms.TextBox();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.UserPwRadioButton = new System.Windows.Forms.RadioButton();
            this.AnonRadioButton = new System.Windows.Forms.RadioButton();
            this.EndpointButton = new System.Windows.Forms.Button();
            this.DiscoveryTextBox = new System.Windows.Forms.TextBox();
            this.EndpointLabel = new System.Windows.Forms.Label();
            this.BrowsePage = new System.Windows.Forms.TabPage();
            this.DescriptionGridView = new System.Windows.Forms.DataGridView();
            this.attributeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CopyNodeIdBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NodeTreeView = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.RwPage = new System.Windows.Forms.TabPage();
            this.RwsGroupBox = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.WriteTextBox3 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.WriteTextBox2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.WriteIdTextBox3 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.WriteIdTextBox2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.WriteIdTextBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ReadIdTextBox3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ReadIdTextBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ReadTextBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ReadTextBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.WriteTextBox1 = new System.Windows.Forms.TextBox();
            this.ReadTextBox1 = new System.Windows.Forms.TextBox();
            this.ReadIdTextBox1 = new System.Windows.Forms.TextBox();
            this.MulWriteButton = new System.Windows.Forms.Button();
            this.MulReadButton = new System.Windows.Forms.Button();
            this.RwGroupBox = new System.Windows.Forms.GroupBox();
            this.MatrixLabel = new System.Windows.Forms.Label();
            this.MatrixCheckBox = new System.Windows.Forms.CheckBox();
            this.ReadMatrixButton = new System.Windows.Forms.Button();
            this.WriteTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ReadTextBox = new System.Windows.Forms.TextBox();
            this.WriteIdTextBox = new System.Windows.Forms.TextBox();
            this.ReadIdTextBox = new System.Windows.Forms.TextBox();
            this.WriteButton = new System.Windows.Forms.Button();
            this.ReadButton = new System.Windows.Forms.Button();
            this.SubscribePage = new System.Windows.Forms.TabPage();
            this.SubscriptionTextBox = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.UnsubscribeButton = new System.Windows.Forms.Button();
            this.SubscribeButton = new System.Windows.Forms.Button();
            this.SubNodeIdTextBox = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.OpcTabControl.SuspendLayout();
            this.ConnectPage.SuspendLayout();
            this.userGroupBox.SuspendLayout();
            this.BrowsePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionGridView)).BeginInit();
            this.RwPage.SuspendLayout();
            this.RwsGroupBox.SuspendLayout();
            this.RwGroupBox.SuspendLayout();
            this.SubscribePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpcTabControl
            // 
            this.OpcTabControl.Controls.Add(this.ConnectPage);
            this.OpcTabControl.Controls.Add(this.BrowsePage);
            this.OpcTabControl.Controls.Add(this.RwPage);
            this.OpcTabControl.Controls.Add(this.SubscribePage);
            this.OpcTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpcTabControl.ItemSize = new System.Drawing.Size(68, 21);
            this.OpcTabControl.Location = new System.Drawing.Point(0, 0);
            this.OpcTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpcTabControl.Name = "OpcTabControl";
            this.OpcTabControl.SelectedIndex = 0;
            this.OpcTabControl.Size = new System.Drawing.Size(730, 449);
            this.OpcTabControl.TabIndex = 0;
            this.OpcTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.OpcTabControl_Selecting);
            // 
            // ConnectPage
            // 
            this.ConnectPage.Controls.Add(this.label29);
            this.ConnectPage.Controls.Add(this.EndpointListView);
            this.ConnectPage.Controls.Add(this.userGroupBox);
            this.ConnectPage.Controls.Add(this.EndpointButton);
            this.ConnectPage.Controls.Add(this.DiscoveryTextBox);
            this.ConnectPage.Controls.Add(this.EndpointLabel);
            this.ConnectPage.Location = new System.Drawing.Point(4, 25);
            this.ConnectPage.Margin = new System.Windows.Forms.Padding(2);
            this.ConnectPage.Name = "ConnectPage";
            this.ConnectPage.Padding = new System.Windows.Forms.Padding(2);
            this.ConnectPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ConnectPage.Size = new System.Drawing.Size(722, 420);
            this.ConnectPage.TabIndex = 0;
            this.ConnectPage.Text = " 连接";
            this.ConnectPage.UseVisualStyleBackColor = true;
            // 
            // EndpointListView
            // 
            this.EndpointListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EndpointListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.EndpointListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.EndpointListView.HideSelection = false;
            this.EndpointListView.Location = new System.Drawing.Point(7, 46);
            this.EndpointListView.Margin = new System.Windows.Forms.Padding(2);
            this.EndpointListView.MultiSelect = false;
            this.EndpointListView.Name = "EndpointListView";
            this.EndpointListView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EndpointListView.Size = new System.Drawing.Size(710, 226);
            this.EndpointListView.TabIndex = 4;
            this.EndpointListView.UseCompatibleStateImageBehavior = false;
            this.EndpointListView.View = System.Windows.Forms.View.Details;
            this.EndpointListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.EndpointListView_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Found  Endpoints";
            this.columnHeader1.Width = 700;
            // 
            // userGroupBox
            // 
            this.userGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userGroupBox.Controls.Add(this.label2);
            this.userGroupBox.Controls.Add(this.label1);
            this.userGroupBox.Controls.Add(this.EpConnectButton);
            this.userGroupBox.Controls.Add(this.PwTextBox);
            this.userGroupBox.Controls.Add(this.UserTextBox);
            this.userGroupBox.Controls.Add(this.UserPwRadioButton);
            this.userGroupBox.Controls.Add(this.AnonRadioButton);
            this.userGroupBox.Location = new System.Drawing.Point(7, 277);
            this.userGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.userGroupBox.Name = "userGroupBox";
            this.userGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.userGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userGroupBox.Size = new System.Drawing.Size(252, 146);
            this.userGroupBox.TabIndex = 4;
            this.userGroupBox.TabStop = false;
            this.userGroupBox.Text = "用户认证";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "UserName:";
            // 
            // EpConnectButton
            // 
            this.EpConnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EpConnectButton.Location = new System.Drawing.Point(68, 114);
            this.EpConnectButton.Margin = new System.Windows.Forms.Padding(2);
            this.EpConnectButton.Name = "EpConnectButton";
            this.EpConnectButton.Size = new System.Drawing.Size(178, 22);
            this.EpConnectButton.TabIndex = 5;
            this.EpConnectButton.Text = "连接至所选端点";
            this.EpConnectButton.UseVisualStyleBackColor = true;
            this.EpConnectButton.Click += new System.EventHandler(this.EpConnectButton_Click);
            // 
            // PwTextBox
            // 
            this.PwTextBox.Enabled = false;
            this.PwTextBox.Location = new System.Drawing.Point(69, 89);
            this.PwTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PwTextBox.Name = "PwTextBox";
            this.PwTextBox.Size = new System.Drawing.Size(177, 21);
            this.PwTextBox.TabIndex = 3;
            this.PwTextBox.Text = "88493232";
            // 
            // UserTextBox
            // 
            this.UserTextBox.Enabled = false;
            this.UserTextBox.Location = new System.Drawing.Point(69, 64);
            this.UserTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(177, 21);
            this.UserTextBox.TabIndex = 2;
            this.UserTextBox.Text = "NPUOPCUA";
            // 
            // UserPwRadioButton
            // 
            this.UserPwRadioButton.AutoSize = true;
            this.UserPwRadioButton.Location = new System.Drawing.Point(5, 41);
            this.UserPwRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.UserPwRadioButton.Name = "UserPwRadioButton";
            this.UserPwRadioButton.Size = new System.Drawing.Size(101, 16);
            this.UserPwRadioButton.TabIndex = 1;
            this.UserPwRadioButton.Text = "User/Password";
            this.UserPwRadioButton.UseVisualStyleBackColor = true;
            this.UserPwRadioButton.CheckedChanged += new System.EventHandler(this.UserPwRadioButton_CheckedChanged);
            // 
            // AnonRadioButton
            // 
            this.AnonRadioButton.AutoSize = true;
            this.AnonRadioButton.Checked = true;
            this.AnonRadioButton.Location = new System.Drawing.Point(5, 20);
            this.AnonRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.AnonRadioButton.Name = "AnonRadioButton";
            this.AnonRadioButton.Size = new System.Drawing.Size(77, 16);
            this.AnonRadioButton.TabIndex = 0;
            this.AnonRadioButton.TabStop = true;
            this.AnonRadioButton.Text = "Anonymous";
            this.AnonRadioButton.UseVisualStyleBackColor = true;
            this.AnonRadioButton.CheckedChanged += new System.EventHandler(this.AnonRadioButton_CheckedChanged);
            // 
            // EndpointButton
            // 
            this.EndpointButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EndpointButton.Location = new System.Drawing.Point(611, 20);
            this.EndpointButton.Margin = new System.Windows.Forms.Padding(2);
            this.EndpointButton.Name = "EndpointButton";
            this.EndpointButton.Size = new System.Drawing.Size(105, 22);
            this.EndpointButton.TabIndex = 2;
            this.EndpointButton.Text = "获取端点";
            this.EndpointButton.UseVisualStyleBackColor = true;
            this.EndpointButton.Click += new System.EventHandler(this.EndpointButton_Click);
            // 
            // DiscoveryTextBox
            // 
            this.DiscoveryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscoveryTextBox.Location = new System.Drawing.Point(7, 21);
            this.DiscoveryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DiscoveryTextBox.Name = "DiscoveryTextBox";
            this.DiscoveryTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DiscoveryTextBox.Size = new System.Drawing.Size(601, 21);
            this.DiscoveryTextBox.TabIndex = 1;
            this.DiscoveryTextBox.Text = "opc.tcp://192.168.214.1:4840";
            this.DiscoveryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiscoveryTextBox_KeyDown);
            // 
            // EndpointLabel
            // 
            this.EndpointLabel.AutoSize = true;
            this.EndpointLabel.Location = new System.Drawing.Point(7, 6);
            this.EndpointLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EndpointLabel.Name = "EndpointLabel";
            this.EndpointLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EndpointLabel.Size = new System.Drawing.Size(179, 12);
            this.EndpointLabel.TabIndex = 0;
            this.EndpointLabel.Text = "获取服务器URL的所有可用端点：";
            this.EndpointLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BrowsePage
            // 
            this.BrowsePage.Controls.Add(this.DescriptionGridView);
            this.BrowsePage.Controls.Add(this.CopyNodeIdBtn);
            this.BrowsePage.Controls.Add(this.label4);
            this.BrowsePage.Controls.Add(this.NodeTreeView);
            this.BrowsePage.Controls.Add(this.label3);
            this.BrowsePage.Location = new System.Drawing.Point(4, 25);
            this.BrowsePage.Margin = new System.Windows.Forms.Padding(2);
            this.BrowsePage.Name = "BrowsePage";
            this.BrowsePage.Padding = new System.Windows.Forms.Padding(2);
            this.BrowsePage.Size = new System.Drawing.Size(722, 420);
            this.BrowsePage.TabIndex = 1;
            this.BrowsePage.Text = "节点浏览";
            this.BrowsePage.UseVisualStyleBackColor = true;
            this.BrowsePage.Enter += new System.EventHandler(this.BrowsePage_Enter);
            // 
            // DescriptionGridView
            // 
            this.DescriptionGridView.AllowUserToAddRows = false;
            this.DescriptionGridView.AllowUserToDeleteRows = false;
            this.DescriptionGridView.AllowUserToResizeRows = false;
            this.DescriptionGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DescriptionGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DescriptionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DescriptionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attributeColumn,
            this.valueColumn});
            this.DescriptionGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DescriptionGridView.Location = new System.Drawing.Point(360, 25);
            this.DescriptionGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DescriptionGridView.Name = "DescriptionGridView";
            this.DescriptionGridView.ReadOnly = true;
            this.DescriptionGridView.RowHeadersVisible = false;
            this.DescriptionGridView.RowHeadersWidth = 51;
            this.DescriptionGridView.Size = new System.Drawing.Size(358, 394);
            this.DescriptionGridView.TabIndex = 5;
            // 
            // attributeColumn
            // 
            this.attributeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            this.attributeColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.attributeColumn.HeaderText = "Attribute";
            this.attributeColumn.MinimumWidth = 6;
            this.attributeColumn.Name = "attributeColumn";
            this.attributeColumn.ReadOnly = true;
            // 
            // valueColumn
            // 
            this.valueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            this.valueColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.valueColumn.HeaderText = "Value";
            this.valueColumn.MinimumWidth = 6;
            this.valueColumn.Name = "valueColumn";
            this.valueColumn.ReadOnly = true;
            // 
            // CopyNodeIdBtn
            // 
            this.CopyNodeIdBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyNodeIdBtn.Location = new System.Drawing.Point(638, 1);
            this.CopyNodeIdBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CopyNodeIdBtn.Name = "CopyNodeIdBtn";
            this.CopyNodeIdBtn.Size = new System.Drawing.Size(80, 23);
            this.CopyNodeIdBtn.TabIndex = 4;
            this.CopyNodeIdBtn.Text = "复制节点ID";
            this.CopyNodeIdBtn.UseVisualStyleBackColor = true;
            this.CopyNodeIdBtn.Click += new System.EventHandler(this.CopyNodeIdBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "所选节点信息：";
            // 
            // NodeTreeView
            // 
            this.NodeTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NodeTreeView.ImageIndex = 10;
            this.NodeTreeView.ImageList = this.imageList1;
            this.NodeTreeView.Location = new System.Drawing.Point(3, 25);
            this.NodeTreeView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NodeTreeView.Name = "NodeTreeView";
            this.NodeTreeView.SelectedImageIndex = 10;
            this.NodeTreeView.Size = new System.Drawing.Size(351, 394);
            this.NodeTreeView.TabIndex = 1;
            this.NodeTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.NodeTreeView_BeforeExpand);
            this.NodeTreeView.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.NodeTreeView_BeforeSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "opc_browse.png");
            this.imageList1.Images.SetKeyName(1, "opc_browse_online.png");
            this.imageList1.Images.SetKeyName(2, "opc_datatype.png");
            this.imageList1.Images.SetKeyName(3, "opc_error.png");
            this.imageList1.Images.SetKeyName(4, "opc_method.png");
            this.imageList1.Images.SetKeyName(5, "opc_object.png");
            this.imageList1.Images.SetKeyName(6, "opc_objecttype.png");
            this.imageList1.Images.SetKeyName(7, "opc_property.png");
            this.imageList1.Images.SetKeyName(8, "opc_reftype.png");
            this.imageList1.Images.SetKeyName(9, "opc_success.png");
            this.imageList1.Images.SetKeyName(10, "opc_treefolder.png");
            this.imageList1.Images.SetKeyName(11, "opc_type.png");
            this.imageList1.Images.SetKeyName(12, "opc_variable.png");
            this.imageList1.Images.SetKeyName(13, "opc_variabletype.png");
            this.imageList1.Images.SetKeyName(14, "opc_view.png");
            this.imageList1.Images.SetKeyName(15, "opc_warning.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "服务端节点浏览：";
            // 
            // RwPage
            // 
            this.RwPage.Controls.Add(this.RwsGroupBox);
            this.RwPage.Controls.Add(this.RwGroupBox);
            this.RwPage.Location = new System.Drawing.Point(4, 25);
            this.RwPage.Margin = new System.Windows.Forms.Padding(2);
            this.RwPage.Name = "RwPage";
            this.RwPage.Size = new System.Drawing.Size(722, 420);
            this.RwPage.TabIndex = 2;
            this.RwPage.Text = " 读/写";
            this.RwPage.UseVisualStyleBackColor = true;
            // 
            // RwsGroupBox
            // 
            this.RwsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RwsGroupBox.Controls.Add(this.label24);
            this.RwsGroupBox.Controls.Add(this.label25);
            this.RwsGroupBox.Controls.Add(this.label26);
            this.RwsGroupBox.Controls.Add(this.label23);
            this.RwsGroupBox.Controls.Add(this.label22);
            this.RwsGroupBox.Controls.Add(this.label21);
            this.RwsGroupBox.Controls.Add(this.label20);
            this.RwsGroupBox.Controls.Add(this.WriteTextBox3);
            this.RwsGroupBox.Controls.Add(this.label19);
            this.RwsGroupBox.Controls.Add(this.WriteTextBox2);
            this.RwsGroupBox.Controls.Add(this.label18);
            this.RwsGroupBox.Controls.Add(this.WriteIdTextBox3);
            this.RwsGroupBox.Controls.Add(this.label17);
            this.RwsGroupBox.Controls.Add(this.WriteIdTextBox2);
            this.RwsGroupBox.Controls.Add(this.label16);
            this.RwsGroupBox.Controls.Add(this.WriteIdTextBox1);
            this.RwsGroupBox.Controls.Add(this.label15);
            this.RwsGroupBox.Controls.Add(this.ReadIdTextBox3);
            this.RwsGroupBox.Controls.Add(this.label14);
            this.RwsGroupBox.Controls.Add(this.ReadIdTextBox2);
            this.RwsGroupBox.Controls.Add(this.label13);
            this.RwsGroupBox.Controls.Add(this.ReadTextBox3);
            this.RwsGroupBox.Controls.Add(this.label10);
            this.RwsGroupBox.Controls.Add(this.ReadTextBox2);
            this.RwsGroupBox.Controls.Add(this.label12);
            this.RwsGroupBox.Controls.Add(this.label11);
            this.RwsGroupBox.Controls.Add(this.label9);
            this.RwsGroupBox.Controls.Add(this.WriteTextBox1);
            this.RwsGroupBox.Controls.Add(this.ReadTextBox1);
            this.RwsGroupBox.Controls.Add(this.ReadIdTextBox1);
            this.RwsGroupBox.Controls.Add(this.MulWriteButton);
            this.RwsGroupBox.Controls.Add(this.MulReadButton);
            this.RwsGroupBox.Location = new System.Drawing.Point(5, 135);
            this.RwsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.RwsGroupBox.Name = "RwsGroupBox";
            this.RwsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.RwsGroupBox.Size = new System.Drawing.Size(712, 284);
            this.RwsGroupBox.TabIndex = 1;
            this.RwsGroupBox.TabStop = false;
            this.RwsGroupBox.Text = "多节点读/写";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(99, 256);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(17, 12);
            this.label24.TabIndex = 62;
            this.label24.Text = "3:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(99, 212);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(17, 12);
            this.label25.TabIndex = 61;
            this.label25.Text = "2:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(99, 168);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(17, 12);
            this.label26.TabIndex = 60;
            this.label26.Text = "1:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(99, 116);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(17, 12);
            this.label23.TabIndex = 59;
            this.label23.Text = "3:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(99, 72);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(17, 12);
            this.label22.TabIndex = 58;
            this.label22.Text = "2:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(100, 28);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 12);
            this.label21.TabIndex = 57;
            this.label21.Text = "1:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(418, 239);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 12);
            this.label20.TabIndex = 56;
            this.label20.Text = "Value to write:";
            // 
            // WriteTextBox3
            // 
            this.WriteTextBox3.Location = new System.Drawing.Point(420, 254);
            this.WriteTextBox3.Margin = new System.Windows.Forms.Padding(2);
            this.WriteTextBox3.Name = "WriteTextBox3";
            this.WriteTextBox3.Size = new System.Drawing.Size(271, 21);
            this.WriteTextBox3.TabIndex = 55;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(418, 195);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 12);
            this.label19.TabIndex = 54;
            this.label19.Text = "Value to write:";
            // 
            // WriteTextBox2
            // 
            this.WriteTextBox2.Location = new System.Drawing.Point(420, 210);
            this.WriteTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.WriteTextBox2.Name = "WriteTextBox2";
            this.WriteTextBox2.Size = new System.Drawing.Size(271, 21);
            this.WriteTextBox2.TabIndex = 53;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(118, 239);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 52;
            this.label18.Text = "Node Id:";
            // 
            // WriteIdTextBox3
            // 
            this.WriteIdTextBox3.Location = new System.Drawing.Point(121, 254);
            this.WriteIdTextBox3.Margin = new System.Windows.Forms.Padding(2);
            this.WriteIdTextBox3.Name = "WriteIdTextBox3";
            this.WriteIdTextBox3.Size = new System.Drawing.Size(271, 21);
            this.WriteIdTextBox3.TabIndex = 51;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(118, 195);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 50;
            this.label17.Text = "Node Id:";
            // 
            // WriteIdTextBox2
            // 
            this.WriteIdTextBox2.Location = new System.Drawing.Point(121, 210);
            this.WriteIdTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.WriteIdTextBox2.Name = "WriteIdTextBox2";
            this.WriteIdTextBox2.Size = new System.Drawing.Size(271, 21);
            this.WriteIdTextBox2.TabIndex = 49;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(118, 151);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 48;
            this.label16.Text = "Node Id:";
            // 
            // WriteIdTextBox1
            // 
            this.WriteIdTextBox1.Location = new System.Drawing.Point(121, 166);
            this.WriteIdTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.WriteIdTextBox1.Name = "WriteIdTextBox1";
            this.WriteIdTextBox1.Size = new System.Drawing.Size(271, 21);
            this.WriteIdTextBox1.TabIndex = 47;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(118, 99);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 46;
            this.label15.Text = "Node Id:";
            // 
            // ReadIdTextBox3
            // 
            this.ReadIdTextBox3.Location = new System.Drawing.Point(121, 114);
            this.ReadIdTextBox3.Margin = new System.Windows.Forms.Padding(2);
            this.ReadIdTextBox3.Name = "ReadIdTextBox3";
            this.ReadIdTextBox3.Size = new System.Drawing.Size(271, 21);
            this.ReadIdTextBox3.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(118, 55);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 44;
            this.label14.Text = "Node Id:";
            // 
            // ReadIdTextBox2
            // 
            this.ReadIdTextBox2.Location = new System.Drawing.Point(121, 70);
            this.ReadIdTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.ReadIdTextBox2.Name = "ReadIdTextBox2";
            this.ReadIdTextBox2.Size = new System.Drawing.Size(271, 21);
            this.ReadIdTextBox2.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(418, 99);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 12);
            this.label13.TabIndex = 42;
            this.label13.Text = "Read Value:";
            // 
            // ReadTextBox3
            // 
            this.ReadTextBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.ReadTextBox3.Location = new System.Drawing.Point(420, 114);
            this.ReadTextBox3.Margin = new System.Windows.Forms.Padding(2);
            this.ReadTextBox3.Name = "ReadTextBox3";
            this.ReadTextBox3.Size = new System.Drawing.Size(271, 21);
            this.ReadTextBox3.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(418, 55);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 12);
            this.label10.TabIndex = 40;
            this.label10.Text = "Read Value:";
            // 
            // ReadTextBox2
            // 
            this.ReadTextBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.ReadTextBox2.Location = new System.Drawing.Point(420, 70);
            this.ReadTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.ReadTextBox2.Name = "ReadTextBox2";
            this.ReadTextBox2.Size = new System.Drawing.Size(271, 21);
            this.ReadTextBox2.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(418, 151);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 12);
            this.label12.TabIndex = 38;
            this.label12.Text = "Value to write:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(418, 11);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 12);
            this.label11.TabIndex = 37;
            this.label11.Text = "Read Value:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(118, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 35;
            this.label9.Text = "Node Id:";
            // 
            // WriteTextBox1
            // 
            this.WriteTextBox1.Location = new System.Drawing.Point(420, 166);
            this.WriteTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.WriteTextBox1.Name = "WriteTextBox1";
            this.WriteTextBox1.Size = new System.Drawing.Size(271, 21);
            this.WriteTextBox1.TabIndex = 7;
            // 
            // ReadTextBox1
            // 
            this.ReadTextBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.ReadTextBox1.Location = new System.Drawing.Point(420, 26);
            this.ReadTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.ReadTextBox1.Name = "ReadTextBox1";
            this.ReadTextBox1.Size = new System.Drawing.Size(271, 21);
            this.ReadTextBox1.TabIndex = 6;
            // 
            // ReadIdTextBox1
            // 
            this.ReadIdTextBox1.Location = new System.Drawing.Point(121, 26);
            this.ReadIdTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.ReadIdTextBox1.Name = "ReadIdTextBox1";
            this.ReadIdTextBox1.Size = new System.Drawing.Size(271, 21);
            this.ReadIdTextBox1.TabIndex = 4;
            // 
            // MulWriteButton
            // 
            this.MulWriteButton.Location = new System.Drawing.Point(22, 166);
            this.MulWriteButton.Margin = new System.Windows.Forms.Padding(2);
            this.MulWriteButton.Name = "MulWriteButton";
            this.MulWriteButton.Size = new System.Drawing.Size(69, 22);
            this.MulWriteButton.TabIndex = 2;
            this.MulWriteButton.Text = "写 入";
            this.MulWriteButton.UseVisualStyleBackColor = true;
            this.MulWriteButton.Click += new System.EventHandler(this.MulWriteButton_Click);
            // 
            // MulReadButton
            // 
            this.MulReadButton.Location = new System.Drawing.Point(22, 26);
            this.MulReadButton.Margin = new System.Windows.Forms.Padding(2);
            this.MulReadButton.Name = "MulReadButton";
            this.MulReadButton.Size = new System.Drawing.Size(69, 22);
            this.MulReadButton.TabIndex = 1;
            this.MulReadButton.Text = "读 取";
            this.MulReadButton.UseVisualStyleBackColor = true;
            this.MulReadButton.Click += new System.EventHandler(this.MulReadButton_Click);
            // 
            // RwGroupBox
            // 
            this.RwGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RwGroupBox.Controls.Add(this.MatrixLabel);
            this.RwGroupBox.Controls.Add(this.MatrixCheckBox);
            this.RwGroupBox.Controls.Add(this.ReadMatrixButton);
            this.RwGroupBox.Controls.Add(this.WriteTextBox);
            this.RwGroupBox.Controls.Add(this.label8);
            this.RwGroupBox.Controls.Add(this.label7);
            this.RwGroupBox.Controls.Add(this.label6);
            this.RwGroupBox.Controls.Add(this.label5);
            this.RwGroupBox.Controls.Add(this.ReadTextBox);
            this.RwGroupBox.Controls.Add(this.WriteIdTextBox);
            this.RwGroupBox.Controls.Add(this.ReadIdTextBox);
            this.RwGroupBox.Controls.Add(this.WriteButton);
            this.RwGroupBox.Controls.Add(this.ReadButton);
            this.RwGroupBox.Location = new System.Drawing.Point(5, 2);
            this.RwGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.RwGroupBox.Name = "RwGroupBox";
            this.RwGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.RwGroupBox.Size = new System.Drawing.Size(712, 128);
            this.RwGroupBox.TabIndex = 0;
            this.RwGroupBox.TabStop = false;
            this.RwGroupBox.Text = "读/写";
            // 
            // MatrixLabel
            // 
            this.MatrixLabel.AutoSize = true;
            this.MatrixLabel.Location = new System.Drawing.Point(124, 103);
            this.MatrixLabel.Name = "MatrixLabel";
            this.MatrixLabel.Size = new System.Drawing.Size(149, 12);
            this.MatrixLabel.TabIndex = 66;
            this.MatrixLabel.Text = "按下写入按钮将值写入窗口";
            this.MatrixLabel.Visible = false;
            // 
            // MatrixCheckBox
            // 
            this.MatrixCheckBox.AutoSize = true;
            this.MatrixCheckBox.Location = new System.Drawing.Point(420, 62);
            this.MatrixCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.MatrixCheckBox.Name = "MatrixCheckBox";
            this.MatrixCheckBox.Size = new System.Drawing.Size(150, 16);
            this.MatrixCheckBox.TabIndex = 65;
            this.MatrixCheckBox.Text = "Array/Matrix Checkbox";
            this.MatrixCheckBox.UseVisualStyleBackColor = true;
            this.MatrixCheckBox.Visible = false;
            this.MatrixCheckBox.CheckedChanged += new System.EventHandler(this.MatrixCheckBox_CheckedChanged);
            // 
            // ReadMatrixButton
            // 
            this.ReadMatrixButton.BackColor = System.Drawing.Color.Gainsboro;
            this.ReadMatrixButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ReadMatrixButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ReadMatrixButton.Location = new System.Drawing.Point(659, 25);
            this.ReadMatrixButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReadMatrixButton.Name = "ReadMatrixButton";
            this.ReadMatrixButton.Size = new System.Drawing.Size(31, 19);
            this.ReadMatrixButton.TabIndex = 64;
            this.ReadMatrixButton.Text = "...";
            this.ReadMatrixButton.UseVisualStyleBackColor = false;
            this.ReadMatrixButton.Visible = false;
            // 
            // WriteTextBox
            // 
            this.WriteTextBox.Location = new System.Drawing.Point(121, 99);
            this.WriteTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WriteTextBox.Name = "WriteTextBox";
            this.WriteTextBox.Size = new System.Drawing.Size(570, 21);
            this.WriteTextBox.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 85);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 36;
            this.label8.Text = "value to write";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 35;
            this.label7.Text = "read value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 34;
            this.label6.Text = "Node Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 33;
            this.label5.Text = "Node Id:";
            // 
            // ReadTextBox
            // 
            this.ReadTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.ReadTextBox.Location = new System.Drawing.Point(420, 24);
            this.ReadTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReadTextBox.Name = "ReadTextBox";
            this.ReadTextBox.Size = new System.Drawing.Size(271, 21);
            this.ReadTextBox.TabIndex = 32;
            // 
            // WriteIdTextBox
            // 
            this.WriteIdTextBox.Location = new System.Drawing.Point(121, 62);
            this.WriteIdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WriteIdTextBox.Name = "WriteIdTextBox";
            this.WriteIdTextBox.Size = new System.Drawing.Size(271, 21);
            this.WriteIdTextBox.TabIndex = 31;
            // 
            // ReadIdTextBox
            // 
            this.ReadIdTextBox.Location = new System.Drawing.Point(121, 24);
            this.ReadIdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReadIdTextBox.Name = "ReadIdTextBox";
            this.ReadIdTextBox.Size = new System.Drawing.Size(271, 21);
            this.ReadIdTextBox.TabIndex = 30;
            // 
            // WriteButton
            // 
            this.WriteButton.Location = new System.Drawing.Point(22, 61);
            this.WriteButton.Margin = new System.Windows.Forms.Padding(2);
            this.WriteButton.Name = "WriteButton";
            this.WriteButton.Size = new System.Drawing.Size(69, 22);
            this.WriteButton.TabIndex = 1;
            this.WriteButton.Text = "写 入";
            this.WriteButton.UseVisualStyleBackColor = true;
            this.WriteButton.Click += new System.EventHandler(this.WriteButton_Click);
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(22, 23);
            this.ReadButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(69, 22);
            this.ReadButton.TabIndex = 0;
            this.ReadButton.Text = "读 取";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // SubscribePage
            // 
            this.SubscribePage.Controls.Add(this.SubscriptionTextBox);
            this.SubscribePage.Controls.Add(this.label28);
            this.SubscribePage.Controls.Add(this.UnsubscribeButton);
            this.SubscribePage.Controls.Add(this.SubscribeButton);
            this.SubscribePage.Controls.Add(this.SubNodeIdTextBox);
            this.SubscribePage.Controls.Add(this.label27);
            this.SubscribePage.Location = new System.Drawing.Point(4, 25);
            this.SubscribePage.Margin = new System.Windows.Forms.Padding(2);
            this.SubscribePage.Name = "SubscribePage";
            this.SubscribePage.Size = new System.Drawing.Size(722, 420);
            this.SubscribePage.TabIndex = 3;
            this.SubscribePage.Text = " 订阅";
            this.SubscribePage.UseVisualStyleBackColor = true;
            // 
            // SubscriptionTextBox
            // 
            this.SubscriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubscriptionTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.SubscriptionTextBox.Location = new System.Drawing.Point(16, 93);
            this.SubscriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SubscriptionTextBox.Multiline = true;
            this.SubscriptionTextBox.Name = "SubscriptionTextBox";
            this.SubscriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SubscriptionTextBox.Size = new System.Drawing.Size(691, 314);
            this.SubscriptionTextBox.TabIndex = 5;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(14, 78);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(53, 12);
            this.label28.TabIndex = 4;
            this.label28.Text = "订阅信息";
            // 
            // UnsubscribeButton
            // 
            this.UnsubscribeButton.Location = new System.Drawing.Point(116, 50);
            this.UnsubscribeButton.Margin = new System.Windows.Forms.Padding(2);
            this.UnsubscribeButton.Name = "UnsubscribeButton";
            this.UnsubscribeButton.Size = new System.Drawing.Size(86, 22);
            this.UnsubscribeButton.TabIndex = 3;
            this.UnsubscribeButton.Text = "取消订阅";
            this.UnsubscribeButton.UseVisualStyleBackColor = true;
            this.UnsubscribeButton.Click += new System.EventHandler(this.UnsubscribeButton_Click);
            // 
            // SubscribeButton
            // 
            this.SubscribeButton.Location = new System.Drawing.Point(14, 50);
            this.SubscribeButton.Margin = new System.Windows.Forms.Padding(2);
            this.SubscribeButton.Name = "SubscribeButton";
            this.SubscribeButton.Size = new System.Drawing.Size(86, 22);
            this.SubscribeButton.TabIndex = 2;
            this.SubscribeButton.Text = "订 阅";
            this.SubscribeButton.UseVisualStyleBackColor = true;
            this.SubscribeButton.Click += new System.EventHandler(this.SubscribeButton_Click);
            // 
            // SubNodeIdTextBox
            // 
            this.SubNodeIdTextBox.Location = new System.Drawing.Point(14, 25);
            this.SubNodeIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SubNodeIdTextBox.Name = "SubNodeIdTextBox";
            this.SubNodeIdTextBox.Size = new System.Drawing.Size(189, 21);
            this.SubNodeIdTextBox.TabIndex = 1;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(12, 10);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 12);
            this.label27.TabIndex = 0;
            this.label27.Text = "Node Id:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label29.Location = new System.Drawing.Point(292, 399);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(427, 14);
            this.label29.TabIndex = 5;
            this.label29.Text = "Copyright (C) 2023 西北工业大学-潘家乐. A11 rights reserved.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 449);
            this.Controls.Add(this.OpcTabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(746, 488);
            this.Name = "MainForm";
            this.Text = "OPC UA Client";
            this.OpcTabControl.ResumeLayout(false);
            this.ConnectPage.ResumeLayout(false);
            this.ConnectPage.PerformLayout();
            this.userGroupBox.ResumeLayout(false);
            this.userGroupBox.PerformLayout();
            this.BrowsePage.ResumeLayout(false);
            this.BrowsePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionGridView)).EndInit();
            this.RwPage.ResumeLayout(false);
            this.RwsGroupBox.ResumeLayout(false);
            this.RwsGroupBox.PerformLayout();
            this.RwGroupBox.ResumeLayout(false);
            this.RwGroupBox.PerformLayout();
            this.SubscribePage.ResumeLayout(false);
            this.SubscribePage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl OpcTabControl;
        private System.Windows.Forms.TabPage ConnectPage;
        private System.Windows.Forms.TabPage BrowsePage;
        private System.Windows.Forms.TabPage RwPage;
        private System.Windows.Forms.TabPage SubscribePage;
        private System.Windows.Forms.Button EndpointButton;
        private System.Windows.Forms.TextBox DiscoveryTextBox;
        private System.Windows.Forms.Label EndpointLabel;
        private System.Windows.Forms.GroupBox userGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EpConnectButton;
        private System.Windows.Forms.TextBox PwTextBox;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.RadioButton UserPwRadioButton;
        private System.Windows.Forms.ListView EndpointListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TreeView NodeTreeView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CopyNodeIdBtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView DescriptionGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueColumn;
        private System.Windows.Forms.GroupBox RwsGroupBox;
        private System.Windows.Forms.GroupBox RwGroupBox;
        private System.Windows.Forms.Button MulWriteButton;
        private System.Windows.Forms.Button MulReadButton;
        private System.Windows.Forms.TextBox WriteTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ReadTextBox;
        private System.Windows.Forms.TextBox WriteIdTextBox;
        private System.Windows.Forms.TextBox ReadIdTextBox;
        private System.Windows.Forms.Button WriteButton;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.TextBox WriteTextBox1;
        private System.Windows.Forms.TextBox ReadTextBox1;
        private System.Windows.Forms.TextBox ReadIdTextBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ReadTextBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ReadTextBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox WriteIdTextBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox WriteIdTextBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox WriteIdTextBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ReadIdTextBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ReadIdTextBox2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox WriteTextBox3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox WriteTextBox2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button ReadMatrixButton;
        private System.Windows.Forms.CheckBox MatrixCheckBox;
        private System.Windows.Forms.Label MatrixLabel;
        private System.Windows.Forms.TextBox SubscriptionTextBox;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button UnsubscribeButton;
        private System.Windows.Forms.Button SubscribeButton;
        private System.Windows.Forms.TextBox SubNodeIdTextBox;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.RadioButton AnonRadioButton;
        private System.Windows.Forms.Label label29;
    }
}

