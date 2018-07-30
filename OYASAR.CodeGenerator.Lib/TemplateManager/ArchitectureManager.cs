using OYASAR.CodeGenerator.Lib.TextTemplate;
using OYASAR.CodeGenerator.Lib.TextTemplateModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace OYASAR.CodeGenerator.Lib.TemplateManager
{
    internal class ArchitectureManager : BaseManager
    {
        private ArchitectureTemplate Template;

        public static Architecture Data { get; set; }

        private const string Path = "Architecture";

        private const string FileExtension = ".bat";

        private readonly IEnumerable<Architecture> dataList;

        private readonly IList<string> processList;

        public ArchitectureManager(IEnumerable<Architecture> dataList)
        {
            this.dataList = dataList;
            this.processList = new List<string>();
            Directory.CreateDirectory(Path);
        }

        internal override void Start()
        {
            foreach (var item in dataList)
            {
                Data = item;
                var codeDom = Render();

                var filePath = $"{Path}/{item.ProjectName}{FileExtension}";

                this.processList.Add(filePath);

                if (!WriteToFile(filePath, codeDom))
                    Console.WriteLine("It can be not write to file!");
            }
        }

        internal void Run()
        {
            foreach (var itemProc in processList)
            {
                Process.Start($"{Environment.CurrentDirectory}\\{itemProc}");
            }
        }

        private string Render()
        {
            this.Template = new ArchitectureTemplate();

            var codeDom = Template.TransformText();

            return codeDom;
        }
    }
}
