using OYASAR.CodeGenerator.Lib.Core;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OYASAR.CodeGenerator.WinApp
{
    public partial class FrmConnectioncs : Form
    {
        internal IEnumerable<string> DatabaseList { get; set; }

        internal DbConfigDto dbConfig { get; set; }

        public FrmConnectioncs()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var addr = txtAddr.Text.Trim();

            var usrname = txtUsrname.Text.Trim();

            var pass = txtPasswd.Text.Trim();

            dbConfig = new DbConfigDto
            {
                Address = addr,
                Username = usrname,
                Password = pass
            };

            DatabaseList = GenerateManager.GetAllDatabase(dbConfig);
        }

        private void txtAddr_TextChanged(object sender, EventArgs e)
        {
            ValidateText();
        }

        private void txtUsrname_TextChanged(object sender, EventArgs e)
        {
            ValidateText();
        }

        private void txtPasswd_TextChanged(object sender, EventArgs e)
        {
            ValidateText();
        }

        private void ValidateText()
        {
            if (string.IsNullOrEmpty(txtAddr.Text) || string.IsNullOrEmpty(txtUsrname.Text) || string.IsNullOrEmpty(txtPasswd.Text))
                btnOk.Enabled = false;
            else
                btnOk.Enabled = true;
        }
    }
}
