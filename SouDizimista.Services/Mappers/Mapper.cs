using AutoMapper;
using SouDizimista.Domain.Entities;
using SouDizimista.Services.ServicesEntity;

namespace SouDizimista.Services.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Paroquia, ServiceParoquia>().ReverseMap();
            CreateMap<CADDizimista, ServiceDizimista>().ReverseMap();
            CreateMap<Capela, ServiceCapela>().ReverseMap();
            CreateMap<Endereco, ServiceEndereco>().ReverseMap();
            CreateMap<MenuItem, ServiceMenuItem>().ReverseMap();
        }
    }
}
