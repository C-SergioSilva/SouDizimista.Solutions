using SouDizimista.Domain.Guids;

namespace SouDizimista.Domain.Entities
{
    public class Endereco : EntityGuid
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
    }
}
