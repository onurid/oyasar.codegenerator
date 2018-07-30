namespace OYASAR.CodeGenerator.Lib.Core
{
    public class ExportParamDto
    {
        public bool DataAccessModel { get; set; }
        public bool DataAccessConf { get; set; }
        public bool BusinessObject { get; set; }
        public bool RepositoryImplementation { get; set; }
        public bool RepositoryInterface { get; set; }
        public bool ServiceImplementation { get; set; }
        public bool ServiceInterface { get; set; }
        public bool TableSchema { get; set; }
        public bool TableSchemaIsOnlyFile { get; set; }
        public string[] TableNames { get; set; }
    }
}
