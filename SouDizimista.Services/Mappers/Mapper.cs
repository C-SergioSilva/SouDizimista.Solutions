using AutoMapper;
using SouDizimista.Domain.Entities;
using SouDizimista.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouDizimista.Services.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Paroquia, ParoquiaDTO>().ReverseMap();
            CreateMap<Dizimista, DizimistaDTO>().ReverseMap();
        }
    }
}
