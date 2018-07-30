using OYASAR.CodeGenerator.Lib.Utils;
using System.Collections.Generic;
using System.Text;

namespace OYASAR.CodeGenerator.Lib.Core
{
    internal sealed class Repository
    {
        private readonly DataAccessLayer dal;

        internal static DbConfigDto DbConfig { get; set; }

        private string connectionString = "data source=addr;persist security info=True;initial catalog=database;user id=usrname;password=passwd;MultipleActiveResultSets=True;";

        internal Repository()
        {
            connectionString = connectionString.Replace("addr", DbConfig.Address);
            connectionString = connectionString.Replace("usrname", DbConfig.Username);
            connectionString = connectionString.Replace("passwd", DbConfig.Password);
            connectionString = connectionString.Replace("database", DbConfig.DataBase);

            dal = new DataAccessLayer(connectionString);
        }

        internal IEnumerable<string> GetAllTable()
        {
            var result = dal.SqlExecute("select TABLE_NAME from information_schema.tables nolock");

            for (var i = 0; i < result.Count; i++)
            {
                yield return result[i][0].ToString();
            }
        }

        internal IEnumerable<KeyValuePair<string, string>> GetAllProperty(string tableName)
        {
            var result = dal.GetSchemaTable($"select * from {tableName} nolock");

            for (var i = 0; i < result.Count; i++)
            {
                var boolean = (bool?)result[i][13];

                var nullable = boolean == null ? true : (bool)boolean;

                yield return new KeyValuePair<string, string>(result[i][0].ToString(), result[i][24].ToString()).ToChangeTypeMap(nullable);
            }
        }

        internal IEnumerable<SchemaModel> GetSchemaTables(params string[] tables)
        {
            var sb = new StringBuilder();

            foreach (var item in tables)
                sb.AppendLine($"INSERT @tables VALUES('{item}');");

            var query = $@"DECLARE @tables TABLE (tablename nvarchar(50))

                          {sb.ToString()};

                          select *,  
							  (select TABLE_NAME from INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE CONSTRAINT_NAME in
																							(select UNIQUE_CONSTRAINT_NAME as PkName from INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS rc
																							where rc.CONSTRAINT_NAME = DM.ForeingKey)
	                          ) AS RefTable from (
                          SELECT TABLE_NAME AS TableName, Column_name AS ColumnName, DATA_TYPE AS DataType, CHARACTER_MAXIMUM_LENGTH AS MaxLenght, 
	                          (CASE WHEN (IS_NULLABLE = 'YES') THEN 1 ELSE 0 END) AS IsNullable,
	                          (SELECT DISTINCT COL_NAME(ic.object_id,ic.column_id) FROM sys.indexes AS i (NOLOCK)
				                             INNER JOIN sys.index_columns AS ic ON i.object_id = ic.object_id AND i.index_id = ic.index_id
				                             WHERE i.type = 2 and i.object_id = OBJECT_ID(TABLE_NAME) and COL_NAME(ic.object_id,ic.column_id) = Column_name
	                          ) AS IndexKey, 
	                          (SELECT TOP 1 obj_Constraint.NAME AS ConstraintName FROM   sys.objects obj_table (NOLOCK)
												                              JOIN sys.objects obj_Constraint ON obj_table.object_id = obj_Constraint.parent_object_id
												                              JOIN sys.sysconstraints constraints ON constraints.constid = obj_Constraint.object_id
												                              JOIN sys.columns columns ON columns.object_id = obj_table.object_id AND columns.column_id = constraints.colid
												                              WHERE  obj_Constraint.[type] = 'F' AND obj_table.NAME = TABLE_NAME AND columns.NAME = Column_name
												                              GROUP BY obj_Constraint.NAME
	                          ) AS ForeingKey
                          FROM information_schema.COLUMNS NOLOCK
						   WHERE TABLE_NAME in (SELECT tablename FROM @tables)) as DM;";

            var result = dal.SqlExecute(query);

            for (int i = 0; i < result.Count; i++)
            {
                yield return new SchemaModel
                {
                    TableName = result[i][0].ToString(),
                    ColumnName = result[i][1].ToString(),
                    DataType = result[i][2].ToString(),
                    MaxLenght = result[i][3].ToString(),
                    IsNullable = result[i][4].ToString() == "1" ? true : false,
                    IndexKey = result[i][5].ToString(),
                    ForeingKey = result[i][6].ToString(),
                    ReferenceTable = result[i][7].ToString()
                };
            }
        }

        internal IEnumerable<string> GetAllDatabase()
        {
            var result = dal.SqlExecute($@"SELECT name FROM master.dbo.sysdatabases nolock
                                            WHERE name NOT IN('master', 'tempdb', 'model', 'msdb'); ");

            for (var i = 0; i < result.Count; i++)
            {
                yield return result[i][0].ToString();
            }
        }
    }
}
