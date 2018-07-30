namespace OYASAR.CodeGenerator.Lib.Core
{
    public class ArchitectureParamDto
    {
        public string ORMType { get; set; }
        public string IOCType { get; set; }
        public string MapperType { get; set; }
        public string FrameworkType { get; set; }
        public string ArchitectureDesign { get; set; }
        public string ProjectName { get; set; }
    }

    public static class ArchitectureParamExtension
    {
        public static string ToStringForList(this ArchitectureParamDto obj)
        {
            return $"{obj.ProjectName} - {obj.ORMType} - {obj.IOCType} - {obj.MapperType} - {obj.ArchitectureDesign} - {obj.FrameworkType}";
        }
    }
}
