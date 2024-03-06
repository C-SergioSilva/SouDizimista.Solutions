using SouDizimista.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SouDizimista.Domain.Interfaces
{
    public interface IDizimistaRepository : IRepositoryBase<CADDizimista>
    {
        List<CADDizimista> ObterInformacoesDizimistasComEndereco(Guid id);
    }
}
