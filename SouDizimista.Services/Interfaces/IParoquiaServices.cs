using SouDizimista.Services.ServicesEntity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SouDizimista.Services.Interfaces
{
    public interface IParoquiaServices
    { 
        Task AddSave(ServiceParoquia dto);
        Task<IEnumerable<ServiceParoquia>> GetAll();
        Task<ServiceParoquia> Update(ServiceParoquia dto);
        Task MarkAsDeleted(Guid id);
        Task<ServiceParoquia> GetById(Guid id);
    }
}
