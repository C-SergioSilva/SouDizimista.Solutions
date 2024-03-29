﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SouDizimista.Services.ServicesEntity;
using SouDizimista.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace SouDizimista.WebApp.Controllers
{
    public class DizimistaController : Controller
    {
        //protected readonly IDizimistaServices services;
        //protected readonly IEnderecoServices servicesEndereco; 
        //public DizimistaController(IDizimistaServices services, IEnderecoServices servicesEndereco)
        //{
        //   this.services = services;  
        //   this.servicesEndereco = servicesEndereco;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAllDizimista()  
        {
            try
            {
                return View("ListAllDizimista");
            }
            catch (Exception exception) 
            {

                throw new Exception(exception.Message, exception);
            }
             
        }

        public IActionResult AddDizimista() 
        { 
            return View("AdicionaDizimista");
        }


        //public  ActionResult ObterDizimistas(Guid id)
        //{
        //    try
        //    {
        //        var dizimista = services.ObterInformacoesDizimistasComEndereco(id);
        //        return View(dizimista);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //// GET: DizimistaController/Create
        //public ActionResult NewDizimista()
        //{

        //    return View();
        //}

        //// POST: DizimistaController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]   
        //public async Task<IActionResult> NewDizimista(ServiceDizimista dizimista)
        //{
        //    try
        //    {
        //        await services.AddSave(dizimista);
        //        return RedirectToAction(nameof(GetAllDizimista));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: DizimistaController/Edit/5
        //public async Task<IActionResult> EditDizimista(Guid id)
        //{
        //    try
        //    {
        //        var dizimista =  await services.GetById(id);
        //        return View(dizimista);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
         
        //}

        //// POST: DizimistaController/Edit/5 
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> EditDizimista(ServiceDizimista dizimista)
        //{
        //    try
        //    {
        //        var dizimistaAtualizado = await services.Update(dizimista); 
        //        return View(dizimista);
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //public async Task<IActionResult> ConsultDizimista(Guid id) 
        //{
        //    try
        //    {
        //        var dizimista = await services.GetById(id);
        //        return View(dizimista);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
             
        //}

        //// GET: DizimistaController/Delete/5
        //public async Task<IActionResult> Delete(Guid id)
        //{
        //    try
        //    {
        //        var dizimista = await services.GetById(id);
        //        return View(dizimista);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message);
        //    }

        //}

        //// POST: DizimistaController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Delete(ServiceDizimista dizimista) 
        //{
        //    try
        //    {
        //        await services.MarkAsDeleted(dizimista.Id);
        //        return RedirectToAction(nameof(GetAllDizimista));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
