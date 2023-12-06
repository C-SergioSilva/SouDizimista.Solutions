using SouDizimista.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouDizimista.Domain.Interfaces
{
    public interface IMenuModuloRepository : IRepositoryBase<MenuItem>
    {
       List<MenuItem> GetMenuItems(string items);
    }
}
