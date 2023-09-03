using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SouDizimista.Domain.Entities;
using SouDizimista.Domain.Interfaces;
using SouDizimista.Repository.ContextDB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SouDizimista.Repository.Repositories
{
    public class DizimistaRepository : RepositoryBase<Dizimista>, IDizimistaRepository
    {
        public DizimistaRepository(Context context) : base(context){}

        public List<Dizimista> ObterInformacoesDizimistasComEndereco(Guid id)
        {
            var sql = @"
                      select
                      diz.Id,
                      diz.EnderecoId,
                      diz.CreateAt,
                      diz.Deleted,
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
            resultado.AsQueryable().Include(e => e.Endereco).FirstOrDefault(w => w.Id.Equals(id));
            return resultado;
        }

    }

}

