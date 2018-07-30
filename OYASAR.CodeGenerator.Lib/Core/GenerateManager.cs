using OYASAR.CodeGenerator.Lib.TemplateManager;
using OYASAR.CodeGenerator.Lib.TextTemplateModel;
using OYASAR.CodeGenerator.Lib.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace OYASAR.CodeGenerator.Lib.Core
{
    public class GenerateManager
    {
        public GenerateManager()
        {

        }

        public GenerateManager(string databaseName)
        {
            Repository.DbConfig.DataBase = databaseName;
        }

        public void SetDatabase(string database)
        {
            Repository.DbConfig.DataBase = database;
        }
        
        public void ExportProjectScript(params string[] projectNames)
        {
            var data = projectNames.Select(x => new Architecture { ProjectName = x });
            var manager = new ArchitectureManager(data);
            manager.Start();
        }

        public void ExportProjectScript(IEnumerable<ArchitectureParamDto> architectureParams)
        {
            var data = architectureParams.Select(x=> new Architecture
            {
                ProjectName = x.ProjectName,
                IOC = new IOC(x.IOCType),
                ORM = new ORM (x.ORMType),
                Mapper = new Mapper(x.MapperType),
                Framework = new Framework(x.FrameworkType),
                ArchitectureDesign = new ArchitectureDesign(x.ArchitectureDesign),
            });
            
            var manager = new ArchitectureManager(data);
            manager.Start();
            
            manager.Run();
        }

        #region Public Methods

        public IEnumerable<string> GetAllTable()
        {
            return new Repository().GetAllTable().OrderBy(x => x);
        }

        public static IEnumerable<string> GetAllDatabase(DbConfigDto dbConfig)
        {
            Repository.DbConfig = dbConfig;
            return new Repository().GetAllDatabase().OrderBy(x => x);
        }

        public bool ExportCodeDom(ExportParamDto exportParam)
        {
            var watch = Stopwatch.StartNew();
            watch.Start();
            ExportCommonModel(exportParam.DataAccessModel, exportParam.BusinessObject, exportParam.TableNames);

            if (exportParam.DataAccessConf)
                ExportDAConf(exportParam.TableNames);
            if (exportParam.RepositoryImplementation)
                ExportRepositoryImplementationl(exportParam.TableNames);
            if (exportParam.RepositoryInterface)
                ExportRepositoryInterface(exportParam.TableNames);
            if (exportParam.ServiceImplementation)
                ExportServiceImplementation(exportParam.TableNames);
            if (exportParam.ServiceInterface)
                ExportServiceInterface(exportParam.TableNames);
            if (exportParam.TableSchema)
                ExportSchemaTable(exportParam.TableSchemaIsOnlyFile, exportParam.TableNames);

            watch.Stop();
            Console.WriteLine("MilliSeconds: " + watch.ElapsedMilliseconds + "  Ticks: " + watch.ElapsedTicks);
            Console.WriteLine($"Export to {Environment.CurrentDirectory}");
            return true;
        }

        public bool ExportCodeDom(params string[] tableNames)
        {
            return ExportCodeDom(new ExportParamDto
            {
                BusinessObject = true,
                DataAccessConf = true,
                DataAccessModel = true,
                RepositoryImplementation = true,
                RepositoryInterface = true,
                ServiceImplementation = true,
                ServiceInterface = true,
                TableSchema = true,
                TableSchemaIsOnlyFile = true,
                TableNames = tableNames
            });
        }

        public dynamic ExportTableSchema(bool isOnlyFile, params string[] tableNames)
        {
            ExportSchemaTable(isOnlyFile, tableNames);
            return true;
        }

        #endregion Public Methods Finally

        #region Export Model Methods Start

        private void ExportCommonModel(bool DAModel, bool BOModel, params string[] tableNames)
        {
            Repository repository = null;

            if (DAModel || BOModel)
                repository = new Repository();

            if (DAModel)
            {
                var daManager = new DataAccessModelManager(GetDAModelData(repository, tableNames));
                daManager.Start();
            }

            if (BOModel)
            {
                var boManager = new BusinessObjectManager(GetBOModelData(repository, tableNames));

                boManager.Start();
            }
        }

        private void ExportDAConf(params string[] tableNames)
        {
            var manager = new DataAccessConfManager(GetDAConfData(tableNames));

            manager.Start();
        }

        private void ExportRepositoryImplementationl(params string[] tableNames)
        {
            var manager = new RepositoryImplementationManager(GetRepositoryImplementationData(tableNames));

            manager.Start(); ;
        }

        private void ExportRepositoryInterface(params string[] tableNames)
        {
            var manager = new RepositoryInterfaceManager(GetRepositoryInterfaceData(tableNames));

            manager.Start();
        }

        private void ExportServiceImplementation(params string[] tableNames)
        {
            var manager = new ServiceImplementationManager(GetServiceImplementationData(tableNames));

            manager.Start();
        }

        private void ExportServiceInterface(params string[] tableNames)
        {
            var manager = new ServiceInterfaceManager(GetServiceInterfaceData(tableNames));

            manager.Start();
        }

        private void ExportSchemaTable(bool onlyOneFile, params string[] tableNames)
        {
            var repository = new Repository();

            var data = repository.GetSchemaTables(tableNames).ToList();

            var tableManager = new MariaDbSchemaManager(GetMariaDbData(data, tableNames), onlyOneFile);

            tableManager.Start();

            tableManager.StartConstraint();
        }

        #endregion Export Model Methods Finally

        #region GetData Methods Start

        private IEnumerable<MariaDbSchema> GetMariaDbData(IEnumerable<SchemaModel> data, params string[] tableNames)
        {
            foreach (var item in tableNames.ToList())
            {
                var tmpData = data.Where(x => x.TableName == item);

                yield return new MariaDbSchema
                {
                    TableName = item,
                    Fields = GetColumnSchema(tmpData),
                    ForeingKeys = GetConstraints(tmpData),
                    Indexs = GetIndexs(tmpData)
                }.ToSetLogic();
            }
        }

        internal IEnumerable<KeyValuePair<string, string>> GetColumnSchema(IEnumerable<SchemaModel> data)
        {
            foreach (var item in data)
            {
                var key = item.ColumnName;

                var value = item.DataType;

                var lenght = item.MaxLenght;

                var nullable = item.IsNullable;

                if (!string.IsNullOrEmpty(item.IndexKey) && (value == "nvarchar" || value == "varchar" || value == "char"))
                    lenght = "255";

                yield return new KeyValuePair<string, string>(key, value).ToMatchSqlType(lenght, nullable);
            }
        }

        internal IEnumerable<MariaDbForeingKey> GetConstraints(IEnumerable<SchemaModel> data)
        {
            foreach (var item in data.Where(x => !string.IsNullOrEmpty(x.ForeingKey)))
            {
                yield return new MariaDbForeingKey
                {
                    KeyName = item.ForeingKey,
                    ColumnName = item.ColumnName,
                    ReferenceTableName = item.ReferenceTable
                };
            }
        }

        internal IEnumerable<string> GetIndexs(IEnumerable<SchemaModel> data)
        {
            foreach (var item in data.Where(x => !string.IsNullOrEmpty(x.IndexKey)))
            {
                yield return item.IndexKey;
            }
        }

        private IEnumerable<DataAccessModel> GetDAModelData(Repository repository, params string[] tableNames)
        {
            foreach (var item in tableNames.ToList())
            {
                yield return new DataAccessModel
                {
                    Class = item.ToGetClassName(),
                    TableName = item,
                    Params = repository.GetAllProperty(item)
                }.ToSetInheritence();
            }
        }

        private IEnumerable<BusinessObject> GetBOModelData(Repository repository, params string[] tableNames)
        {
            foreach (var item in tableNames.ToList())
            {
                yield return new BusinessObject
                {
                    Class = item.ToGetClassName(),
                    Params = repository.GetAllProperty(item)
                };
            }
        }

        private IEnumerable<RepositoryImplementation> GetRepositoryImplementationData(params string[] tableNames)
        {
            return GetData<RepositoryImplementation>(tableNames);
        }

        private IEnumerable<RepositoryInterface> GetRepositoryInterfaceData(params string[] tableNames)
        {
            return GetData<RepositoryInterface>(tableNames);
        }

        private IEnumerable<ServiceImplementation> GetServiceImplementationData(params string[] tableNames)
        {
            return GetData<ServiceImplementation>(tableNames);
        }

        private IEnumerable<ServiceInterface> GetServiceInterfaceData(params string[] tableNames)
        {
            return GetData<ServiceInterface>(tableNames);
        }

        private IEnumerable<DataAccessConf> GetDAConfData(params string[] tableNames)
        {
            return GetData<DataAccessConf>(tableNames);
        }

        private IEnumerable<T> GetData<T>(params string[] tableNames) where T : BaseModel, new()
        {
            foreach (var item in tableNames.ToList())
            {
                yield return new T
                {
                    Class = item.ToGetClassName()
                };
            }
        }

        #endregion GetData Methods Finally
    }
}
