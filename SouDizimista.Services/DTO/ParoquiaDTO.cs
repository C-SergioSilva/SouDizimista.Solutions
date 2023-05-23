using System;

namespace SouDizimista.Services.DTO
{
    public class ParoquiaDTO
    {
        public Guid Id { get; set; }
        public string Cnpj { get; set; }
        public string NomeParoco { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
    }
}
