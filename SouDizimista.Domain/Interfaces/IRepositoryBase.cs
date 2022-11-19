using SouDizimista.Domain.Guids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouDizimista.Domain.Interfaces
{
    public interface IRepositoryBase<T> where T: EntityGuid
    {
        void Add(T item);
        Task AddSave(T item);
        Task<T> Update(T item);
        Task<T> GetById(Guid? item);
        Task<IEnumerable<T>> GetAll();
        Task<bool> Delete(Guid Id);
        Task MarkDeleted(T item);
        Task Commit();
    }
}
