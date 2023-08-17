using SouDizimista.Domain.Guids;

namespace SouDizimista.Domain.Entities
{
    public class Usuario : EntityGuid
    {
        public string NomeUsuario { get; set; }  
        public string SenhaUsuario { get; set; }
        public string EmailUsuario { get; set; }
    }
}
