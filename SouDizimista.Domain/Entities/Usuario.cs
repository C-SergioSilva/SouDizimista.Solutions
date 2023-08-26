using SouDizimista.Domain.Guids;
using System;

namespace SouDizimista.Domain.Entities
{
    public class Usuario : EntityGuid
    {
        public string NomeUsuario { get; set; }  
        public string SenhaUsuario { get; set; }
        public string EmailUsuario { get; set; }

        public Guid EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
    }
}
