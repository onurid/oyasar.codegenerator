using OYASAR.CodeGenerator.Lib.TextTemplate;
using OYASAR.CodeGenerator.Lib.TextTemplateModel;
using System;
using System.Collections.Generic;
using System.IO;

namespace OYASAR.CodeGenerator.Lib.TemplateManager
{
    internal class ServiceImplementationManager : BaseManager
    {
        private ServiceImplementationTemplate Template;

        public static ServiceImplementation Data { get; set; }

        private const string Path = "BusinessLayer";

        private const string FileExtension = "Service.cs";

        private readonly IEnumerable<ServiceImplementation> dataList;

        public ServiceImplementationManager(IEnumerable<ServiceImplementation> dataList)
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
            this.Template = new ServiceImplementationTemplate();

            var codeDom = Template.TransformText();

            return codeDom;
        }
    }
}
