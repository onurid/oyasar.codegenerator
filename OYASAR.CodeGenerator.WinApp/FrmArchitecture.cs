using OYASAR.CodeGenerator.Lib.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static OYASAR.CodeGenerator.Lib.Core.ArchitectureService;

namespace OYASAR.CodeGenerator.WinApp
{
    public partial class FrmArchitecture : Form
    {
        private TextWriter _writer = null;

        private readonly IList<ArchitectureParamDto> architectureParamDto; 

        public FrmArchitecture()
        {
            InitializeComponent();

            architectureParamDto = new List<ArchitectureParamDto>();

            this.Height = 405;

            _writer = new TextBoxStreamWriter(txtLog);
            Console.SetOut(_writer);

            Console.WriteLine("Starting Generate..");
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (architectureParamDto.Count == 0)
            {
                MessageBox.Show("Project list is empty!");
                return;
            }

            this.Height = 520;

            var manager = new GenerateManager();

            manager.ExportProjectScript(architectureParamDto);
           
            Console.WriteLine("Generated Successfull!");
        }

        private void FrmArchitecture_Load(object sender, EventArgs e)
        {
            cmbIOC.DataSource = IOCTypeDic.Keys.ToList();
            cmbORMType.DataSource = ORMTypeDic.Keys.ToList();
            cmbMapper.DataSource = MapperTypeDic.Keys.ToList();
            cmbFrameworkType.DataSource = FrameworkTypeDic.Keys.ToList();
            cmbArchitectureDesign.DataSource = ArchitectureDesignDic.Keys.ToList();
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtLog.Text = string.Empty;
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start(Environment.CurrentDirectory);
        }

        private void btnCloseLog_Click(object sender, EventArgs e)
        {
            this.Height = 405;
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            var aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            var projectName = txtProjectName.Text.Trim();

            if (string.IsNullOrEmpty(projectName))
            {
                MessageBox.Show("Projectname is empty!");
                return;
            }

            var data = new ArchitectureParamDto
            {
                ProjectName = projectName,
                IOCType = cmbIOC.SelectedValue.ToString(),
                ORMType = cmbORMType.SelectedValue.ToString(),
                MapperType = cmbMapper.SelectedValue.ToString(),
                FrameworkType = cmbFrameworkType.SelectedValue.ToString(), 
                ArchitectureDesign = cmbArchitectureDesign.SelectedValue.ToString(),
            };

            architectureParamDto.Add(data);

            listProjectName.Items.Add(data.ToStringForList());

            txtProjectName.Text = string.Empty;
        }

        private void listProjectName_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (listProjectName.SelectedIndex != -1)
                    listProjectName.Items.RemoveAt(listProjectName.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtProjectName_Enter(object sender, EventArgs e)
        {
            btnAddProject_Click(sender, e);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

        }
    }
}
