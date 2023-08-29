using Microsoft.AspNetCore.Mvc;
using SouDizimista.Services.Interfaces;

namespace SouDizimista.WebApp.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuService menuService;

        public MenuController(IMenuService menuService)
        {
            this.menuService = menuService;
        }

        [HttpPost]
        public ActionResult GetMenuItems(string module)
        {
            var menuItems = menuService.GetMenuItems(module);

            // Renderiza a view parcial '_MenuItemsPartial' com os itens de menu
            return PartialView("_MenuItemsPartial", menuItems);
        }

    }
}
