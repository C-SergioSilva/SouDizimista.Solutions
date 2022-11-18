using SouDizimista.Domain.Guids;
using System;

namespace SouDizimista.Domain.Entities
{
    public class Dizimista : EntityGuid
    {
        public string Nome { get; set; }
        public decimal ValorDevolucao { get; set; }
        public Paroquia Paroquia { get; set; }
        public Guid IdParoquia { get; set; }    
        public Endereco Endereco { get; set; }
        public Guid IdEndereco { get; set; }
    }
}
