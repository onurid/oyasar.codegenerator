using OYASAR.CodeGenerator.WinApp.NewLogic;
using System;
using System.Windows.Forms;

namespace OYASAR.CodeGenerator.WinApp
{
    public partial class FrmProjectDesign : Form
    {
        private bool infrastructre { get; set; }

        public FrmProjectDesign()
        {
            InitializeComponent();
        }

        private void FrmProjectDesign_Load(object sender, EventArgs e)
        {
            InitgrpBoxProjectArchitecture();
        }

        private void chckRepository_CheckedChanged(object sender, EventArgs e)
        {
            CheckGroupInfrastructre();
        }

        private void chckRepositoryData_CheckedChanged(object sender, EventArgs e)
        {
            CheckGroupInfrastructre();
        }

        private void chckCoreRepository_CheckedChanged(object sender, EventArgs e)
        {
            CheckGroupInfrastructre();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            if (AddProjectToList())
                InitgrpBoxProjectArchitecture();
        }

        private void btnRemoveProject_Click(object sender, EventArgs e)
        {
            RemoveProjectFromList();
        }

        private void RemoveProjectFromList()
        {
            if (trviewProjectList.GetNodeCount(false) > 0)
            {
                var result = MessageBox.Show($"Remove project { trviewProjectList.SelectedNode.Text}?", "Remove", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    trviewProjectList.SelectedNode.Remove();
            }

        }

        private void CheckGroupInfrastructre()
        {
            if (chckRepository.Checked || chckRepositoryData.Checked || chckCoreRepository.Checked)
            {
                grpBoxTools.Enabled = true;
                cmbDependencyArhitecture.Enabled = true;
                lblDependencyArchitecture.Enabled = true;

                infrastructre = true;
            }
            else
            {
                grpBoxTools.Enabled = false;
                cmbDependencyArhitecture.Enabled = false;
                lblDependencyArchitecture.Enabled = false;

                infrastructre = false;
            }
        }

        private void InitgrpBoxProjectArchitecture()
        {
            chckApi.Checked = false;
            chckMvc.Checked = false;
            chckBusiness.Checked = false;
            chckCoreRepository.Checked = false;
            chckRepository.Checked = false;
            chckRepositoryData.Checked = false;
            chckCore.Checked = false;
            txtProjectName.Text = string.Empty;
            cmbDependencyArhitecture.Text = string.Empty;
            cmbIOC.Text = string.Empty;
            cmbMapper.Text = string.Empty;
            cmbORM.Text = string.Empty;

            CheckGroupInfrastructre();
        }

        private bool AddProjectToList()
        {
            var projectName = txtProjectName.Text.Trim();

            if (projectName == string.Empty)
            {
                MessageBox.Show("Project name is empty!", "Valid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            var dto = new ArchitectureParamDto
            {
                ProjectName = projectName,
                Layers = new Layers
                {
                    ApiLayer = chckApi.Checked,
                    MvcLayer = chckMvc.Checked,
                    BusinessLayer = chckBusiness.Checked,
                    RepositoryLayer = infrastructre ? chckRepository.Checked : false,
                    RepositoryDataLayer = infrastructre ? chckRepositoryData.Checked : false,
                    CoreRepositoryLayer = infrastructre ? chckCoreRepository.Checked : false,
                    CoreLayer = chckCore.Checked
                },
                DependencyArchitecture = infrastructre ? cmbDependencyArhitecture.SelectedText : null,
                Tools = infrastructre ? new Tools
                {
                    IOCType = cmbIOC.SelectedText,
                    MapperType = cmbMapper.SelectedText,
                    ORMType = cmbORM.SelectedText
                } : null
            };

            var service = new ArchitectureDesignManager(trviewProjectList);
            
            service.AddnewProject(dto);
            
            return true;
        }
    }
}
