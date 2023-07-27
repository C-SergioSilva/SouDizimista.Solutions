﻿using SouDizimista.Domain.Entities;
using SouDizimista.Domain.Interfaces;
using SouDizimista.Repository.ContextDB;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.Data.SqlClient;

namespace SouDizimista.Repository.Repositories
{
    public class DizimistaRepository : RepositoryBase<Dizimista>, IDizimistaRepository
    {
        public DizimistaRepository(Context context) : base(context)
        {


        }

        public List<Dizimista> ObterInformacoesDizimistasComEndereco(Guid id)
        {
            var sql = @"
                      select
                      diz.Nome,
                      diz.ValorDevolucao,
                      edc.Logradouro,
                      edc.Numero,
                      edc.Complemento,
                      edc.Bairro,
                      edc.Cep,
                      edc.Estado,
                      edc.Municipio
                      from Dizimista as diz
                      join Endereco edc on edc.Id = diz.EnderecoId
                      where diz.Id = @id"; // Usamos o parâmetro @id na consulta

            var resultado = context.Dizimistas.FromSqlRaw(sql, new SqlParameter("@id", id)).ToList();
            return resultado;
        }

    }

}

