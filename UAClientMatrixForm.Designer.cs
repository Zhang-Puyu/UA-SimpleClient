namespace UaClient_Foundation
{
    partial class UAClientMatrixForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UAClientMatrixForm));
            this.matrixGridView = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Values = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writeDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matrixViewWrite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.matrixGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // matrixGridView
            // 
            this.matrixGridView.AllowUserToAddRows = false;
            this.matrixGridView.AllowUserToDeleteRows = false;
            this.matrixGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.matrixGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Values,
            this.writeDataType});
            this.matrixGridView.Location = new System.Drawing.Point(12, 12);
            this.matrixGridView.Name = "matrixGridView";
            this.matrixGridView.RowHeadersVisible = false;
            this.matrixGridView.Size = new System.Drawing.Size(367, 459);
            this.matrixGridView.TabIndex = 62;
            // 
            // Index
            // 
            this.Index.HeaderText = "Index";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Values
            // 
            this.Values.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Values.HeaderText = "Values";
            this.Values.Name = "Values";
            this.Values.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // writeDataType
            // 
            this.writeDataType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.writeDataType.HeaderText = "Data Type";
            this.writeDataType.Name = "writeDataType";
            this.writeDataType.ReadOnly = true;
            this.writeDataType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // matrixViewWrite
            // 
            this.matrixViewWrite.Location = new System.Drawing.Point(251, 484);
            this.matrixViewWrite.Name = "matrixViewWrite";
            this.matrixViewWrite.Size = new System.Drawing.Size(127, 38);
            this.matrixViewWrite.TabIndex = 63;
            this.matrixViewWrite.Text = "Edit values";
            this.matrixViewWrite.UseVisualStyleBackColor = true;
            this.matrixViewWrite.Click += new System.EventHandler(this.matrixViewWrite_Click);
            // 
            // UAClientMatrixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 534);
            this.Controls.Add(this.matrixViewWrite);
            this.Controls.Add(this.matrixGridView);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UAClientMatrixForm";
            this.ShowIcon = false;
            this.Text = "OPC UA Client - Matrix View";
            ((System.ComponentModel.ISupportInitialize)(this.matrixGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView matrixGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Values;
        private System.Windows.Forms.DataGridViewTextBoxColumn writeDataType;
        private System.Windows.Forms.Button matrixViewWrite;
    }
}