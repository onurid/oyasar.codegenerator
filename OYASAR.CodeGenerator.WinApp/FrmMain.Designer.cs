namespace OYASAR.CodeGenerator.WinApp
{
    partial class FrmMain
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
            this.listTable = new System.Windows.Forms.ListBox();
            this.chckDAModel = new System.Windows.Forms.CheckBox();
            this.chckDAConf = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.chckRepositoryImpl = new System.Windows.Forms.CheckBox();
            this.chckRepositoryInterface = new System.Windows.Forms.CheckBox();
            this.chckServiceImpl = new System.Windows.Forms.CheckBox();
            this.chckServiceInterface = new System.Windows.Forms.CheckBox();
            this.ListSelected = new System.Windows.Forms.ListBox();
            this.lblPointer = new System.Windows.Forms.Label();
            this.lblChoose = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.chckAllChoose = new System.Windows.Forms.CheckBox();
            this.chckBOModel = new System.Windows.Forms.CheckBox();
            this.chckTableSchema = new System.Windows.Forms.CheckBox();
            this.btnNotTransferAll = new System.Windows.Forms.Button();
            this.btnTransferAll = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnCloseLog = new System.Windows.Forms.Button();
            this.btnClick = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.lblDataBase = new System.Windows.Forms.Label();
            this.gropBoxInfo = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.chckSchemaBool = new System.Windows.Forms.CheckBox();
            this.gropBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // listTable
            // 
            this.listTable.FormattingEnabled = true;
            this.listTable.Location = new System.Drawing.Point(12, 76);
            this.listTable.Name = "listTable";
            this.listTable.Size = new System.Drawing.Size(167, 251);
            this.listTable.TabIndex = 0;
            this.listTable.DoubleClick += new System.EventHandler(this.listTable_DoubleClick);
            // 
            // chckDAModel
            // 
            this.chckDAModel.AutoSize = true;
            this.chckDAModel.Location = new System.Drawing.Point(405, 76);
            this.chckDAModel.Name = "chckDAModel";
            this.chckDAModel.Size = new System.Drawing.Size(148, 17);
            this.chckDAModel.TabIndex = 1;
            this.chckDAModel.Text = "Data Access Layer Model";
            this.chckDAModel.UseVisualStyleBackColor = true;
            // 
            // chckDAConf
            // 
            this.chckDAConf.AutoSize = true;
            this.chckDAConf.Location = new System.Drawing.Point(405, 99);
            this.chckDAConf.Name = "chckDAConf";
            this.chckDAConf.Size = new System.Drawing.Size(181, 17);
            this.chckDAConf.TabIndex = 2;
            this.chckDAConf.Text = "Data Access Layer Configuration";
            this.chckDAConf.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(405, 283);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(230, 44);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(66, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(113, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(9, 50);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search";
            // 
            // chckRepositoryImpl
            // 
            this.chckRepositoryImpl.AutoSize = true;
            this.chckRepositoryImpl.Location = new System.Drawing.Point(405, 122);
            this.chckRepositoryImpl.Name = "chckRepositoryImpl";
            this.chckRepositoryImpl.Size = new System.Drawing.Size(150, 17);
            this.chckRepositoryImpl.TabIndex = 6;
            this.chckRepositoryImpl.Text = "Repository Implementation";
            this.chckRepositoryImpl.UseVisualStyleBackColor = true;
            // 
            // chckRepositoryInterface
            // 
            this.chckRepositoryInterface.AutoSize = true;
            this.chckRepositoryInterface.Location = new System.Drawing.Point(405, 145);
            this.chckRepositoryInterface.Name = "chckRepositoryInterface";
            this.chckRepositoryInterface.Size = new System.Drawing.Size(121, 17);
            this.chckRepositoryInterface.TabIndex = 7;
            this.chckRepositoryInterface.Text = "Repository Interface";
            this.chckRepositoryInterface.UseVisualStyleBackColor = true;
            // 
            // chckServiceImpl
            // 
            this.chckServiceImpl.AutoSize = true;
            this.chckServiceImpl.Location = new System.Drawing.Point(405, 168);
            this.chckServiceImpl.Name = "chckServiceImpl";
            this.chckServiceImpl.Size = new System.Drawing.Size(136, 17);
            this.chckServiceImpl.TabIndex = 8;
            this.chckServiceImpl.Text = "Service Implementation";
            this.chckServiceImpl.UseVisualStyleBackColor = true;
            // 
            // chckServiceInterface
            // 
            this.chckServiceInterface.AutoSize = true;
            this.chckServiceInterface.Location = new System.Drawing.Point(405, 191);
            this.chckServiceInterface.Name = "chckServiceInterface";
            this.chckServiceInterface.Size = new System.Drawing.Size(107, 17);
            this.chckServiceInterface.TabIndex = 9;
            this.chckServiceInterface.Text = "Service Interface";
            this.chckServiceInterface.UseVisualStyleBackColor = true;
            // 
            // ListSelected
            // 
            this.ListSelected.FormattingEnabled = true;
            this.ListSelected.Location = new System.Drawing.Point(207, 76);
            this.ListSelected.Name = "ListSelected";
            this.ListSelected.Size = new System.Drawing.Size(175, 251);
            this.ListSelected.TabIndex = 10;
            this.ListSelected.DoubleClick += new System.EventHandler(this.ListSelected_DoubleClick);
            // 
            // lblPointer
            // 
            this.lblPointer.AutoSize = true;
            this.lblPointer.Location = new System.Drawing.Point(185, 181);
            this.lblPointer.Name = "lblPointer";
            this.lblPointer.Size = new System.Drawing.Size(16, 13);
            this.lblPointer.TabIndex = 11;
            this.lblPointer.Text = "->";
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Location = new System.Drawing.Point(402, 47);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(43, 13);
            this.lblChoose.TabIndex = 12;
            this.lblChoose.Text = "Choose";
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(204, 47);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(80, 13);
            this.lblSelected.TabIndex = 13;
            this.lblSelected.Text = "Those selected";
            // 
            // chckAllChoose
            // 
            this.chckAllChoose.AutoSize = true;
            this.chckAllChoose.Location = new System.Drawing.Point(451, 46);
            this.chckAllChoose.Name = "chckAllChoose";
            this.chckAllChoose.Size = new System.Drawing.Size(70, 17);
            this.chckAllChoose.TabIndex = 14;
            this.chckAllChoose.Text = "Select All";
            this.chckAllChoose.UseVisualStyleBackColor = true;
            this.chckAllChoose.CheckedChanged += new System.EventHandler(this.chckAllChoose_CheckedChanged);
            // 
            // chckBOModel
            // 
            this.chckBOModel.AutoSize = true;
            this.chckBOModel.Location = new System.Drawing.Point(405, 214);
            this.chckBOModel.Name = "chckBOModel";
            this.chckBOModel.Size = new System.Drawing.Size(134, 17);
            this.chckBOModel.TabIndex = 15;
            this.chckBOModel.Text = "Business Object Model";
            this.chckBOModel.UseVisualStyleBackColor = true;
            // 
            // chckTableSchema
            // 
            this.chckTableSchema.AutoSize = true;
            this.chckTableSchema.Location = new System.Drawing.Point(405, 237);
            this.chckTableSchema.Name = "chckTableSchema";
            this.chckTableSchema.Size = new System.Drawing.Size(95, 17);
            this.chckTableSchema.TabIndex = 16;
            this.chckTableSchema.Text = "Table Schema";
            this.chckTableSchema.UseVisualStyleBackColor = true;
            // 
            // btnNotTransferAll
            // 
            this.btnNotTransferAll.Location = new System.Drawing.Point(185, 197);
            this.btnNotTransferAll.Name = "btnNotTransferAll";
            this.btnNotTransferAll.Size = new System.Drawing.Size(16, 130);
            this.btnNotTransferAll.TabIndex = 17;
            this.btnNotTransferAll.Text = "-N-ALL-";
            this.btnNotTransferAll.UseVisualStyleBackColor = true;
            this.btnNotTransferAll.Click += new System.EventHandler(this.btnNotTransferAll_Click);
            // 
            // btnTransferAll
            // 
            this.btnTransferAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTransferAll.Location = new System.Drawing.Point(185, 76);
            this.btnTransferAll.Name = "btnTransferAll";
            this.btnTransferAll.Size = new System.Drawing.Size(16, 104);
            this.btnTransferAll.TabIndex = 18;
            this.btnTransferAll.Text = "+ALL+";
            this.btnTransferAll.UseVisualStyleBackColor = true;
            this.btnTransferAll.Click += new System.EventHandler(this.btnTransferAll_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLog.Location = new System.Drawing.Point(12, 356);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(535, 96);
            this.txtLog.TabIndex = 20;
            // 
            // btnCloseLog
            // 
            this.btnCloseLog.Location = new System.Drawing.Point(553, 429);
            this.btnCloseLog.Name = "btnCloseLog";
            this.btnCloseLog.Size = new System.Drawing.Size(82, 23);
            this.btnCloseLog.TabIndex = 21;
            this.btnCloseLog.Text = "Close Output";
            this.btnCloseLog.UseVisualStyleBackColor = true;
            this.btnCloseLog.Click += new System.EventHandler(this.btnCloseLog_Click);
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(553, 356);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(82, 23);
            this.btnClick.TabIndex = 22;
            this.btnClick.Text = "Please Click!";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(553, 381);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(82, 23);
            this.btnClearLog.TabIndex = 23;
            this.btnClearLog.Text = "Clear";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Location = new System.Drawing.Point(520, 10);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(115, 21);
            this.cmbDatabase.TabIndex = 27;
            this.cmbDatabase.SelectedIndexChanged += new System.EventHandler(this.cmbDatabase_SelectedIndexChanged);
            // 
            // lblDataBase
            // 
            this.lblDataBase.AutoSize = true;
            this.lblDataBase.Location = new System.Drawing.Point(402, 13);
            this.lblDataBase.Name = "lblDataBase";
            this.lblDataBase.Size = new System.Drawing.Size(92, 13);
            this.lblDataBase.TabIndex = 28;
            this.lblDataBase.Text = "Choose Database";
            // 
            // gropBoxInfo
            // 
            this.gropBoxInfo.Controls.Add(this.lblInfo);
            this.gropBoxInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gropBoxInfo.Location = new System.Drawing.Point(12, 10);
            this.gropBoxInfo.Name = "gropBoxInfo";
            this.gropBoxInfo.Size = new System.Drawing.Size(377, 37);
            this.gropBoxInfo.TabIndex = 29;
            this.gropBoxInfo.TabStop = false;
            this.gropBoxInfo.Text = "Connection";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInfo.Location = new System.Drawing.Point(6, 16);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(24, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "info";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOpenFolder.Location = new System.Drawing.Point(553, 406);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(82, 21);
            this.btnOpenFolder.TabIndex = 30;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // chckSchemaBool
            // 
            this.chckSchemaBool.AutoSize = true;
            this.chckSchemaBool.Location = new System.Drawing.Point(499, 237);
            this.chckSchemaBool.Name = "chckSchemaBool";
            this.chckSchemaBool.Size = new System.Drawing.Size(150, 17);
            this.chckSchemaBool.TabIndex = 31;
            this.chckSchemaBool.Text = "Is only one file for Schema";
            this.chckSchemaBool.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 471);
            this.Controls.Add(this.chckSchemaBool);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.gropBoxInfo);
            this.Controls.Add(this.lblDataBase);
            this.Controls.Add(this.cmbDatabase);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.btnCloseLog);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnTransferAll);
            this.Controls.Add(this.btnNotTransferAll);
            this.Controls.Add(this.chckTableSchema);
            this.Controls.Add(this.chckBOModel);
            this.Controls.Add(this.chckAllChoose);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.lblPointer);
            this.Controls.Add(this.ListSelected);
            this.Controls.Add(this.chckServiceInterface);
            this.Controls.Add(this.chckServiceImpl);
            this.Controls.Add(this.chckRepositoryInterface);
            this.Controls.Add(this.chckRepositoryImpl);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.chckDAConf);
            this.Controls.Add(this.chckDAModel);
            this.Controls.Add(this.listTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OYASAR Code Generator Application";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gropBoxInfo.ResumeLayout(false);
            this.gropBoxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listTable;
        private System.Windows.Forms.CheckBox chckDAModel;
        private System.Windows.Forms.CheckBox chckDAConf;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.CheckBox chckRepositoryImpl;
        private System.Windows.Forms.CheckBox chckRepositoryInterface;
        private System.Windows.Forms.CheckBox chckServiceImpl;
        private System.Windows.Forms.CheckBox chckServiceInterface;
        private System.Windows.Forms.ListBox ListSelected;
        private System.Windows.Forms.Label lblPointer;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.CheckBox chckAllChoose;
        private System.Windows.Forms.CheckBox chckBOModel;
        private System.Windows.Forms.CheckBox chckTableSchema;
        private System.Windows.Forms.Button btnNotTransferAll;
        private System.Windows.Forms.Button btnTransferAll;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnCloseLog;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.ComboBox cmbDatabase;
        private System.Windows.Forms.Label lblDataBase;
        private System.Windows.Forms.GroupBox gropBoxInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.CheckBox chckSchemaBool;
    }
}

