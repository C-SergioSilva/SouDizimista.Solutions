using SouDizimista.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouDizimista.Domain.Interfaces
{
    public interface IEnderecoRepository : IRepositoryBase<Endereco>
    {
        Task<Endereco> AddSaveEndereco(Endereco endereco);
    }
}
