using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SouDizimista.Services.ServicesEntity;
using SouDizimista.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace SouDizimista.WebApp.Controllers
{
    public class ParoquiaController : Controller
    {
        private readonly IParoquiaServices paroquiaService;

        public ParoquiaController(IParoquiaServices paroquiaService)
        {
            this.paroquiaService = paroquiaService;
        }
        // GET: ParoquiaController
        public ActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetAllParoquia()
        {
            try
            {
                var paroquias = await paroquiaService.GetAll();
                return View(paroquias);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        } 

        public async Task<IActionResult> GetParoquiaById(Guid id) 
        {
            try
            {
                var paroquia = await paroquiaService.GetById(id);
                return View(paroquia);  

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message) ;
            }
        }

        // GET: ParoquiaController/Details/5
        public async Task<IActionResult> ConsultParoquia(Guid id) 
        {
            try
            {
                var paroquia = await paroquiaService.GetById(id);
                return View(paroquia);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        // GET: ParoquiaController/Create
        public ActionResult NewParoquia() 
        {
            return View(); 
        }

        // POST: ParoquiaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NewParoquia(ServiceParoquia paroquia) 
        {
            try
            { 
                if (paroquia.Id == Guid.Empty)
                {
                    await paroquiaService.AddSave(paroquia);
                }
                else
                {
                    await paroquiaService.Update(paroquia);
                }
                return RedirectToAction(nameof(GetAllParoquia));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        // GET: ParoquiaController/Edit/5
        public async Task<IActionResult> EditParoquia(Guid id) 
        {
            try
            {
                var paroquia = await paroquiaService.GetById(id);
                return View(paroquia);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        // POST: ParoquiaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ServiceParoquia serviceparoquia)
        {
            try
            {
                var paroquia = await paroquiaService.Update(serviceparoquia);
                return View(paroquia);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        // GET: ParoquiaController/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var paroquia = await paroquiaService.GetById(id);
                return View(paroquia);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        // POST: ParoquiaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(ServiceParoquia paroquia)
        {
            try
            {
                await paroquiaService.MarkAsDeleted(paroquia.Id);
                return RedirectToAction(nameof(GetAllParoquia));
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
