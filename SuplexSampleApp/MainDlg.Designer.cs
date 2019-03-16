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
            this.lblId = new System.Windows.Forms.Label();
            this.ibiName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.frmMain = new System.Windows.Forms.GroupBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblInfoData = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.cmdRefreshNow = new System.Windows.Forms.Button();
            this.chkApplyRecursive = new System.Windows.Forms.CheckBox();
            this.lstEmployees = new System.Windows.Forms.ListBox();
            this.frmMain.SuspendLayout();
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
            // ibiName
            // 
            this.ibiName.Location = new System.Drawing.Point(123, 70);
            this.ibiName.Name = "ibiName";
            this.ibiName.Size = new System.Drawing.Size(154, 22);
            this.ibiName.TabIndex = 5;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(202, 111);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.frmMain.Controls.Add(this.pnlInfo);
            this.frmMain.Controls.Add(this.txtId);
            this.frmMain.Controls.Add(this.lblEmployeeName);
            this.frmMain.Controls.Add(this.lblId);
            this.frmMain.Controls.Add(this.btnCreate);
            this.frmMain.Controls.Add(this.ibiName);
            this.frmMain.Location = new System.Drawing.Point(169, 152);
            this.frmMain.Name = "frmMain";
            this.frmMain.Size = new System.Drawing.Size(311, 217);
            this.frmMain.TabIndex = 7;
            this.frmMain.TabStop = false;
            this.frmMain.Text = "Employee Form (frmMain)";
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
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(123, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(154, 22);
            this.txtId.TabIndex = 8;
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
            // chkApplyRecursive
            // 
            this.chkApplyRecursive.AutoSize = true;
            this.chkApplyRecursive.Location = new System.Drawing.Point(169, 93);
            this.chkApplyRecursive.Name = "chkApplyRecursive";
            this.chkApplyRecursive.Size = new System.Drawing.Size(132, 21);
            this.chkApplyRecursive.TabIndex = 10;
            this.chkApplyRecursive.Text = "Apply Recursive";
            this.chkApplyRecursive.UseVisualStyleBackColor = true;
            // 
            // lstEmployees
            // 
            this.lstEmployees.DisplayMember = "Name";
            this.lstEmployees.FormattingEnabled = true;
            this.lstEmployees.ItemHeight = 16;
            this.lstEmployees.Location = new System.Drawing.Point(15, 152);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(148, 212);
            this.lstEmployees.TabIndex = 11;
            // 
            // MainDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 399);
            this.Controls.Add(this.lstEmployees);
            this.Controls.Add(this.chkApplyRecursive);
            this.Controls.Add(this.cmdRefreshNow);
            this.Controls.Add(this.cmdBrowse);
            this.Controls.Add(this.frmMain);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.lblSuplexFileStorePath);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.txtSuplexFileStorePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainDlg";
            this.Text = "Suplex FileStore Sample";
            this.frmMain.ResumeLayout(false);
            this.frmMain.PerformLayout();
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
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox ibiName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox frmMain;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.Button cmdRefreshNow;
        private System.Windows.Forms.CheckBox chkApplyRecursive;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblInfoData;
        private System.Windows.Forms.ListBox lstEmployees;
    }
}

