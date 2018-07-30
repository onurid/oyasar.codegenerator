using OYASAR.CodeGenerator.WinApp.NewLogic;

namespace OYASAR.CodeGenerator.WinApp.NewLogic
{
    public class ArchitectureParamDto
    {
        public string DependencyArchitecture { get; set; }
        public string ProjectName { get; set; }
        
        public int ArchLayerCode { get; set; }

        public Layers Layers { get; set; }
        public Tools Tools { get; set; }
    }

    public class Tools
    {
        public string ORMType { get; set; }
        public string IOCType { get; set; }
        public string MapperType { get; set; }
    }

    public class Layers
    {
        public bool ApiLayer;
        public bool MvcLayer;
        public bool BusinessLayer;
        public bool RepositoryLayer;
        public bool RepositoryDataLayer;
        public bool CoreRepositoryLayer;
        public bool CoreLayer;        
    }

    public static class ArchitectureParamExtension
    {
        public static string ToStringForList(this ArchitectureParamDto obj)
        {
            return $"{obj.ProjectName} - {obj.Tools.ORMType} - {obj.Tools.IOCType} - {obj.Tools.MapperType} - {obj.DependencyArchitecture}";
        }
    }
}
