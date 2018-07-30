namespace OYASAR.CodeGenerator.Lib.Core
{
    internal class SchemaModel
    {
        internal string IndexKey { get; set; }
        internal string ForeingKey { get; set; }
        internal string ColumnName { get; set; }
        internal string DataType { get; set; }
        internal string MaxLenght { get; set; }
        internal bool IsNullable { get; set; }
        internal string TableName { get; set; }
        internal string ReferenceTable { get; set; }
    }
}
