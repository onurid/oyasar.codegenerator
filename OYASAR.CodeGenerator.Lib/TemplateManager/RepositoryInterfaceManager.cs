using OYASAR.CodeGenerator.Lib.TextTemplate;
using OYASAR.CodeGenerator.Lib.TextTemplateModel;
using System;
using System.Collections.Generic;
using System.IO;

namespace OYASAR.CodeGenerator.Lib.TemplateManager
{
    internal class RepositoryInterfaceManager : BaseManager
    {
        private RepositoryInterfaceTemplate Template;

        public static RepositoryInterface Data { get; set; }

        private const string Path = "Repository";

        private const string FileBegin = "I";

        private const string FileExtension = "Repository.cs";

        private readonly IEnumerable<RepositoryInterface> dataList;

        public RepositoryInterfaceManager(IEnumerable<RepositoryInterface> dataList)
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
            this.Template = new RepositoryInterfaceTemplate();

            var codeDom = Template.TransformText();

            return codeDom;
        }
    }
}
