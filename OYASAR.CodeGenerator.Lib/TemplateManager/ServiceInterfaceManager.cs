using OYASAR.CodeGenerator.Lib.TextTemplate;
using OYASAR.CodeGenerator.Lib.TextTemplateModel;
using System;
using System.Collections.Generic;
using System.IO;

namespace OYASAR.CodeGenerator.Lib.TemplateManager
{
    internal class ServiceInterfaceManager : BaseManager
    {
        private ServiceInterfaceTemplate Template;

        public static ServiceInterface Data { get; set; }

        private const string Path = "BusinessLayer";

        private const string FileBegin = "I";

        private const string FileExtension = "Service.cs";

        private readonly IEnumerable<ServiceInterface> dataList;

        public ServiceInterfaceManager(IEnumerable<ServiceInterface> dataList)
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


                var filePath = $"{Path}/{FileBegin}{item.Class}{FileExtension}";

                if (!WriteToFile(filePath, codeDom))
                    Console.WriteLine("It can be not write to file!");
            }
        }

        private string Render()
        {
            this.Template = new ServiceInterfaceTemplate();

            var codeDom = Template.TransformText();

            return codeDom;
        }
    }
}
