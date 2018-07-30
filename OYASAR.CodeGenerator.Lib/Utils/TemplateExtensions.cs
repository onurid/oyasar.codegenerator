using OYASAR.CodeGenerator.Lib.TextTemplateModel;
using System.Collections.Generic;

namespace OYASAR.CodeGenerator.Lib.Utils
{
    internal static class TemplateExtensions
    {
        internal static string ToGetClassName(this string tableName)
        {
            return LogicalUnit.GetClassName(tableName);
        }

        internal static KeyValuePair<string, string> ToChangeTypeMap(this KeyValuePair<string, string> obj, bool nullable)
        {
            return LogicalUnit.ChangeTypeMap(obj, nullable);
        }

        internal static KeyValuePair<string, string> ToMatchSqlType(this KeyValuePair<string, string> obj, string lenght, bool nullable)
        {
            return LogicalUnit.MatchSqlType(obj, lenght, nullable);
        }

        internal static DataAccessModel ToSetInheritence(this DataAccessModel obj)
        {
            LogicalUnit.SetInheritenceOfClass(obj);

            return obj;
        }

        internal static MariaDbSchema ToSetLogic(this MariaDbSchema obj)
        {
            LogicalUnit.SetPrimaryKey(obj);

            return obj;
        }
    }
}
