using System.Collections.Generic;

namespace OYASAR.CodeGenerator.Lib.TextTemplateModel
{
    public abstract class BaseModel
    {
        public string NameSpace { get; set; }

        public string ProjectName { get; set; }

        public bool MasterDomain { get; set; }

        public string Class { get; set; }
    }

    public abstract class CommonBaseModel : BaseModel
    {
        public IEnumerable<KeyValuePair<string, string>> Params { get; set; }
    }
}
