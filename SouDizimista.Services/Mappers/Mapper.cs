using AutoMapper;
using SouDizimista.Domain.Entities;
using SouDizimista.Services.DTO;

namespace SouDizimista.Services.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Paroquia, ParoquiaDTO>().ReverseMap();
            CreateMap<Dizimista, DizimistaDTO>().ReverseMap();
            CreateMap<Capela, CapelaDTO>().ReverseMap();
        }
    }
}
