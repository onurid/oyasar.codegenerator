using System.Collections.Generic;
using System.Linq;

namespace OYASAR.CodeGenerator.Lib.Core
{
    public static class ArchitectureService
    {
        public static readonly IDictionary<string, string> ORMTypeDic;

        public static readonly IDictionary<string, string> IOCTypeDic;

        public static readonly IDictionary<string, string> MapperTypeDic;

        public static readonly IDictionary<string, string> FrameworkTypeDic;

        public static readonly IDictionary<string, string> ArchitectureDesignDic;

        public enum ORMType
        {
            NHibernate,
            EntityFrameyok
        }

        public enum IOCType
        {
            CastleWindsor,
            NetCoreIoc
        }

        public enum MapperType
        {
            AutoMapper,
            ExpressMapper
        }

        public enum FrameworkType
        {
            NetFramework,
            NetCoreFramework
        }

        public enum ArchitectureDesign
        {
            UnionLayerArchitecture,
            TraditionalLayerArchitecture
        }

        public enum Type
        {
            FrameworkType,
            ORMType,
            IOCType,
            MapperType,
            ArchitectureDesign
        }

        static ArchitectureService()
        {
            ORMTypeDic = new Dictionary<string, string>
            {
                { ORMType.EntityFrameyok.ToString() , "EF" },
                { ORMType.NHibernate.ToString(), "NHibernate" }
            };

            IOCTypeDic = new Dictionary<string, string>
            {
                { IOCType.NetCoreIoc.ToString(), "NetcoreIoc" },
                { IOCType.CastleWindsor.ToString(), "CastleWindsor" }                
            };

            MapperTypeDic = new Dictionary<string, string>
            {
                { MapperType.AutoMapper.ToString(), "DefaultAutoMapper" },
                { MapperType.ExpressMapper.ToString(), "ExpressMapper" }
            };

            FrameworkTypeDic = new Dictionary<string, string>
            {
                { FrameworkType.NetCoreFramework.ToString(), null },
                { FrameworkType.NetFramework.ToString(), null }
            };

            ArchitectureDesignDic = new Dictionary<string, string>
            {
                { ArchitectureDesign.UnionLayerArchitecture.ToString(), null },
                { ArchitectureDesign.TraditionalLayerArchitecture.ToString(), null }
            };
        }
        
        public static string GetTypeValue(string value, Type type)
        {
            switch(type)
            {
                case Type.ORMType:
                    return ORMTypeDic.First(x => x.Key == value).Value;
                    
                case Type.IOCType:
                    return IOCTypeDic.First(x => x.Key == value).Value;

                case Type.MapperType:
                    return MapperTypeDic.First(x => x.Key == value).Value;

                case Type.FrameworkType:
                    return FrameworkTypeDic.First(x => x.Key == value).Value;

                case Type.ArchitectureDesign:
                    return ArchitectureDesignDic.First(x => x.Key == value).Value;

                default:
                    return null;
            }
        }
    }
}
