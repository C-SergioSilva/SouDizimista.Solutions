using System;

namespace SouDizimista.Services.DTO
{
    public class DizimistaDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal ValorDevolucao { get; set; }
        public ParoquiaDTO Paroquia { get; set; }
        public Guid IdParoquia { get; set; }
        public EnderecoDTO Endereco { get; set; }
        public Guid IdEndereco { get; set; }
    }
}
