//=============================================================================
// Siemens AG
// (c)Copyright (2018) All Rights Reserved
//----------------------------------------------------------------------------- 
// Tested with: Windows 10 Enterprise x64
// Engineering: Visual Studio 2013
// Functionality: Wrapps up important classes/methods of the OPC UA .NET Stack to help
// with simple client implementations
//-----------------------------------------------------------------------------
// Change log table:
// Version Date Expert in charge Changes applied
// 01.00.00 31.08.2016 (Siemens) First released version
// 01.01.00 22.02.2017 (Siemens) Implements user authentication, SHA256 Cert, Basic256Rsa256 connection,
// Basic256Rsa256 connections, read/write structs/UDTs
// 01.02.00 14.12.2017 (Siemens) Implements method calling
// 01.03.00 27.11.2018 (Siemens) Updated UAClientHelperAPI V1.4, Improved endpoint handling
//=============================================================================

using Siemens.UAClientHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opc.Ua.Client;
using Opc.Ua;

namespace UaClient_Foundation
{
    public partial class UAClientMatrixForm : Form
    {
        /// <summary>
        /// Fields
        /// </summary>
        #region Fields
        //private UAClientForm myClientForm;
        //private UAClientHelperAPI myClientHelperAPI;
        public List<string> valuesToWrite { get; set; }
        #endregion

        /// <summary>
        /// Form Construction
        /// </summary>
        #region Construction
        public UAClientMatrixForm(string[,] matrixArray, object sender)
        {
            
            InitializeComponent();
            matrixGridView.Columns[0].DefaultCellStyle.BackColor = Color.Gainsboro;
            matrixGridView.Columns[1].DefaultCellStyle.BackColor = Color.Gainsboro;
            matrixGridView.Columns[2].DefaultCellStyle.BackColor = Color.Gainsboro;
            matrixGridView.Columns[1].ReadOnly = true;
            matrixViewWrite.Visible = false;
            int arrayLength = matrixArray.GetLength(0);
            valuesToWrite = new List<string>();
            if (sender.ToString() == "System.Windows.Forms.Button, Text: Read")
            {
                for (int i = 0; i < arrayLength; i++)
                {
                    matrixGridView.Rows.Add();
                    matrixGridView.Rows[i].Cells[0].Value = matrixArray[i, 0];
                    matrixGridView.Rows[i].Cells[1].Value = matrixArray[i, 1];
                    matrixGridView.Rows[i].Cells[2].Value = matrixArray[i, 2];
                }
                matrixGridView.Size = new Size(367, 510);
            }
            else
            {
                for (int i = 0; i < arrayLength; i++)
                {
                    matrixGridView.Rows.Add();
                    matrixGridView.Rows[i].Cells[0].Value = matrixArray[i, 0];
                    matrixGridView.Rows[i].Cells[1].Value = matrixArray[i, 1];
                    matrixGridView.Rows[i].Cells[2].Value = matrixArray[i, 2];
                }
                matrixGridView.Size = new Size(367,460);
                matrixGridView.Columns[1].DefaultCellStyle.BackColor = Color.White;
                matrixGridView.Columns[1].ReadOnly = false;
                matrixViewWrite.Visible = true;
            }
        }
        #endregion

        #region UserInteractionHandlers
        private void matrixViewWrite_Click(object sender, EventArgs e)
        {
            valuesToWrite.Clear();
            foreach(DataGridViewRow row in matrixGridView.Rows)
            {
                valuesToWrite.Add(row.Cells[1].Value.ToString());
            }

            DialogResult = DialogResult.OK;
            Close();
        }
        #endregion
    }
}
