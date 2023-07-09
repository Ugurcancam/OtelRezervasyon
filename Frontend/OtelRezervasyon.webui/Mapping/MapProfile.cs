using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using OtelRezervasyon.Entity.Concrete;
using OtelRezervasyon.webui.Dtos.LoginDto;
using OtelRezervasyon.webui.Dtos.RegisterDto;
using OtelRezervasyon.webui.Dtos.Service;



namespace OtelRezervasyon.webui.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<ListServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<AddServiceDto, Service>().ReverseMap();
            CreateMap<NewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();
        }
    }
}