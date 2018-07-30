using System.IO;

namespace OYASAR.CodeGenerator.Lib.TemplateManager
{
    internal abstract class BaseManager
    {
        protected readonly bool onlyOneFile;

        internal BaseManager()
        {

        }

        internal BaseManager(bool onlyOneFile)
        {
            this.onlyOneFile = onlyOneFile;
        }

        protected bool WriteToFile(string path, string content)
        {
            try
            {
                if (onlyOneFile)
                    File.AppendAllText(path, content);
                else
                    File.WriteAllText(path, content);

                return true;
            }
            catch { return false; }
        }

        internal abstract void Start();
    }
}
