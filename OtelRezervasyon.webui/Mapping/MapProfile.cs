using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtelRezervasyon.webui.Mapping
{
    public class MapProfile : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ListServiceDto, Service>
        }
    }
}