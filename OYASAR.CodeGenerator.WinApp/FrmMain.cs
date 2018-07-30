using OYASAR.CodeGenerator.Lib.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OYASAR.CodeGenerator.WinApp
{
    public partial class FrmMain : Form
    {
        private TextWriter _writer = null;
        private GenerateManager manager = null;

        private IList<string> tableData = null;

        private FrmConnectioncs frmConnectioncs;

        public FrmMain()
        {
            InitializeComponent();
            StartFrmConnection();
            _writer = new TextBoxStreamWriter(txtLog);
            Console.SetOut(_writer);

            Console.WriteLine("Starting Generate..");
        }

        private void StartFrmConnection()
        {
            frmConnectioncs = new FrmConnectioncs();

            var result = frmConnectioncs.ShowDialog();

            if (result == DialogResult.Cancel || result == DialogResult.None)
                Environment.Exit(1);


            this.Height = 390;
            try
            {
                var databaseList = frmConnectioncs.DatabaseList.ToList();
                manager = new GenerateManager(string.Empty); // trick
                cmbDatabase.DataSource = databaseList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception Handle: {ex.Message}");
                StartFrmConnection();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            listTable.DataSource = tableData;
            UpdateInfoBox();
        }

        private void UpdateInfoBox()
        {
            lblInfo.Text = $"[Addr: {frmConnectioncs.dbConfig.Address}] [Usr: {frmConnectioncs.dbConfig.Username}]" +
                $" [Db: {cmbDatabase.Text}]";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (CheckValidGenerate())
            {
                this.Height = 510;
                GenerateProcess();
            }
        }

        private bool CheckValidGenerate()
        {
            if (ListSelected.Items.Count == 0)
            {
                MessageBox.Show("Please, select one or more table!");
                return false;
            }

            if (!(chckDAModel.Checked || chckDAConf.Checked ||
                chckBOModel.Checked || chckRepositoryImpl.Checked ||
                chckRepositoryInterface.Checked || chckServiceImpl.Checked ||
                chckServiceInterface.Checked || chckTableSchema.Checked))
            {
                MessageBox.Show("Please, select one or more checkbox!");
                return false;
            }
            return true;
        }

        private void GenerateProcess()
        {
            Console.WriteLine("Started Generate..");


            var list = ListSelected.Items.OfType<string>().ToArray();

            var param = new ExportParamDto
            {
                DataAccessModel = chckDAModel.Checked,
                DataAccessConf = chckDAConf.Checked,
                BusinessObject = chckBOModel.Checked,
                RepositoryImplementation = chckRepositoryImpl.Checked,
                RepositoryInterface = chckRepositoryInterface.Checked,
                ServiceImplementation = chckServiceImpl.Checked,
                ServiceInterface = chckServiceInterface.Checked,
                TableSchema = chckTableSchema.Checked,
                TableSchemaIsOnlyFile = chckSchemaBool.Checked,
                TableNames = list
            };

            //try
            //{
                var result = manager.ExportCodeDom(param);
                if (result)
                {
                    Console.WriteLine("Finish Generate!");
                    MessageBox.Show("Finish Generate Successfully!");
                }
                else
                {
                    Console.WriteLine("Handle Exception..! Generate Unsuccessfully!");
                    MessageBox.Show("Handle Exception..!  Generate Unsuccessfully!");
                }
            //}
            //catch (Exception ex)
            //{
            //   Console.WriteLine(ex.Message);
            //   MessageBox.Show(ex.Message);
            //}
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
                listTable.DataSource = tableData;
            else
            {
                var keyword = txtSearch.Text.Trim().ToLower();
                var tempData = tableData.Where(x => x.ToLower().Contains(keyword));
                listTable.DataSource = tempData.ToList();
            }
        }

        private void listTable_DoubleClick(object sender, EventArgs e)
        {
            var selected = listTable.SelectedItem;

            if (ListSelected.Items.Contains(selected))
                MessageBox.Show("It has already!");
            else
                ListSelected.Items.Add(listTable.SelectedItem);
        }

        private void ListSelected_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (ListSelected.SelectedIndex != -1)
                    ListSelected.Items.RemoveAt(ListSelected.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chckAllChoose_CheckedChanged(object sender, EventArgs e)
        {
            if (chckAllChoose.Checked)
            {
                chckDAModel.Checked = true;
                chckDAConf.Checked = true;
                chckRepositoryImpl.Checked = true;
                chckRepositoryInterface.Checked = true;
                chckServiceImpl.Checked = true;
                chckServiceInterface.Checked = true;
                chckBOModel.Checked = true;
                chckTableSchema.Checked = true;
            }
            else
            {
                chckDAModel.Checked = false;
                chckDAConf.Checked = false;
                chckRepositoryImpl.Checked = false;
                chckRepositoryInterface.Checked = false;
                chckServiceImpl.Checked = false;
                chckServiceInterface.Checked = false;
                chckBOModel.Checked = false;
                chckTableSchema.Checked = false;
            }
        }

        private void btnTransferAll_Click(object sender, EventArgs e)
        {
            ListSelected.DataSource = listTable.DataSource;
        }

        private void btnNotTransferAll_Click(object sender, EventArgs e)
        {
            ListSelected.DataSource = null;
        }

        private void btnCloseLog_Click(object sender, EventArgs e)
        {
            this.Height = 390;
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            var aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtLog.Text = string.Empty;
        }

        private void cmbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            var database = cmbDatabase.SelectedValue.ToString().Trim();

            if (string.IsNullOrEmpty(database))
            {
                MessageBox.Show("Database invalid!");
                return;
            }
            manager.SetDatabase(database);
            try
            {
                tableData = manager.GetAllTable().ToList();
                listTable.DataSource = tableData;
                ListSelected.DataSource = null;
                ListSelected.Items.Clear();
                UpdateInfoBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception Handle: {ex.Message}");
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start(Environment.CurrentDirectory);
        }
    }
}
