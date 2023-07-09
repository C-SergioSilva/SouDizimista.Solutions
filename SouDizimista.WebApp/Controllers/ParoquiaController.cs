using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SouDizimista.Services.DTO;
using SouDizimista.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace SouDizimista.WebApp.Controllers
{
    public class ParoquiaController : Controller
    {
        private readonly IParoquiaServices serviceParoqauia;

        public ParoquiaController(IParoquiaServices serviceParoqauia)
        {
            this.serviceParoqauia = serviceParoqauia;
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
                var paroquias = await serviceParoqauia.GetAll();
                return View(paroquias);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        } 

        public async Task<IActionResult> GetParoquia(Guid id)
        {
            try
            {
                var paroquia = await serviceParoqauia.GetById(id);
                return View(paroquia);  

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message) ;
            }
        }

        // GET: ParoquiaController/Details/5
        public async Task<IActionResult> DetailsParoquia(Guid id)
        {
            try
            {
                var paroquia = await serviceParoqauia.GetById(id);
                return View(paroquia);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        // GET: ParoquiaController/Create
        public ActionResult CreateParoquia()
        {
            return View(); 
        }

        // POST: ParoquiaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateParoquia(ParoquiaDTO paroquia)
        {
            try
            { 
                if (paroquia.Id == Guid.Empty)
                {
                    await serviceParoqauia.AddSave(paroquia);
                }
                else
                {
                    await serviceParoqauia.Update(paroquia);
                }
                return RedirectToAction(nameof(GetAllParoquia));
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // GET: ParoquiaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ParoquiaController/Edit/5
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

        // GET: ParoquiaController/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var paroquia = await serviceParoqauia.GetById(id);
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
        public async Task<IActionResult> Delete(ParoquiaDTO paroquia)
        {
            try
            {
                await serviceParoqauia.MarkAsDeleted(paroquia.Id);
                return RedirectToAction(nameof(GetAllParoquia));
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
