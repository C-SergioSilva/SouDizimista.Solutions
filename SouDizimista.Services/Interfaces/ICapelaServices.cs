using SouDizimista.Services.ServicesEntity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SouDizimista.Services.Interfaces
{
    public interface ICapelaServices
    {
        Task AddSave(ServiceCapela dto);
        Task<IEnumerable<ServiceCapela>> GetAll();
        Task<ServiceCapela> Update(ServiceCapela dto);
        Task MarkAsDeleted(Guid? id);
        Task<ServiceCapela> GetById(Guid id);
    }
}
