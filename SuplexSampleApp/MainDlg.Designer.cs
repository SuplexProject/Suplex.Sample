namespace SuplexSampleApp
{
    partial class MainDlg
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
            if( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSuplexFileStorePath = new System.Windows.Forms.TextBox();
            this.dlgOpenSuplexFileStore = new System.Windows.Forms.OpenFileDialog();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.lblSuplexFileStorePath = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.cmdRefreshNow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstEmployees = new System.Windows.Forms.ListBox();
            this.frmEditor = new System.Windows.Forms.GroupBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblInfoData = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.frmEditor.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSuplexFileStorePath
            // 
            this.txtSuplexFileStorePath.Location = new System.Drawing.Point(169, 15);
            this.txtSuplexFileStorePath.Name = "txtSuplexFileStorePath";
            this.txtSuplexFileStorePath.Size = new System.Drawing.Size(528, 22);
            this.txtSuplexFileStorePath.TabIndex = 0;
            // 
            // dlgOpenSuplexFileStore
            // 
            this.dlgOpenSuplexFileStore.FileName = "*.splx";
            // 
            // cmbUsers
            // 
            this.cmbUsers.DisplayMember = "Name";
            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(169, 54);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(251, 24);
            this.cmbUsers.TabIndex = 1;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // lblSuplexFileStorePath
            // 
            this.lblSuplexFileStorePath.AutoSize = true;
            this.lblSuplexFileStorePath.Location = new System.Drawing.Point(12, 18);
            this.lblSuplexFileStorePath.Name = "lblSuplexFileStorePath";
            this.lblSuplexFileStorePath.Size = new System.Drawing.Size(151, 17);
            this.lblSuplexFileStorePath.TabIndex = 2;
            this.lblSuplexFileStorePath.Text = "Suplex File Store Path:";
            this.lblSuplexFileStorePath.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Location = new System.Drawing.Point(114, 57);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(49, 17);
            this.lblUsers.TabIndex = 3;
            this.lblUsers.Text = "Users:";
            this.lblUsers.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Location = new System.Drawing.Point(700, 14);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(51, 27);
            this.cmdBrowse.TabIndex = 8;
            this.cmdBrowse.Text = "●●●";
            this.cmdBrowse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // cmdRefreshNow
            // 
            this.cmdRefreshNow.Location = new System.Drawing.Point(534, 54);
            this.cmdRefreshNow.Name = "cmdRefreshNow";
            this.cmdRefreshNow.Size = new System.Drawing.Size(163, 27);
            this.cmdRefreshNow.TabIndex = 9;
            this.cmdRefreshNow.Text = "Refresh Suplex Now";
            this.cmdRefreshNow.UseVisualStyleBackColor = true;
            this.cmdRefreshNow.Click += new System.EventHandler(this.cmdRefreshNow_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lstEmployees);
            this.panel1.Controls.Add(this.frmEditor);
            this.panel1.Location = new System.Drawing.Point(15, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 267);
            this.panel1.TabIndex = 12;
            // 
            // lstEmployees
            // 
            this.lstEmployees.DisplayMember = "Name";
            this.lstEmployees.FormattingEnabled = true;
            this.lstEmployees.ItemHeight = 16;
            this.lstEmployees.Location = new System.Drawing.Point(152, 42);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(148, 196);
            this.lstEmployees.TabIndex = 13;
            this.lstEmployees.SelectedIndexChanged += new System.EventHandler(this.lstEmployees_SelectedIndexChanged);
            // 
            // frmEditor
            // 
            this.frmEditor.Controls.Add(this.lblEmployeeId);
            this.frmEditor.Controls.Add(this.pnlInfo);
            this.frmEditor.Controls.Add(this.lblEmployeeName);
            this.frmEditor.Controls.Add(this.lblId);
            this.frmEditor.Controls.Add(this.btnUpdate);
            this.frmEditor.Controls.Add(this.txtName);
            this.frmEditor.Location = new System.Drawing.Point(308, 23);
            this.frmEditor.Name = "frmEditor";
            this.frmEditor.Size = new System.Drawing.Size(311, 217);
            this.frmEditor.TabIndex = 12;
            this.frmEditor.TabStop = false;
            this.frmEditor.Text = "Employee Form (frmEditor)";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.lblInfoData);
            this.pnlInfo.Location = new System.Drawing.Point(22, 157);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(255, 43);
            this.pnlInfo.TabIndex = 11;
            // 
            // lblInfoData
            // 
            this.lblInfoData.AutoSize = true;
            this.lblInfoData.Location = new System.Drawing.Point(14, 14);
            this.lblInfoData.Name = "lblInfoData";
            this.lblInfoData.Size = new System.Drawing.Size(185, 17);
            this.lblInfoData.TabIndex = 0;
            this.lblInfoData.Text = "Some important words here.";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(59, 73);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(49, 17);
            this.lblEmployeeName.TabIndex = 7;
            this.lblEmployeeName.Text = "Name:";
            this.lblEmployeeName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(19, 36);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(89, 17);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Employee Id:";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(202, 111);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 28);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 22);
            this.txtName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Employees:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(120, 36);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(0, 17);
            this.lblEmployeeId.TabIndex = 12;
            this.lblEmployeeId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 399);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdRefreshNow);
            this.Controls.Add(this.cmdBrowse);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.lblSuplexFileStorePath);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.txtSuplexFileStorePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainDlg";
            this.Text = "Suplex Security Sample";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.frmEditor.ResumeLayout(false);
            this.frmEditor.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSuplexFileStorePath;
        private System.Windows.Forms.OpenFileDialog dlgOpenSuplexFileStore;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Label lblSuplexFileStorePath;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.Button cmdRefreshNow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstEmployees;
        private System.Windows.Forms.GroupBox frmEditor;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblInfoData;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmployeeId;
    }
}

