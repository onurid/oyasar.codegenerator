using OYASAR.CodeGenerator.Lib.TextTemplateModel;
using System.Collections.Generic;
using System.Linq;

namespace OYASAR.CodeGenerator.Lib.Utils
{
    internal static class LogicalUnit
    {
        private static readonly string[] offerBaseEntity;

        private static readonly string[] commonBaseEntity;

        private static readonly string[] hotelBaseEntity;

        private static readonly string[] baseEntity;

        static LogicalUnit()
        {
            offerBaseEntity = new[] { "ID", "Company", "Tombstone", "Created", "CreatedUser", "LastEdit", "LastEditUser" };
            commonBaseEntity = new[] { "ID", "Company", "Tombstone", "Created", "CreatedUser" };
            hotelBaseEntity = new[] { "ID", "Created", "CreatedUser", "LastEdit", "LastEditUser" };
            baseEntity = new[] { "ID" };
        }

        internal static string GetClassName(this string tableName)
        {
            var part = tableName.Split('_');

            var draft = part.Last();

            if (draft.ToArray().Last() == 's')
                draft = draft.Substring(0, draft.Length - 1);

            return draft;
        }

        internal static KeyValuePair<string, string> ChangeTypeMap(this KeyValuePair<string, string> obj, bool nullable)
        {
            switch (obj.Value)
            {
                case "varchar":
                    return new KeyValuePair<string, string>(obj.Key, "string");

                case "nvarchar":
                    return new KeyValuePair<string, string>(obj.Key, "string");

                case "bit":
                    return new KeyValuePair<string, string>(obj.Key, nullable ? "bool?" : "bool");

                case "timestamp":
                    return new KeyValuePair<string, string>(obj.Key, nullable ? "DateTime?" : "DateTime");

                case "datetime":
                    return new KeyValuePair<string, string>(obj.Key, nullable ? "DateTime?" : "DateTime");

                case "int":
                    return new KeyValuePair<string, string>(obj.Key, nullable ? "int?" : "int");

                default:
                    return obj;
            }
        }

        internal static void SetInheritenceOfClass(DataAccessModel obj)
        {
            if (offerBaseEntity.Intersect(obj.Params.Select(x => x.Key)).Count() == offerBaseEntity.Count())
            {
                obj.Inheritence = "OfferBaseEntity";
                obj.Params = obj.Params.Where(x => !offerBaseEntity.Contains(x.Key)).AsEnumerable();
            }

            if (commonBaseEntity.Intersect(obj.Params.Select(x => x.Key)).Count() == commonBaseEntity.Count())
            {
                obj.Inheritence = "CommonBaseEntity";
                obj.Params = obj.Params.Where(x => !commonBaseEntity.Contains(x.Key)).AsEnumerable();
            }

            if (hotelBaseEntity.Intersect(obj.Params.Select(x => x.Key)).Count() == hotelBaseEntity.Count())
            {
                obj.Inheritence = "HotelBossBaseEntity";
                obj.Params = obj.Params.Where(x => !hotelBaseEntity.Contains(x.Key)).AsEnumerable();
            }

            if (baseEntity.Intersect(obj.Params.Select(x => x.Key)).Count() == baseEntity.Count())
            {
                obj.Inheritence = "BaseEntity";
                obj.Params = obj.Params.Where(x => !baseEntity.Contains(x.Key)).AsEnumerable();
            }
        }

        internal static void SetPrimaryKey(MariaDbSchema obj)
        {
            if (obj.Fields.Select(x => x.Key.ToUpper()).Contains("ID"))
                obj.PrimaryKey = true;
        }

        internal static KeyValuePair<string, string> MatchSqlType(this KeyValuePair<string, string> obj, string lenght, bool nullable)
        {
            switch (obj.Value)
            {
                case "varchar":
                    return new KeyValuePair<string, string>(obj.Key, CalLenght(obj.Key, "varchar", lenght, nullable));

                case "nvarchar":
                    return new KeyValuePair<string, string>(obj.Key, CalLenght(obj.Key, "varchar", lenght, nullable));

                case "uniqueidentifier":
                    return new KeyValuePair<string, string>(obj.Key, CalLenght(obj.Key, "binary", "16", nullable));

                case "ntext":
                    return new KeyValuePair<string, string>(obj.Key, CalLenght(obj.Key, "text", lenght, nullable));

                case "image":
                    return new KeyValuePair<string, string>(obj.Key, CalLenght(obj.Key, "Longblob", null, nullable));

                case "decimal":
                    return new KeyValuePair<string, string>(obj.Key, CalLenght(obj.Key, "decimal", "18, 4", nullable));

                case "money":
                    return new KeyValuePair<string, string>(obj.Key, CalLenght(obj.Key, "decimal", "19, 4", nullable));

                case "sysname":
                    return new KeyValuePair<string, string>(obj.Key, CalLenght(obj.Key, "CHAR", "256", nullable));

                case "datetime2":
                    return new KeyValuePair<string, string>(obj.Key, CalLenght(obj.Key, "datetime", lenght, nullable));

                case "xml":
                    return new KeyValuePair<string, string>(obj.Key, CalLenght(obj.Key, "text", lenght, nullable));

                default:
                    return new KeyValuePair<string, string>(obj.Key, CalLenght(obj.Key, obj.Value, lenght, nullable)); ;
            }
        }

        private static string CalLenght(string key, string type, string param, bool nullable)
        {
            var value = type;

            var lenght = string.IsNullOrEmpty(param) ? string.Empty : $"({param})";

            if (lenght == "(-1)" || lenght == "(max)" || lenght == "(2147483647)")
            {
                if (type == "varchar")
                {
                    lenght = string.Empty;
                    value = "TEXT";
                }
                if (type == "nvarchar")
                {
                    lenght = string.Empty;
                    value = "TEXT";
                }
                if (type == "varbinary")
                {
                    lenght = string.Empty;
                    value = "TEXT";
                }
                if (type == "text")
                {
                    lenght = string.Empty;
                    value = "TEXT";
                }
            }

            var rnullable = nullable ? "NULL" : "NOT NULL";

            value = $"{value}{lenght} {rnullable}";

            if (key.ToUpper() == "ID" && type.ToUpper() == "INT")
                value = $"{value} AUTO_INCREMENT";

            return value;
        }
    }
}
