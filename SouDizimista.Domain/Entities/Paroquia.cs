using SouDizimista.Domain.Guids;
using System;

namespace SouDizimista.Domain.Entities
{
    public class Paroquia : EntityGuid
    {
        public string Cnpj { get; set; }
        public string NomeParoco { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }

    }
}
