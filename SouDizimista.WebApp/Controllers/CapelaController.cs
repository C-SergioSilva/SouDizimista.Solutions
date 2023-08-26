using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SouDizimista.WebApp.Controllers
{
    public class CapelaController : Controller
    {
        // GET: CapelaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CapelaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CapelaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CapelaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CapelaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CapelaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CapelaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CapelaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
