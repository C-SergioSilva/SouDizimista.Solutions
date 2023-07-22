using SouDizimista.Domain.Guids;
using System;

namespace SouDizimista.Domain.Entities
{
    public class Dizimista : EntityGuid
    {
        public string Nome { get; set; }
        public decimal ValorDevolucao { get; set; }
        
        public Guid IDEndereco { get; set; }    
        public Endereco Endereco { get; set; }

    }
}
