using OYASAR.CodeGenerator.Lib.TextTemplate;
using OYASAR.CodeGenerator.Lib.TextTemplateModel;
using System;
using System.Collections.Generic;
using System.IO;

namespace OYASAR.CodeGenerator.Lib.TemplateManager
{
    internal class DataAccessModelManager : BaseManager
    {
        private DataAccessModelTemplate Template;

        public static DataAccessModel Data { get; set; }

        private const string Path = "DataAccessLayerModel";

        private const string FileExtension = ".cs";

        private readonly IEnumerable<DataAccessModel> dataList;

        public DataAccessModelManager(IEnumerable<DataAccessModel> dataList)
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
                    Console.WriteLine("It can be not write to file! -- Maybe administrator permission!");
            }
        }

        private string Render()
        {
            this.Template = new DataAccessModelTemplate();

            var codeDom = Template.TransformText();

            return codeDom;
        }
    }
}
