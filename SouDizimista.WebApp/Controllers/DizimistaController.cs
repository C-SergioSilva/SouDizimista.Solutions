using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SouDizimista.Services.DTO;
using SouDizimista.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace SouDizimista.WebApp.Controllers
{
    public class DizimistaController : Controller
    {
        protected readonly IDizimistaServices services;
        public DizimistaController(IDizimistaServices services)
        {
           this.services = services;   
        }
        // GET: DizimistaController
        public async Task<IActionResult> GetAllDizimista()  
        {
            var listDizimistas = await services.GetAll();
            return View(listDizimistas); 
        }

        // GET: DizimistaController/Details/5
        public async Task<IActionResult> GetDizmista(Guid id) 
        {
            var dizimista = await services.GetById(id);
            return View(dizimista);
        }

        // GET: DizimistaController/Create
        public ActionResult NewDizimista()
        {
            return View();
        }

        // POST: DizimistaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
       
        public async Task<IActionResult> NewDizimista(DizimistaDTO dizimista)
        {
            try
            {
               await services.AddSave(dizimista);
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
