using OYASAR.CodeGenerator.Lib.TextTemplate;
using OYASAR.CodeGenerator.Lib.TextTemplateModel;
using System;
using System.Collections.Generic;
using System.IO;

namespace OYASAR.CodeGenerator.Lib.TemplateManager
{
    internal class RepositoryImplementationManager : BaseManager
    {
        private RepositoryImplementationTemplate Template;

        public static RepositoryImplementation Data { get; set; }

        private const string Path = "Repository";

        private const string FileExtension = "Repository.cs";

        private readonly IEnumerable<RepositoryImplementation> dataList;

        public RepositoryImplementationManager(IEnumerable<RepositoryImplementation> dataList)
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
            this.Template = new RepositoryImplementationTemplate();

            var codeDom = Template.TransformText();

            return codeDom;
        }
    }
}
