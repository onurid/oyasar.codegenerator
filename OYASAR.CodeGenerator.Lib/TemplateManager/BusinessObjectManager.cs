using OYASAR.CodeGenerator.Lib.TextTemplate;
using OYASAR.CodeGenerator.Lib.TextTemplateModel;
using System;
using System.Collections.Generic;
using System.IO;

namespace OYASAR.CodeGenerator.Lib.TemplateManager
{
    internal class BusinessObjectManager : BaseManager
    {
        private BusinessObjectTemplate Template;

        public static BusinessObject Data { get; set; }

        private const string Path = "BusinessObJect";

        private const string FileExtension = ".cs";

        private readonly IEnumerable<BusinessObject> dataList;

        public BusinessObjectManager(IEnumerable<BusinessObject> dataList)
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
            this.Template = new BusinessObjectTemplate();

            var codeDom = Template.TransformText();

            return codeDom;
        }
    }
}
