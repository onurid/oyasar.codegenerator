using System.Collections.Generic;
using System.Windows.Forms;

namespace OYASAR.CodeGenerator.WinApp.NewLogic
{
    public class ArchitectureDesignManager
    {
        private readonly TreeView treeView;

        private const string WrittenBy = "OYASAR";

        private const string CoreLayerName = "Core";

        private const string ApiLayerName = "Api";

        private const string MvcLayerName = "Mvc";

        private const string BusinessLayerName = "Business";

        private const string RepositoryLayerName = "Repository";

        private const string RepositoryDataLayerName = "Repository.Data";

        private const string CoreRepositoryLayerName = "Core.Repository";


        public ArchitectureDesignManager(TreeView treeView)
        {
            this.treeView = treeView;
        }

        public void AddnewProject(ArchitectureParamDto dto)
        {
            var projectName = $"{WrittenBy}.{dto.ProjectName}";
            SetNodes(dto, projectName);
        }

        private void SetNodes(ArchitectureParamDto dto, string projectName)
        {
            TreeNode core = null;
            TreeNode coreRepository = null;
            TreeNode repository = null;
            TreeNode repositoryData = null;
            TreeNode business = null;
            TreeNode api = null;

            TreeNode project = null;

           var result = SetNodeAsUnionLayer(dto, projectName, core, coreRepository,
                repository, repositoryData, business, api, project);

            treeView.Nodes.AddRange(new TreeNode[] { result });
        }

        
        private TreeNode SetNodeAsUnionLayer(ArchitectureParamDto dto, string projectName,
            TreeNode core, TreeNode coreRepository, TreeNode repository,
            TreeNode repositoryData, TreeNode business, TreeNode api,
            TreeNode project)

        {
            if (dto.Layers.CoreLayer)
            {
                var node = $"{projectName}.{CoreLayerName}";
                core = new TreeNode(node);
            }

            if (dto.Layers.CoreRepositoryLayer)
            {
                if (dto.Layers.CoreLayer)
                {
                    var nodex = $"{projectName}.{CoreLayerName}";
                    var corex = new TreeNode(nodex);

                    var node = $"{projectName}.{CoreRepositoryLayerName}";
                    coreRepository = new TreeNode(node, new TreeNode[] { corex });
                }
                else
                {
                    var node = $"{projectName}.{CoreRepositoryLayerName}";
                    coreRepository = new TreeNode(node);
                }
            }

            if (dto.Layers.RepositoryLayer)
            {
                if (dto.Layers.CoreRepositoryLayer)
                {
                    if (dto.Layers.CoreLayer)
                    {
                        var nodex = $"{projectName}.{CoreLayerName}";
                        var corex = new TreeNode(nodex);

                        var nodexx = $"{projectName}.{CoreRepositoryLayerName}";
                        var coreRepositoryx = new TreeNode(nodexx, new TreeNode[] { corex });

                        var node = $"{projectName}.{RepositoryLayerName}";
                        repository = new TreeNode(node, new TreeNode[] { coreRepositoryx });
                    }
                    else
                    {
                        var nodex = $"{projectName}.{CoreRepositoryLayerName}";
                        var coreRepositoryx = new TreeNode(nodex);

                        var node = $"{projectName}.{RepositoryLayerName}";
                        repository = new TreeNode(node, new TreeNode[] { coreRepositoryx });
                    }
                }
                else
                {
                    if (dto.Layers.CoreLayer)
                    {
                        var nodex = $"{projectName}.{CoreLayerName}";
                        var corex = new TreeNode(nodex);

                        var node = $"{projectName}.{RepositoryLayerName}";
                        repository = new TreeNode(node, new TreeNode[] { corex });
                    }
                    else
                    {
                        var node = $"{projectName}.{RepositoryLayerName}";
                        repository = new TreeNode(node);
                    }
                }
            }

            if (dto.Layers.RepositoryDataLayer)
            {
                if (dto.Layers.CoreRepositoryLayer)
                {
                    if (dto.Layers.CoreLayer)
                    {
                        var nodex = $"{projectName}.{CoreLayerName}";
                        var corex = new TreeNode(nodex);

                        var nodexx = $"{projectName}.{CoreRepositoryLayerName}";
                        var coreRepositoryx = new TreeNode(nodexx, new TreeNode[] { corex });

                        var node = $"{projectName}.{RepositoryDataLayerName}";
                        repositoryData = new TreeNode(node, new TreeNode[] { coreRepositoryx });
                    }
                    else
                    {
                        var nodex = $"{projectName}.{CoreRepositoryLayerName}";
                        var coreRepositoryx = new TreeNode(nodex);

                        var node = $"{projectName}.{RepositoryDataLayerName}";
                        repositoryData = new TreeNode(node, new TreeNode[] { coreRepositoryx });
                    }
                }
                else
                {
                    if (dto.Layers.CoreLayer)
                    {
                        var nodex = $"{projectName}.{CoreLayerName}";
                        var corex = new TreeNode(nodex);

                        var node = $"{projectName}.{RepositoryDataLayerName}";
                        repositoryData = new TreeNode(node, new TreeNode[] { corex });
                    }
                    else
                    {
                        var node = $"{projectName}.{RepositoryDataLayerName}";
                        repositoryData = new TreeNode(node);
                    }
                }
            }

            if (dto.Layers.BusinessLayer)
            {
                if (dto.Layers.CoreLayer)
                {
                    var nodex = $"{projectName}.{CoreLayerName}";
                    var corex = new TreeNode(nodex);

                    var node = $"{projectName}.{BusinessLayerName}";
                    business = new TreeNode(node, new TreeNode[] { corex });
                }
                else
                {
                    var node = $"{projectName}.{BusinessLayerName}";
                    business = new TreeNode(node);
                }
            }

            if (dto.Layers.ApiLayer || dto.Layers.MvcLayer)
            {
                if (dto.Layers.BusinessLayer)
                {
                    if (dto.Layers.RepositoryLayer || dto.Layers.RepositoryDataLayer)
                    {
                        if (dto.Layers.CoreLayer)
                        {
                            var nodex = $"{projectName}.{CoreLayerName}";
                            var corex = new TreeNode(nodex);

                            var node = $"{projectName}.{ApiLayerName}";

                            if (dto.Layers.RepositoryLayer && dto.Layers.RepositoryDataLayer)
                            {
                                api = new TreeNode(node, new TreeNode[] { business, repository, repositoryData, corex });
                            }
                            else if (dto.Layers.RepositoryLayer)
                            {
                                api = new TreeNode(node, new TreeNode[] { business, repository, corex });
                            }
                            else if (dto.Layers.RepositoryDataLayer)
                            {
                                api = new TreeNode(node, new TreeNode[] { business, repositoryData, corex });
                            }
                        }
                        else
                        {
                            var node = $"{projectName}.{ApiLayerName}";

                            if (dto.Layers.RepositoryLayer && dto.Layers.RepositoryDataLayer)
                            {
                                api = new TreeNode(node, new TreeNode[] { business, repository, repositoryData });
                            }
                            else if (dto.Layers.RepositoryLayer)
                            {
                                api = new TreeNode(node, new TreeNode[] { business, repository });
                            }
                            else if (dto.Layers.RepositoryDataLayer)
                            {
                                api = new TreeNode(node, new TreeNode[] { business, repositoryData });
                            }
                        }
                    }
                    else
                    {
                        if (dto.Layers.CoreLayer)
                        {
                            var nodex = $"{projectName}.{CoreLayerName}";
                            var corex = new TreeNode(nodex);

                            var node = $"{projectName}.{ApiLayerName}";
                            api = new TreeNode(node, new TreeNode[] { business, corex });
                        }
                        else
                        {
                            var node = $"{projectName}.{ApiLayerName}";
                            api = new TreeNode(node, new TreeNode[] { business });
                        }
                    }
                }
                else
                {
                    if (dto.Layers.RepositoryLayer)
                    {
                        if (dto.Layers.CoreLayer)
                        {
                            var nodex = $"{projectName}.{CoreLayerName}";
                            var corex = new TreeNode(nodex);

                            var node = $"{projectName}.{ApiLayerName}";
                            api = new TreeNode(node, new TreeNode[] { repository, corex });
                        }
                        else
                        {
                            var node = $"{projectName}.{ApiLayerName}";
                            api = new TreeNode(node, new TreeNode[] { repository });
                        }
                    }
                    else
                    {
                        if (dto.Layers.CoreLayer)
                        {
                            var nodex = $"{projectName}.{CoreLayerName}";
                            var corex = new TreeNode(nodex);

                            var node = $"{projectName}.{ApiLayerName}";
                            api = new TreeNode(node, new TreeNode[] { corex });
                        }
                        else
                        {
                            var node = $"{projectName}.{ApiLayerName}";
                            api = new TreeNode(node);
                        }
                    }
                }
                if (dto.Layers.ApiLayer && dto.Layers.MvcLayer)
                {
                    var mvc = (TreeNode)api.Clone();
                    mvc.Text = $"{projectName}.{MvcLayerName}";

                    project = new TreeNode(projectName, new TreeNode[] { api, mvc });
                }
                else if (dto.Layers.MvcLayer)
                {
                    var mvc = (TreeNode)api.Clone();
                    mvc.Text = $"{projectName}.{MvcLayerName}";

                    project = new TreeNode(projectName, new TreeNode[] { mvc });
                }
                else
                    project = new TreeNode(projectName, new TreeNode[] { api });

            }
            else
            {
                if (dto.Layers.BusinessLayer)
                {
                    if (dto.Layers.RepositoryLayer || dto.Layers.RepositoryDataLayer)
                    {
                        if (dto.Layers.CoreLayer)
                        {
                            if (dto.Layers.RepositoryLayer && dto.Layers.RepositoryDataLayer)
                                project = new TreeNode(projectName, new TreeNode[] { business, repository, repositoryData, core });
                            else if (dto.Layers.RepositoryLayer)
                                project = new TreeNode(projectName, new TreeNode[] { business, repository, core });
                            else if (dto.Layers.RepositoryDataLayer)
                                project = new TreeNode(projectName, new TreeNode[] { business, repositoryData, core });
                        }
                        else
                        {
                            if (dto.Layers.RepositoryLayer && dto.Layers.RepositoryDataLayer)
                                project = new TreeNode(projectName, new TreeNode[] { business, repository, repositoryData });
                            else if (dto.Layers.RepositoryLayer)
                                project = new TreeNode(projectName, new TreeNode[] { business, repository });
                            else if (dto.Layers.RepositoryDataLayer)
                                project = new TreeNode(projectName, new TreeNode[] { business, repositoryData });
                        }
                    }
                    else
                    {
                        if (dto.Layers.CoreLayer)
                        {
                            project = new TreeNode(projectName, new TreeNode[] { business, core });
                        }
                        else
                        {
                            project = new TreeNode(projectName, new TreeNode[] { business });
                        }
                    }
                }
                else
                {
                    if (dto.Layers.RepositoryLayer || dto.Layers.RepositoryDataLayer)
                    {
                        if (dto.Layers.CoreLayer)
                        {
                            if (dto.Layers.RepositoryLayer && dto.Layers.RepositoryDataLayer)
                                project = new TreeNode(projectName, new TreeNode[] { repository, repositoryData, core });
                            else if (dto.Layers.RepositoryLayer)
                                project = new TreeNode(projectName, new TreeNode[] { repository, core });
                            else if (dto.Layers.RepositoryDataLayer)
                                project = new TreeNode(projectName, new TreeNode[] { repositoryData, core });
                        }
                        else
                        {
                            if (dto.Layers.RepositoryLayer && dto.Layers.RepositoryDataLayer)
                                project = new TreeNode(projectName, new TreeNode[] { repository, repositoryData });
                            else if (dto.Layers.RepositoryLayer)
                                project = new TreeNode(projectName, new TreeNode[] { repository });
                            else if (dto.Layers.RepositoryDataLayer)
                                project = new TreeNode(projectName, new TreeNode[] { repositoryData });
                        }
                    }
                    else
                    {
                        if (dto.Layers.CoreLayer)
                        {
                            project = new TreeNode(projectName, new TreeNode[] { core });
                        }
                        else
                        {
                            project = new TreeNode(projectName);
                        }
                    }
                }
            }

            return project;
        }

        private TreeNode SetLayer(bool layer, string projectName, string layerName)
        {
            if (layer)
            {
                var name = $"{projectName}.{layerName}";
                return new TreeNode(name);
            }

            return null;
        }

        private TreeNode SetLayer(bool layer, string projectName, IList<TreeNode> nodes, string layerName)
        {
            TreeNode result = null;

            if (layer)
            {
                var name = $"{projectName}.{layerName}";
                result = new TreeNode(name);
                nodes.Add(result);
            }

            return result;
        }

        private TreeNode SetLayer(bool layer, string projectName, string layerName, params TreeNode[] subNodes)
        {
            var resultNode = SetLayer(layer, projectName, layerName);

            if (resultNode != null)
            {
                foreach (var subNode in subNodes)
                {
                    if (subNode != null)
                    {
                        resultNode.Nodes.Add(subNode);
                    }
                }
            }

            return resultNode;
        }

        private TreeNode SetLayer(bool layer, string projectName, IList<TreeNode> nodes, string layerName, params TreeNode[] subNodes)
        {
            var resultNode = SetLayer(layer, projectName, nodes, layerName);

            if (resultNode != null)
            {
                foreach (var subNode in subNodes)
                {
                    if (subNode != null)
                    {
                        resultNode.Nodes.Add(subNode);
                    }
                }
            }

            return resultNode;
        }
    }
}
