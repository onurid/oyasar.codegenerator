using System.Collections.Generic;

namespace OYASAR.CodeGenerator.Lib.TextTemplateModel
{
    public class MariaDbSchema
    {
        public string TableName { get; set; }
        public IEnumerable<KeyValuePair<string, string>> Fields { get; set; }
        public IEnumerable<MariaDbForeingKey> ForeingKeys { get; set; }
        public IEnumerable<string> Indexs { get; set; }
        public bool PrimaryKey { get; set; }
    }

    public class MariaDbForeingKey
    {
        public string KeyName { get; set; }
        public string ColumnName { get; set; }
        public string ReferenceTableName { get; set; }
    }
}
