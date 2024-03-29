﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SouDizimista.Services.ServicesEntity
{
    public class ServiceDizimista
    {
        public Guid? Id { get; set; }

        public Guid? EnderecoId { get; set; }

        [Required(ErrorMessage ="O Campo Nome é Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Número é obrigatório.")]
       // [RegularExpression(@"^\d+(,\d+){{2}}$", ErrorMessage = "O valor de devolução deve ser um número com casas decimais separadas por vírgula.")]
        public decimal ValorDevolucao { get; set; }

        [Display(Name = "cep")]
        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "CEP inválido. Informe no formato 00000-000.")]

        public ServiceEndereco Endereco { get; set; }

    }
}
