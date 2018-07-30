using OYASAR.CodeGenerator.Lib.Core;
using System.Collections.Generic;

namespace OYASAR.CodeGenerator.Lib.TextTemplateModel
{
    internal class Architecture
    {
        internal string ProjectName { get; set; }

        internal Mapper Mapper { get; set; }

        internal IOC IOC { get; set; }

        internal ORM ORM { get; set; }

        internal Framework Framework { get;set; }

        internal ArchitectureDesign ArchitectureDesign { get; set; }
    }

    internal class ORM : Base
    {
        public ORM(string value) : base(value)
        {
            this.Name = ArchitectureService.GetTypeValue(value, ArchitectureService.Type.ORMType);
        }
    }

    internal class IOC : Base
    {
        public IOC(string value) : base(value)
        {
            this.Name = ArchitectureService.GetTypeValue(value, ArchitectureService.Type.IOCType);
        }
    }

    internal class Mapper : Base
    {
        public Mapper(string value) : base(value)
        {
            this.Name = ArchitectureService.GetTypeValue(value, ArchitectureService.Type.MapperType);
        }
    }

    internal class Framework : Base
    {
        public Framework(string value) : base(value)
        {
            this.Name = ArchitectureService.GetTypeValue(value, ArchitectureService.Type.FrameworkType);
        }
    }

    internal class ArchitectureDesign : Base
    {
        public ArchitectureDesign(string value) : base(value)
        {
            this.Name = ArchitectureService.GetTypeValue(value, ArchitectureService.Type.ArchitectureDesign);
        }
    }

    internal class Base
    {
        public Base(string value)
        {
            this.Type = value;
        }

        internal string Name { get; set; }

        internal string Type { get; set; }

        public IEnumerable<string> Dependencies { get; set; }
    }
}
