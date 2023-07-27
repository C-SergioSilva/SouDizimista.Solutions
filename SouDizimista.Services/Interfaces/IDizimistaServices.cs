using SouDizimista.Services.ServicesEntity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SouDizimista.Services.Interfaces
{
    public interface IDizimistaServices
    {
        Task AddSave(ServiceDizimista dto);
        Task<IEnumerable<ServiceDizimista>> GetAll();
        Task<ServiceDizimista> Update(ServiceDizimista dto);
        Task MarkAsDeleted(Guid? id);
        Task<ServiceDizimista> GetById(Guid id);
        List<ServiceDizimista> ObterInformacoesDizimistasComEndereco(Guid id);
    }
}
