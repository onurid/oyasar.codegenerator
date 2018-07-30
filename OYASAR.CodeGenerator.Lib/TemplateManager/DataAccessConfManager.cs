using OYASAR.CodeGenerator.Lib.TextTemplate;
using OYASAR.CodeGenerator.Lib.TextTemplateModel;
using System;
using System.Collections.Generic;
using System.IO;

namespace OYASAR.CodeGenerator.Lib.TemplateManager
{
    internal class DataAccessConfManager : BaseManager
    {
        private DataAccessConfTemplate Template;

        public static DataAccessConf Data { get; set; }

        private const string Path = "DataAccessLayerConf";

        private const string FileExtension = "Conf.cs";

        private readonly IEnumerable<DataAccessConf> dataList;

        public DataAccessConfManager(IEnumerable<DataAccessConf> dataList)
        {
            this.dataList = dataList;
            Directory.CreateDirectory(Path);
        }

        internal override void Start()
        {
            foreach (var item in dataList)
            {
                Data = item;
                var codeDom = Render();

                var filePath = $"{Path}/{item.Class}{FileExtension}";

                if (!WriteToFile(filePath, codeDom))
                    Console.WriteLine("It can be not write to file!");
            }
        }

        private string Render()
        {
            this.Template = new DataAccessConfTemplate();

            var codeDom = Template.TransformText();

            return codeDom;
        }
    }
}
