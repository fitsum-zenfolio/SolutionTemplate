using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using AutoMapper;

[assembly: InternalsVisibleTo("$ext_projectname$.Tests.ManagerTests")]

namespace TemplateName.Managers
{
    internal static class DTOMapper
    {
        static IMapper _mapper;
        private static IConfigurationProvider _config;

        private static IMapper Mapper => _mapper ?? (_mapper = Configuration.CreateMapper());

        public static IConfigurationProvider Configuration
        {
            get
            {
                if (_config == null)
                {
                    var config = new AutoMapper.MapperConfiguration(cfg =>
                    {
                        // NOTE: CreateMap<Source, Destination>()
                        // ForMember(destination member, source mapping/member option)
                        //cfg.CreateMap<WebStoreCatalog, WSCatContract.WebStoreCatalog>()
                        //    .ForMember(a => a.Products, b => b.Ignore());
                    });
                    _config = config;
                }
                return _config;
            }
        }

        public static void Map(object source, object dest)
        {
            Mapper.Map(source, dest, source.GetType(), dest.GetType());
        }

        public static T Map<T>(object source)
        {
            return Mapper.Map<T>(source);
        }
    }
}
