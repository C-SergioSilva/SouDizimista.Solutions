using SouDizimista.Domain.Guids;
using System;

namespace SouDizimista.Domain.Entities
{
    public class Capela : EntityGuid
    {
        public string Nome {get; set;}
        public string Endereco { get; set;} 


        public Guid IdParoquia { get; set; }   
        public Paroquia Paroquia { get; set; }

    }
}
