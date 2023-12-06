using AutoMapper;
using SouDizimista.Domain.Interfaces;
using SouDizimista.Services.Interfaces;
using SouDizimista.Services.ServicesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouDizimista.Services.Services
{
    public class MenuServices : IMenuService
    {
        protected readonly IMenuModuloRepository menuModuloRepository;
        protected readonly IMapper mapper;
        public MenuServices(IMenuModuloRepository menuModuloRepository, IMapper mapper)
        {
            this.menuModuloRepository = menuModuloRepository;
            this.mapper = mapper;
        }
        public List<ServiceMenuItem> GetMenuItems(string module)
        {
            try
            {
                var menus = menuModuloRepository.GetMenuItems(module);
                var menusItems = mapper.Map<List<ServiceMenuItem>>(menus);
                return menusItems;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message,ex);
            }
        }
    }
}
