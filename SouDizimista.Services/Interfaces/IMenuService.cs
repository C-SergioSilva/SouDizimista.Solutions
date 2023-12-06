using SouDizimista.Services.ServicesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouDizimista.Services.Interfaces
{
    public interface IMenuService
    {
        List<ServiceMenuItem> GetMenuItems(string module);
    }
}
