using System;

namespace SouDizimista.Services.ServicesEntity
{
    public class ServicesUsuario
    {
        public Guid Id { get; set; }
        public Guid? EnderecoId { get; set; }
        public string NomeUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public string EmailUsuario { get; set; }

        public ServiceEndereco Endereco { get; set; }
    }
}
