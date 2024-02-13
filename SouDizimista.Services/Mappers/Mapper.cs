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
            CreateMap<Dizimista, ServiceDizimista>().ReverseMap();
            CreateMap<Capela, ServiceCapela>().ReverseMap();
            CreateMap<Endereco, ServiceEndereco>().ReverseMap();
            CreateMap<MenuItemLateral, ServiceMenuItem>().ReverseMap();
            CreateMap<MenuSuspenso, ServiceMenuSuspenso>().ReverseMap();
        }
    }
}
