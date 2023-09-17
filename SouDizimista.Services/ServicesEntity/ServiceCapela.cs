using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouDizimista.Services.ServicesEntity
{
    public class ServiceCapela
    {
        public Guid Id { get; set; }
        public string NomeParoco { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; } 
        public string Cnpj { get; set; }
         
        public Guid? EnderecoId { get; set; } 
        public ServiceEndereco Endereco { get; set; }
    }


}
