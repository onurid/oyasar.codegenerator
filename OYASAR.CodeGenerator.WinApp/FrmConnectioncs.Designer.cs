namespace OYASAR.CodeGenerator.WinApp
{
    partial class FrmConnectioncs
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblAddr = new System.Windows.Forms.Label();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.txtUsrname = new System.Windows.Forms.TextBox();
            this.lblUsrname = new System.Windows.Forms.Label();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.lblPasswd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(148, 103);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(124, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(12, 103);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Location = new System.Drawing.Point(9, 9);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(102, 13);
            this.lblAddr.TabIndex = 2;
            this.lblAddr.Text = "Connection Address";
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(12, 25);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(260, 20);
            this.txtAddr.TabIndex = 3;
            this.txtAddr.Text = "hbsql01.ipnordic.dk";
            this.txtAddr.TextChanged += new System.EventHandler(this.txtAddr_TextChanged);
            // 
            // txtUsrname
            // 
            this.txtUsrname.Location = new System.Drawing.Point(12, 64);
            this.txtUsrname.Name = "txtUsrname";
            this.txtUsrname.Size = new System.Drawing.Size(130, 20);
            this.txtUsrname.TabIndex = 5;
            this.txtUsrname.Text = "service.HotelBoss";
            this.txtUsrname.TextChanged += new System.EventHandler(this.txtUsrname_TextChanged);
            // 
            // lblUsrname
            // 
            this.lblUsrname.AutoSize = true;
            this.lblUsrname.Location = new System.Drawing.Point(9, 48);
            this.lblUsrname.Name = "lblUsrname";
            this.lblUsrname.Size = new System.Drawing.Size(55, 13);
            this.lblUsrname.TabIndex = 4;
            this.lblUsrname.Text = "Username";
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(148, 64);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '*';
            this.txtPasswd.Size = new System.Drawing.Size(124, 20);
            this.txtPasswd.TabIndex = 7;
            this.txtPasswd.Text = "r75515ybade431d536k0490Dv95wEQ";
            this.txtPasswd.TextChanged += new System.EventHandler(this.txtPasswd_TextChanged);
            // 
            // lblPasswd
            // 
            this.lblPasswd.AutoSize = true;
            this.lblPasswd.Location = new System.Drawing.Point(145, 48);
            this.lblPasswd.Name = "lblPasswd";
            this.lblPasswd.Size = new System.Drawing.Size(53, 13);
            this.lblPasswd.TabIndex = 6;
            this.lblPasswd.Text = "Password";
            // 
            // FrmConnectioncs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 144);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.lblPasswd);
            this.Controls.Add(this.txtUsrname);
            this.Controls.Add(this.lblUsrname);
            this.Controls.Add(this.txtAddr);
            this.Controls.Add(this.lblAddr);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmConnectioncs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OYASAR Code Generator Connection Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.TextBox txtUsrname;
        private System.Windows.Forms.Label lblUsrname;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Label lblPasswd;
    }
}