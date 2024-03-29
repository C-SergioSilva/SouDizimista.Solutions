﻿using SouDizimista.Domain.Entities;
using System;

namespace SouDizimista.Services.ServicesEntity
{
    public class ServiceParoquia
    {
        public Guid Id { get; set; }
        public string Cnpj { get; set; }
        public string NomeParoco { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }

        public Guid EnderecoId { get; set; }    
        public Endereco Endereco { get; set; }  

    }
}
