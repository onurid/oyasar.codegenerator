namespace OYASAR.CodeGenerator.WinApp
{
    partial class FrmProjectDesign
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
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("OYASAR.Camel.Core");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("OYASAR.Camel.Business", new System.Windows.Forms.TreeNode[] {
            treeNode49});
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("OYASAR.Camel.Core");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("OYASAR.Camel.Core.Repository", new System.Windows.Forms.TreeNode[] {
            treeNode51});
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("OYASAR.Camel.Repository", new System.Windows.Forms.TreeNode[] {
            treeNode52});
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("OYASAR.Camel.Core");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("OYASAR.Camel.Core.Repository", new System.Windows.Forms.TreeNode[] {
            treeNode54});
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("OYASAR.Camel.Repository.Data", new System.Windows.Forms.TreeNode[] {
            treeNode55});
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("OYASAR.Camel.Core");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("OYASAR.Camel.Api", new System.Windows.Forms.TreeNode[] {
            treeNode50,
            treeNode53,
            treeNode56,
            treeNode57});
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("OYASAR.Camel", new System.Windows.Forms.TreeNode[] {
            treeNode58});
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("OYASAR.Penguin.Core");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("OYASAR.Penguin.Repository", new System.Windows.Forms.TreeNode[] {
            treeNode60});
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("OYASAR.Penguin.Business", new System.Windows.Forms.TreeNode[] {
            treeNode61});
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("OYASAR.Penguin.Api", new System.Windows.Forms.TreeNode[] {
            treeNode62});
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("OYASAR.Penguin", new System.Windows.Forms.TreeNode[] {
            treeNode63});
            this.grpBoxProjectArchitecture = new System.Windows.Forms.GroupBox();
            this.btnImportProjects = new System.Windows.Forms.Button();
            this.btnExportProjects = new System.Windows.Forms.Button();
            this.btnRemoveProject = new System.Windows.Forms.Button();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.grpBoxTools = new System.Windows.Forms.GroupBox();
            this.cmbORM = new System.Windows.Forms.ComboBox();
            this.lblORM = new System.Windows.Forms.Label();
            this.cmbMapper = new System.Windows.Forms.ComboBox();
            this.lblMapper = new System.Windows.Forms.Label();
            this.cmbIOC = new System.Windows.Forms.ComboBox();
            this.lblIOC = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.grpBoxCore = new System.Windows.Forms.GroupBox();
            this.chckCore = new System.Windows.Forms.CheckBox();
            this.grpBoxInfrastructre = new System.Windows.Forms.GroupBox();
            this.chckRepositoryData = new System.Windows.Forms.CheckBox();
            this.chckCoreRepository = new System.Windows.Forms.CheckBox();
            this.chckRepository = new System.Windows.Forms.CheckBox();
            this.grpBoxApplication = new System.Windows.Forms.GroupBox();
            this.chckBusiness = new System.Windows.Forms.CheckBox();
            this.chckMvc = new System.Windows.Forms.CheckBox();
            this.chckApi = new System.Windows.Forms.CheckBox();
            this.trviewProjectList = new System.Windows.Forms.TreeView();
            this.cmbDependencyArhitecture = new System.Windows.Forms.ComboBox();
            this.lblDependencyArchitecture = new System.Windows.Forms.Label();
            this.grpBoxProjectArchitecture.SuspendLayout();
            this.grpBoxTools.SuspendLayout();
            this.grpBoxCore.SuspendLayout();
            this.grpBoxInfrastructre.SuspendLayout();
            this.grpBoxApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxProjectArchitecture
            // 
            this.grpBoxProjectArchitecture.Controls.Add(this.btnImportProjects);
            this.grpBoxProjectArchitecture.Controls.Add(this.btnExportProjects);
            this.grpBoxProjectArchitecture.Controls.Add(this.btnRemoveProject);
            this.grpBoxProjectArchitecture.Controls.Add(this.btnAddProject);
            this.grpBoxProjectArchitecture.Controls.Add(this.grpBoxTools);
            this.grpBoxProjectArchitecture.Controls.Add(this.lblProjectName);
            this.grpBoxProjectArchitecture.Controls.Add(this.txtProjectName);
            this.grpBoxProjectArchitecture.Controls.Add(this.grpBoxCore);
            this.grpBoxProjectArchitecture.Controls.Add(this.grpBoxInfrastructre);
            this.grpBoxProjectArchitecture.Controls.Add(this.grpBoxApplication);
            this.grpBoxProjectArchitecture.Controls.Add(this.trviewProjectList);
            this.grpBoxProjectArchitecture.Controls.Add(this.cmbDependencyArhitecture);
            this.grpBoxProjectArchitecture.Controls.Add(this.lblDependencyArchitecture);
            this.grpBoxProjectArchitecture.Location = new System.Drawing.Point(12, 12);
            this.grpBoxProjectArchitecture.Name = "grpBoxProjectArchitecture";
            this.grpBoxProjectArchitecture.Size = new System.Drawing.Size(580, 294);
            this.grpBoxProjectArchitecture.TabIndex = 2;
            this.grpBoxProjectArchitecture.TabStop = false;
            // 
            // btnImportProjects
            // 
            this.btnImportProjects.Location = new System.Drawing.Point(426, 19);
            this.btnImportProjects.Name = "btnImportProjects";
            this.btnImportProjects.Size = new System.Drawing.Size(71, 76);
            this.btnImportProjects.TabIndex = 14;
            this.btnImportProjects.Text = "Import Projects";
            this.btnImportProjects.UseVisualStyleBackColor = true;
            // 
            // btnExportProjects
            // 
            this.btnExportProjects.Location = new System.Drawing.Point(499, 19);
            this.btnExportProjects.Name = "btnExportProjects";
            this.btnExportProjects.Size = new System.Drawing.Size(71, 76);
            this.btnExportProjects.TabIndex = 13;
            this.btnExportProjects.Text = "Export Projects";
            this.btnExportProjects.UseVisualStyleBackColor = true;
            // 
            // btnRemoveProject
            // 
            this.btnRemoveProject.Location = new System.Drawing.Point(310, 60);
            this.btnRemoveProject.Name = "btnRemoveProject";
            this.btnRemoveProject.Size = new System.Drawing.Size(110, 36);
            this.btnRemoveProject.TabIndex = 12;
            this.btnRemoveProject.Text = "Remove Project";
            this.btnRemoveProject.UseVisualStyleBackColor = true;
            this.btnRemoveProject.Click += new System.EventHandler(this.btnRemoveProject_Click);
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(310, 19);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(110, 36);
            this.btnAddProject.TabIndex = 11;
            this.btnAddProject.Text = "Add Project";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // grpBoxTools
            // 
            this.grpBoxTools.Controls.Add(this.cmbORM);
            this.grpBoxTools.Controls.Add(this.lblORM);
            this.grpBoxTools.Controls.Add(this.cmbMapper);
            this.grpBoxTools.Controls.Add(this.lblMapper);
            this.grpBoxTools.Controls.Add(this.cmbIOC);
            this.grpBoxTools.Controls.Add(this.lblIOC);
            this.grpBoxTools.Location = new System.Drawing.Point(164, 101);
            this.grpBoxTools.Name = "grpBoxTools";
            this.grpBoxTools.Size = new System.Drawing.Size(140, 181);
            this.grpBoxTools.TabIndex = 10;
            this.grpBoxTools.TabStop = false;
            this.grpBoxTools.Text = "Tools";
            // 
            // cmbORM
            // 
            this.cmbORM.FormattingEnabled = true;
            this.cmbORM.Items.AddRange(new object[] {
            "Entity Framework",
            "NHibernate",
            "Dapper"});
            this.cmbORM.Location = new System.Drawing.Point(9, 144);
            this.cmbORM.Name = "cmbORM";
            this.cmbORM.Size = new System.Drawing.Size(121, 21);
            this.cmbORM.TabIndex = 15;
            // 
            // lblORM
            // 
            this.lblORM.AutoSize = true;
            this.lblORM.Location = new System.Drawing.Point(6, 128);
            this.lblORM.Name = "lblORM";
            this.lblORM.Size = new System.Drawing.Size(129, 13);
            this.lblORM.TabIndex = 14;
            this.lblORM.Text = "Object Relations Mapping";
            // 
            // cmbMapper
            // 
            this.cmbMapper.FormattingEnabled = true;
            this.cmbMapper.Items.AddRange(new object[] {
            "Express Mapper",
            "Auto Mapper"});
            this.cmbMapper.Location = new System.Drawing.Point(9, 97);
            this.cmbMapper.Name = "cmbMapper";
            this.cmbMapper.Size = new System.Drawing.Size(121, 21);
            this.cmbMapper.TabIndex = 13;
            // 
            // lblMapper
            // 
            this.lblMapper.AutoSize = true;
            this.lblMapper.Location = new System.Drawing.Point(6, 78);
            this.lblMapper.Name = "lblMapper";
            this.lblMapper.Size = new System.Drawing.Size(126, 13);
            this.lblMapper.TabIndex = 12;
            this.lblMapper.Text = "Mapper Model to Domain";
            // 
            // cmbIOC
            // 
            this.cmbIOC.FormattingEnabled = true;
            this.cmbIOC.Items.AddRange(new object[] {
            "Default .Net Core",
            "Castle Windsor",
            "Light Inject",
            "Dry Ioc"});
            this.cmbIOC.Location = new System.Drawing.Point(9, 47);
            this.cmbIOC.Name = "cmbIOC";
            this.cmbIOC.Size = new System.Drawing.Size(121, 21);
            this.cmbIOC.TabIndex = 11;
            // 
            // lblIOC
            // 
            this.lblIOC.AutoSize = true;
            this.lblIOC.Location = new System.Drawing.Point(6, 28);
            this.lblIOC.Name = "lblIOC";
            this.lblIOC.Size = new System.Drawing.Size(100, 13);
            this.lblIOC.TabIndex = 10;
            this.lblIOC.Text = "Inversion Of Control";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(170, 19);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(71, 13);
            this.lblProjectName.TabIndex = 8;
            this.lblProjectName.Text = "Project Name";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(173, 35);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(121, 20);
            this.txtProjectName.TabIndex = 7;
            // 
            // grpBoxCore
            // 
            this.grpBoxCore.Controls.Add(this.chckCore);
            this.grpBoxCore.Location = new System.Drawing.Point(10, 227);
            this.grpBoxCore.Name = "grpBoxCore";
            this.grpBoxCore.Size = new System.Drawing.Size(139, 55);
            this.grpBoxCore.TabIndex = 6;
            this.grpBoxCore.TabStop = false;
            this.grpBoxCore.Text = "Core";
            // 
            // chckCore
            // 
            this.chckCore.AutoSize = true;
            this.chckCore.Location = new System.Drawing.Point(19, 28);
            this.chckCore.Name = "chckCore";
            this.chckCore.Size = new System.Drawing.Size(48, 17);
            this.chckCore.TabIndex = 0;
            this.chckCore.Text = "Core";
            this.chckCore.UseVisualStyleBackColor = true;
            // 
            // grpBoxInfrastructre
            // 
            this.grpBoxInfrastructre.Controls.Add(this.chckRepositoryData);
            this.grpBoxInfrastructre.Controls.Add(this.chckCoreRepository);
            this.grpBoxInfrastructre.Controls.Add(this.chckRepository);
            this.grpBoxInfrastructre.Location = new System.Drawing.Point(10, 122);
            this.grpBoxInfrastructre.Name = "grpBoxInfrastructre";
            this.grpBoxInfrastructre.Size = new System.Drawing.Size(139, 99);
            this.grpBoxInfrastructre.TabIndex = 5;
            this.grpBoxInfrastructre.TabStop = false;
            this.grpBoxInfrastructre.Text = "Infrastructre";
            // 
            // chckRepositoryData
            // 
            this.chckRepositoryData.AutoSize = true;
            this.chckRepositoryData.Location = new System.Drawing.Point(19, 51);
            this.chckRepositoryData.Name = "chckRepositoryData";
            this.chckRepositoryData.Size = new System.Drawing.Size(102, 17);
            this.chckRepositoryData.TabIndex = 2;
            this.chckRepositoryData.Text = "Repository.Data";
            this.chckRepositoryData.UseVisualStyleBackColor = true;
            this.chckRepositoryData.CheckedChanged += new System.EventHandler(this.chckRepositoryData_CheckedChanged);
            // 
            // chckCoreRepository
            // 
            this.chckCoreRepository.AutoSize = true;
            this.chckCoreRepository.Location = new System.Drawing.Point(19, 74);
            this.chckCoreRepository.Name = "chckCoreRepository";
            this.chckCoreRepository.Size = new System.Drawing.Size(101, 17);
            this.chckCoreRepository.TabIndex = 1;
            this.chckCoreRepository.Text = "Core.Repository";
            this.chckCoreRepository.UseVisualStyleBackColor = true;
            this.chckCoreRepository.CheckedChanged += new System.EventHandler(this.chckCoreRepository_CheckedChanged);
            // 
            // chckRepository
            // 
            this.chckRepository.AutoSize = true;
            this.chckRepository.Location = new System.Drawing.Point(19, 28);
            this.chckRepository.Name = "chckRepository";
            this.chckRepository.Size = new System.Drawing.Size(76, 17);
            this.chckRepository.TabIndex = 0;
            this.chckRepository.Text = "Repository";
            this.chckRepository.UseVisualStyleBackColor = true;
            this.chckRepository.CheckedChanged += new System.EventHandler(this.chckRepository_CheckedChanged);
            // 
            // grpBoxApplication
            // 
            this.grpBoxApplication.Controls.Add(this.chckBusiness);
            this.grpBoxApplication.Controls.Add(this.chckMvc);
            this.grpBoxApplication.Controls.Add(this.chckApi);
            this.grpBoxApplication.Location = new System.Drawing.Point(10, 19);
            this.grpBoxApplication.Name = "grpBoxApplication";
            this.grpBoxApplication.Size = new System.Drawing.Size(139, 97);
            this.grpBoxApplication.TabIndex = 4;
            this.grpBoxApplication.TabStop = false;
            this.grpBoxApplication.Text = "Application";
            // 
            // chckBusiness
            // 
            this.chckBusiness.AutoSize = true;
            this.chckBusiness.Location = new System.Drawing.Point(19, 74);
            this.chckBusiness.Name = "chckBusiness";
            this.chckBusiness.Size = new System.Drawing.Size(68, 17);
            this.chckBusiness.TabIndex = 2;
            this.chckBusiness.Text = "Business";
            this.chckBusiness.UseVisualStyleBackColor = true;
            // 
            // chckMvc
            // 
            this.chckMvc.AutoSize = true;
            this.chckMvc.Location = new System.Drawing.Point(19, 51);
            this.chckMvc.Name = "chckMvc";
            this.chckMvc.Size = new System.Drawing.Size(47, 17);
            this.chckMvc.TabIndex = 1;
            this.chckMvc.Text = "Mvc";
            this.chckMvc.UseVisualStyleBackColor = true;
            // 
            // chckApi
            // 
            this.chckApi.AutoSize = true;
            this.chckApi.Location = new System.Drawing.Point(19, 28);
            this.chckApi.Name = "chckApi";
            this.chckApi.Size = new System.Drawing.Size(41, 17);
            this.chckApi.TabIndex = 0;
            this.chckApi.Text = "Api";
            this.chckApi.UseVisualStyleBackColor = true;
            // 
            // trviewProjectList
            // 
            this.trviewProjectList.Location = new System.Drawing.Point(310, 101);
            this.trviewProjectList.Name = "trviewProjectList";
            treeNode49.Name = "Node14";
            treeNode49.Text = "OYASAR.Camel.Core";
            treeNode50.Name = "Node1";
            treeNode50.Text = "OYASAR.Camel.Business";
            treeNode51.Name = "Node7";
            treeNode51.Text = "OYASAR.Camel.Core";
            treeNode52.Name = "Node5";
            treeNode52.Text = "OYASAR.Camel.Core.Repository";
            treeNode53.Name = "Node2";
            treeNode53.Text = "OYASAR.Camel.Repository";
            treeNode54.Name = "Node8";
            treeNode54.Text = "OYASAR.Camel.Core";
            treeNode55.Name = "Node6";
            treeNode55.Text = "OYASAR.Camel.Core.Repository";
            treeNode56.Name = "Node3";
            treeNode56.Text = "OYASAR.Camel.Repository.Data";
            treeNode57.Name = "Node4";
            treeNode57.Text = "OYASAR.Camel.Core";
            treeNode58.Name = "Node0";
            treeNode58.Text = "OYASAR.Camel.Api";
            treeNode59.Name = "Node1";
            treeNode59.Text = "OYASAR.Camel";
            treeNode60.Name = "Node13";
            treeNode60.Text = "OYASAR.Penguin.Core";
            treeNode61.Name = "Node12";
            treeNode61.Text = "OYASAR.Penguin.Repository";
            treeNode62.Name = "Node10";
            treeNode62.Text = "OYASAR.Penguin.Business";
            treeNode63.Name = "Node9";
            treeNode63.Text = "OYASAR.Penguin.Api";
            treeNode64.Name = "Node2";
            treeNode64.Text = "OYASAR.Penguin";
            this.trviewProjectList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode59,
            treeNode64});
            this.trviewProjectList.ShowNodeToolTips = true;
            this.trviewProjectList.Size = new System.Drawing.Size(260, 181);
            this.trviewProjectList.TabIndex = 3;
            // 
            // cmbDependencyArhitecture
            // 
            this.cmbDependencyArhitecture.FormattingEnabled = true;
            this.cmbDependencyArhitecture.Items.AddRange(new object[] {
            "Union Layer",
            "Traditional Layer"});
            this.cmbDependencyArhitecture.Location = new System.Drawing.Point(173, 74);
            this.cmbDependencyArhitecture.Name = "cmbDependencyArhitecture";
            this.cmbDependencyArhitecture.Size = new System.Drawing.Size(121, 21);
            this.cmbDependencyArhitecture.TabIndex = 3;
            // 
            // lblDependencyArchitecture
            // 
            this.lblDependencyArchitecture.AutoSize = true;
            this.lblDependencyArchitecture.Location = new System.Drawing.Point(170, 58);
            this.lblDependencyArchitecture.Name = "lblDependencyArchitecture";
            this.lblDependencyArchitecture.Size = new System.Drawing.Size(128, 13);
            this.lblDependencyArchitecture.TabIndex = 2;
            this.lblDependencyArchitecture.Text = "Dependency Architecture";
            // 
            // FrmProjectDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 560);
            this.Controls.Add(this.grpBoxProjectArchitecture);
            this.Name = "FrmProjectDesign";
            this.Text = "OYASAR - Projects Arcihtecture Design From";
            this.Load += new System.EventHandler(this.FrmProjectDesign_Load);
            this.grpBoxProjectArchitecture.ResumeLayout(false);
            this.grpBoxProjectArchitecture.PerformLayout();
            this.grpBoxTools.ResumeLayout(false);
            this.grpBoxTools.PerformLayout();
            this.grpBoxCore.ResumeLayout(false);
            this.grpBoxCore.PerformLayout();
            this.grpBoxInfrastructre.ResumeLayout(false);
            this.grpBoxInfrastructre.PerformLayout();
            this.grpBoxApplication.ResumeLayout(false);
            this.grpBoxApplication.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxProjectArchitecture;
        private System.Windows.Forms.ComboBox cmbDependencyArhitecture;
        private System.Windows.Forms.Label lblDependencyArchitecture;
        private System.Windows.Forms.TreeView trviewProjectList;
        private System.Windows.Forms.GroupBox grpBoxApplication;
        private System.Windows.Forms.CheckBox chckMvc;
        private System.Windows.Forms.CheckBox chckApi;
        private System.Windows.Forms.GroupBox grpBoxCore;
        private System.Windows.Forms.CheckBox chckCore;
        private System.Windows.Forms.GroupBox grpBoxInfrastructre;
        private System.Windows.Forms.CheckBox chckRepositoryData;
        private System.Windows.Forms.CheckBox chckCoreRepository;
        private System.Windows.Forms.CheckBox chckRepository;
        private System.Windows.Forms.CheckBox chckBusiness;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.GroupBox grpBoxTools;
        private System.Windows.Forms.Label lblMapper;
        private System.Windows.Forms.ComboBox cmbIOC;
        private System.Windows.Forms.Label lblIOC;
        private System.Windows.Forms.ComboBox cmbMapper;
        private System.Windows.Forms.Label lblORM;
        private System.Windows.Forms.ComboBox cmbORM;
        private System.Windows.Forms.Button btnRemoveProject;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Button btnImportProjects;
        private System.Windows.Forms.Button btnExportProjects;
    }
}