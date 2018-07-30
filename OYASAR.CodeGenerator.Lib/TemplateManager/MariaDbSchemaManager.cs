using OYASAR.CodeGenerator.Lib.Core;
using OYASAR.CodeGenerator.Lib.TextTemplate;
using OYASAR.CodeGenerator.Lib.TextTemplateModel;
using System;
using System.Collections.Generic;
using System.IO;

namespace OYASAR.CodeGenerator.Lib.TemplateManager
{
    internal class MariaDbSchemaManager : BaseManager
    {
        private MariaDbSchemaTableTemplate Template;

        private MariaDbSchemaConstraintTemplate TemplateConstraint;

        public static MariaDbSchema Data { get; set; }

        private const string Path = "MariaDbTableSchema";

        private const string FileExtension = ".sql";

        private readonly IEnumerable<MariaDbSchema> dataList;

        public MariaDbSchemaManager(IEnumerable<MariaDbSchema> dataList, bool onlyOneFile) : base(onlyOneFile)
        {
            Console.WriteLine("Data are receiving from database...");
            this.dataList = dataList;
            Directory.CreateDirectory(Path);
        }

        public MariaDbSchemaManager(IEnumerable<MariaDbSchema> dataList)
        {
            Console.WriteLine("Data are receiving from database...");
            this.dataList = dataList;
            Directory.CreateDirectory(Path);
        }

        internal override void Start()
        {
            Console.WriteLine("The tables are starting to print...");
            var i = 1;

            foreach (var item in dataList)
            {
                Data = item;

                var codeDom = Render();

                var fileName = item.TableName;

                if (onlyOneFile)
                    fileName = Repository.DbConfig.DataBase;

                var filePath = $"{Path}/{fileName}{FileExtension}";

                if (!WriteToFile(filePath, codeDom))
                    Console.WriteLine("It can be not write to file! -- Maybe administrator permission!");

                Console.WriteLine($"[{i}] > {item.TableName} Table");

                i++;
            }
        }

        internal void StartConstraint()
        {
            Console.WriteLine("The constraints are starting to print...");
            var i = 1;

            foreach (var item in dataList)
            {
                Data = item;

                var codeDom = RenderConstraint();

                var fileName = item.TableName;

                if (onlyOneFile)
                    fileName = Repository.DbConfig.DataBase;

                var filePath = $"{Path}/{fileName}{FileExtension}";

                if (!WriteToFile(filePath, codeDom))
                    Console.WriteLine("It can be not write to file! -- Maybe administrator permission!");

                Console.WriteLine($"[{i}] > {item.TableName} Constraint");

                i++;
            }
        }

        private string Render()
        {
            this.Template = new MariaDbSchemaTableTemplate();

            var codeDom = Template.TransformText();

            return codeDom;
        }

        private string RenderConstraint()
        {
            this.TemplateConstraint = new MariaDbSchemaConstraintTemplate();

            var codeDom = TemplateConstraint.TransformText();

            return codeDom;
        }
    }
}
