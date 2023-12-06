using SouDizimista.Services.ServicesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouDizimista.Services.Interfaces
{
    public interface IUsuarioServices
    {
        Task AddSave(ServicesUsuario usuario);
        Task<IEnumerable<ServicesUsuario>> GetAll();
        Task<ServicesUsuario> Update(ServicesUsuario usuario);
        Task MarkAsDeleted(Guid? id);
        Task<ServicesUsuario> GetById(Guid id);
    }
}
