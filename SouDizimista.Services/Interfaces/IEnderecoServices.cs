using SouDizimista.Services.ServicesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouDizimista.Services.Interfaces
{
    public interface IEnderecoServices
    {
        Task AddSave(ServiceEndereco serviceEndereco); 
        Task<IEnumerable<ServiceEndereco>> GetAll();
        Task<ServiceEndereco> Update(ServiceEndereco serviceEndereco);
        Task MarkAsDeleted(Guid? id);
        Task<ServiceEndereco> GetById(Guid id);
    }
}
