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

        public IActionResult Index()
        {
            return View();
        }

        // GET: DizimistaController
        public async Task<IActionResult> GetAllDizimista()  
        {
            try
            {
                var listDizimistas = await services.GetAll();
                return View(listDizimistas);
            }
            catch (Exception)
            {

                throw;
            }
             
        }

        // GET: DizimistaController/Details/5
        public async Task<IActionResult> GetDizmista(Guid id) 
        {
            try
            {
                var dizimista = await services.GetById(id);
                return View(dizimista);
            }
            catch (Exception)
            {

                throw;
            }
            
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
        public async Task<IActionResult> EditDizimista(Guid id)
        {
            try
            {
                var dizimista = await services.GetById(id);


                return View(dizimista);
            }
            catch (Exception)
            {

                throw;
            }
         
        }

        // POST: DizimistaController/Edit/5 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditDizimista(DizimistaDTO dizimista)
        {
            try
            {
                var dizimistaAtualizado = await services.Update(dizimista); 
                return View(dizimista);
            }
            catch
            {
                return View();
            }
        }

        public async Task<IActionResult> ConsultDizimista(Guid id) 
        {
            try
            {
                var dizimista = await services.GetById(id);
                return View(dizimista);
            }
            catch (Exception)
            {

                throw;
            }
             
        }

        // GET: DizimistaController/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var dizimista = await services.GetById(id);
                return View(dizimista);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        // POST: DizimistaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(DizimistaDTO dizimista) 
        {
            try
            {
                await services.MarkAsDeleted(dizimista.Id);
                return RedirectToAction(nameof(GetAllDizimista));
            }
            catch
            {
                return View();
            }
        }
    }
}
