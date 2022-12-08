using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SouDizimista.WebApp.Controllers
{
    public class DizimistaController : Controller
    {
        // GET: DizimistaController
        public ActionResult GetAllDizimista()  
        {
            return View();
        }

        // GET: DizimistaController/Details/5
        public ActionResult GetDizmista(int id) 
        {
            return View();
        }

        // GET: DizimistaController/Create
        public ActionResult NewDizimista()
        {
            return View();
        }

        // POST: DizimistaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NewDizimista(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(GetAllDizimista));
            }
            catch
            {
                return View();
            }
        }

        // GET: DizimistaController/Edit/5
        public ActionResult EditDizimista(int id)
        {
            return View();
        }

        // POST: DizimistaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(GetAllDizimista));
            }
            catch
            {
                return View();
            }
        }

        // GET: DizimistaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DizimistaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(GetAllDizimista));
            }
            catch
            {
                return View();
            }
        }
    }
}
