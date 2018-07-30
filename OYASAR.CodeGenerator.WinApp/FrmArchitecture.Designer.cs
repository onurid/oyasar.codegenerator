namespace OYASAR.CodeGenerator.WinApp
{
    partial class FrmArchitecture
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
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.cmbORMType = new System.Windows.Forms.ComboBox();
            this.lblORMType = new System.Windows.Forms.Label();
            this.lblMapper = new System.Windows.Forms.Label();
            this.cmbMapper = new System.Windows.Forms.ComboBox();
            this.lblIOC = new System.Windows.Forms.Label();
            this.cmbIOC = new System.Windows.Forms.ComboBox();
            this.lblFrameworkType = new System.Windows.Forms.Label();
            this.cmbFrameworkType = new System.Windows.Forms.ComboBox();
            this.lblArchitecture = new System.Windows.Forms.Label();
            this.lblTools = new System.Windows.Forms.Label();
            this.blArcihtecureDesign = new System.Windows.Forms.Label();
            this.cmbArchitectureDesign = new System.Windows.Forms.ComboBox();
            this.grpProjectInfo = new System.Windows.Forms.GroupBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnClick = new System.Windows.Forms.Button();
            this.btnCloseLog = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.listProjectName = new System.Windows.Forms.ListBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(209, 116);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(121, 20);
            this.txtProjectName.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(435, 307);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(200, 45);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(206, 100);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(71, 13);
            this.lblProjectName.TabIndex = 2;
            this.lblProjectName.Text = "Project Name";
            // 
            // cmbORMType
            // 
            this.cmbORMType.FormattingEnabled = true;
            this.cmbORMType.Location = new System.Drawing.Point(515, 43);
            this.cmbORMType.Name = "cmbORMType";
            this.cmbORMType.Size = new System.Drawing.Size(121, 21);
            this.cmbORMType.TabIndex = 3;
            // 
            // lblORMType
            // 
            this.lblORMType.AutoSize = true;
            this.lblORMType.Location = new System.Drawing.Point(465, 46);
            this.lblORMType.Name = "lblORMType";
            this.lblORMType.Size = new System.Drawing.Size(32, 13);
            this.lblORMType.TabIndex = 4;
            this.lblORMType.Text = "ORM";
            // 
            // lblMapper
            // 
            this.lblMapper.AutoSize = true;
            this.lblMapper.Location = new System.Drawing.Point(465, 73);
            this.lblMapper.Name = "lblMapper";
            this.lblMapper.Size = new System.Drawing.Size(43, 13);
            this.lblMapper.TabIndex = 6;
            this.lblMapper.Text = "Mapper";
            // 
            // cmbMapper
            // 
            this.cmbMapper.FormattingEnabled = true;
            this.cmbMapper.Location = new System.Drawing.Point(515, 70);
            this.cmbMapper.Name = "cmbMapper";
            this.cmbMapper.Size = new System.Drawing.Size(121, 21);
            this.cmbMapper.TabIndex = 5;
            // 
            // lblIOC
            // 
            this.lblIOC.AutoSize = true;
            this.lblIOC.Location = new System.Drawing.Point(465, 100);
            this.lblIOC.Name = "lblIOC";
            this.lblIOC.Size = new System.Drawing.Size(25, 13);
            this.lblIOC.TabIndex = 8;
            this.lblIOC.Text = "IOC";
            // 
            // cmbIOC
            // 
            this.cmbIOC.FormattingEnabled = true;
            this.cmbIOC.Location = new System.Drawing.Point(515, 97);
            this.cmbIOC.Name = "cmbIOC";
            this.cmbIOC.Size = new System.Drawing.Size(121, 21);
            this.cmbIOC.TabIndex = 7;
            // 
            // lblFrameworkType
            // 
            this.lblFrameworkType.AutoSize = true;
            this.lblFrameworkType.Location = new System.Drawing.Point(205, 46);
            this.lblFrameworkType.Name = "lblFrameworkType";
            this.lblFrameworkType.Size = new System.Drawing.Size(86, 13);
            this.lblFrameworkType.TabIndex = 10;
            this.lblFrameworkType.Text = "Framework Type";
            // 
            // cmbFrameworkType
            // 
            this.cmbFrameworkType.FormattingEnabled = true;
            this.cmbFrameworkType.Location = new System.Drawing.Point(307, 43);
            this.cmbFrameworkType.Name = "cmbFrameworkType";
            this.cmbFrameworkType.Size = new System.Drawing.Size(152, 21);
            this.cmbFrameworkType.TabIndex = 9;
            // 
            // lblArchitecture
            // 
            this.lblArchitecture.AutoSize = true;
            this.lblArchitecture.Location = new System.Drawing.Point(205, 15);
            this.lblArchitecture.Name = "lblArchitecture";
            this.lblArchitecture.Size = new System.Drawing.Size(64, 13);
            this.lblArchitecture.TabIndex = 11;
            this.lblArchitecture.Text = "Architecture";
            // 
            // lblTools
            // 
            this.lblTools.AutoSize = true;
            this.lblTools.Location = new System.Drawing.Point(465, 15);
            this.lblTools.Name = "lblTools";
            this.lblTools.Size = new System.Drawing.Size(33, 13);
            this.lblTools.TabIndex = 12;
            this.lblTools.Text = "Tools";
            // 
            // blArcihtecureDesign
            // 
            this.blArcihtecureDesign.AutoSize = true;
            this.blArcihtecureDesign.Location = new System.Drawing.Point(205, 73);
            this.blArcihtecureDesign.Name = "blArcihtecureDesign";
            this.blArcihtecureDesign.Size = new System.Drawing.Size(91, 13);
            this.blArcihtecureDesign.TabIndex = 14;
            this.blArcihtecureDesign.Text = "ArcitectureDesign";
            // 
            // cmbArchitectureDesign
            // 
            this.cmbArchitectureDesign.FormattingEnabled = true;
            this.cmbArchitectureDesign.Location = new System.Drawing.Point(307, 70);
            this.cmbArchitectureDesign.Name = "cmbArchitectureDesign";
            this.cmbArchitectureDesign.Size = new System.Drawing.Size(152, 21);
            this.cmbArchitectureDesign.TabIndex = 13;
            // 
            // grpProjectInfo
            // 
            this.grpProjectInfo.Location = new System.Drawing.Point(12, 12);
            this.grpProjectInfo.Name = "grpProjectInfo";
            this.grpProjectInfo.Size = new System.Drawing.Size(187, 340);
            this.grpProjectInfo.TabIndex = 15;
            this.grpProjectInfo.TabStop = false;
            this.grpProjectInfo.Text = "Project Information";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOpenFolder.Location = new System.Drawing.Point(553, 423);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(82, 21);
            this.btnOpenFolder.TabIndex = 35;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(553, 398);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(82, 23);
            this.btnClearLog.TabIndex = 34;
            this.btnClearLog.Text = "Clear";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(553, 373);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(82, 23);
            this.btnClick.TabIndex = 33;
            this.btnClick.Text = "Please Click!";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // btnCloseLog
            // 
            this.btnCloseLog.Location = new System.Drawing.Point(553, 446);
            this.btnCloseLog.Name = "btnCloseLog";
            this.btnCloseLog.Size = new System.Drawing.Size(82, 23);
            this.btnCloseLog.TabIndex = 32;
            this.btnCloseLog.Text = "Close Output";
            this.btnCloseLog.UseVisualStyleBackColor = true;
            this.btnCloseLog.Click += new System.EventHandler(this.btnCloseLog_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLog.Location = new System.Drawing.Point(12, 373);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(535, 96);
            this.txtLog.TabIndex = 31;
            // 
            // listProjectName
            // 
            this.listProjectName.FormattingEnabled = true;
            this.listProjectName.HorizontalScrollbar = true;
            this.listProjectName.Location = new System.Drawing.Point(208, 142);
            this.listProjectName.Name = "listProjectName";
            this.listProjectName.Size = new System.Drawing.Size(427, 147);
            this.listProjectName.TabIndex = 36;
            this.listProjectName.DoubleClick += new System.EventHandler(this.listProjectName_DoubleClick);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(209, 307);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(200, 45);
            this.btnContinue.TabIndex = 37;
            this.btnContinue.Text = "Continue To The Next Stage";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(336, 113);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(123, 23);
            this.btnAddProject.TabIndex = 38;
            this.btnAddProject.Text = "Add Project";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // FrmArchitecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 481);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.listProjectName);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.btnCloseLog);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.grpProjectInfo);
            this.Controls.Add(this.blArcihtecureDesign);
            this.Controls.Add(this.cmbArchitectureDesign);
            this.Controls.Add(this.lblTools);
            this.Controls.Add(this.lblArchitecture);
            this.Controls.Add(this.lblFrameworkType);
            this.Controls.Add(this.cmbFrameworkType);
            this.Controls.Add(this.lblIOC);
            this.Controls.Add(this.cmbIOC);
            this.Controls.Add(this.lblMapper);
            this.Controls.Add(this.cmbMapper);
            this.Controls.Add(this.lblORMType);
            this.Controls.Add(this.cmbORMType);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtProjectName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmArchitecture";
            this.Text = "OYASAR Code Generator Application";
            this.Load += new System.EventHandler(this.FrmArchitecture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.ComboBox cmbORMType;
        private System.Windows.Forms.Label lblORMType;
        private System.Windows.Forms.Label lblMapper;
        private System.Windows.Forms.ComboBox cmbMapper;
        private System.Windows.Forms.Label lblIOC;
        private System.Windows.Forms.ComboBox cmbIOC;
        private System.Windows.Forms.Label lblFrameworkType;
        private System.Windows.Forms.ComboBox cmbFrameworkType;
        private System.Windows.Forms.Label lblArchitecture;
        private System.Windows.Forms.Label lblTools;
        private System.Windows.Forms.Label blArcihtecureDesign;
        private System.Windows.Forms.ComboBox cmbArchitectureDesign;
        private System.Windows.Forms.GroupBox grpProjectInfo;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnCloseLog;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ListBox listProjectName;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnAddProject;
    }
}