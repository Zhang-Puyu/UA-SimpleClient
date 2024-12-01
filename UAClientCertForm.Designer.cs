namespace UaClient_Foundation
{
    partial class UAClientCertForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.certGridView = new System.Windows.Forms.DataGridView();
            this.acceptButton = new System.Windows.Forms.Button();
            this.rejectButton = new System.Windows.Forms.Button();
            this.permaCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AttributeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.certGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // certGridView
            // 
            this.certGridView.AllowUserToAddRows = false;
            this.certGridView.AllowUserToDeleteRows = false;
            this.certGridView.AllowUserToResizeColumns = false;
            this.certGridView.AllowUserToResizeRows = false;
            this.certGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.certGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.certGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.certGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.certGridView.CausesValidation = false;
            this.certGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.certGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.certGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttributeColumn,
            this.ValueColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.certGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.certGridView.Location = new System.Drawing.Point(12, 29);
            this.certGridView.Name = "certGridView";
            this.certGridView.ReadOnly = true;
            this.certGridView.RowHeadersVisible = false;
            this.certGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.certGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.certGridView.ShowEditingIcon = false;
            this.certGridView.Size = new System.Drawing.Size(365, 330);
            this.certGridView.TabIndex = 0;
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.acceptButton.Location = new System.Drawing.Point(12, 388);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 1;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // rejectButton
            // 
            this.rejectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rejectButton.Location = new System.Drawing.Point(93, 388);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(75, 23);
            this.rejectButton.TabIndex = 2;
            this.rejectButton.Text = "Reject";
            this.rejectButton.UseVisualStyleBackColor = true;
            this.rejectButton.Click += new System.EventHandler(this.rejectButton_Click);
            // 
            // permaCheckBox
            // 
            this.permaCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.permaCheckBox.AutoSize = true;
            this.permaCheckBox.Location = new System.Drawing.Point(12, 365);
            this.permaCheckBox.Name = "permaCheckBox";
            this.permaCheckBox.Size = new System.Drawing.Size(169, 17);
            this.permaCheckBox.TabIndex = 3;
            this.permaCheckBox.Text = "Accept certificate permanently";
            this.permaCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Certificate details:";
            // 
            // AttributeColumn
            // 
            this.AttributeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.AttributeColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.AttributeColumn.HeaderText = "Attribute";
            this.AttributeColumn.Name = "AttributeColumn";
            this.AttributeColumn.ReadOnly = true;
            this.AttributeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ValueColumn
            // 
            this.ValueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            this.ValueColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.ValueColumn.HeaderText = "Value";
            this.ValueColumn.Name = "ValueColumn";
            this.ValueColumn.ReadOnly = true;
            this.ValueColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UAClientCertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 438);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.permaCheckBox);
            this.Controls.Add(this.rejectButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.certGridView);
            this.DoubleBuffered = true;
            this.Name = "UAClientCertForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPC UA Client - Certificate Validation";
            this.VisibleChanged += new System.EventHandler(this.UAClientCertForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.certGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView certGridView;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button rejectButton;
        private System.Windows.Forms.CheckBox permaCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttributeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueColumn;
    }
}