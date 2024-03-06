using Microsoft.AspNetCore.Mvc;
using SouDizimista.Services.Interfaces;
using SouDizimista.Services.ServicesEntity;
using System;
using System.Threading.Tasks;

namespace Ajax.Contratcs.WebUI.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiDizimistaController : ControllerBase
    {
        protected readonly IDizimistaServices services;
        protected readonly IEnderecoServices servicesEndereco;
        public ApiDizimistaController(IDizimistaServices services, IEnderecoServices servicesEndereco) 
        {
            this.services = services;
            this.servicesEndereco = servicesEndereco;
        }

        [HttpPost]
        [Route("GetAllDizimista")]
        public async Task<IActionResult> GetAllDizimista()
        {
            try
            {
                var listDizimistas = await services.GetAll();
                return Ok(listDizimistas);
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpPost]
        [Route("AddDizimista")]
        public async Task<IActionResult> AddDizimista([FromBody] ServiceDizimista dizimista) 
        {
            #region [Exemplo de outra api]

            //var cnpjDTO = await clientService.GetCnpj(clientDto); 

            //if (clientDto.Id.HasValue)
            //{
            //    if(cnpjDTO != null) { 
            //    var clientUpdate =  await clientService.UpdateClient(clientDto);
            //        if (clientUpdate == null)
            //        {
            //            var cnpj = false;
            //            return Ok(cnpj);
            //        }
            //    }
            //    else
            //    {

            //        var cnpj = false;
            //        return Ok(cnpj);
            //    }
            //}
            //else
            //{
            //    if (cnpjDTO == null)
            //    {
            //        await clientService.SaveNewClient(clientDto);
            //    }
            //    else
            //    {
            //        var cnpj = true;
            //        return Ok(cnpj);
            //    }
            //}

            #endregion

            await services.AddSave(dizimista);
            return Ok();
        }

        //[HttpGet]
        //[Route("GetAddressByCnpj")]
        //public async Task<IActionResult> GetAddressByCnpj(string cnpj)
        //{
        //    try
        //    {
        //        //var addressCnpj = await clientService.GetCompanyByCnpj(cnpj);
        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message, ex);
        //    }

        //}

        //[HttpPost]
        //[Route("GetAllContractClient")]
        //public async Task<IActionResult> GetAllContractClient()
        //{
        //    var clientDto = await clientService.GetAllClient();
        //    return Ok(clientDto);
        //}
        //[HttpPost]
        //[Route("SaveClient")]
        //public async Task<IActionResult> SaveClient([FromBody] ClientDTO clientDto)
        //{

        //    var cnpjDTO = await clientService.GetCnpj(clientDto);

        //    if (clientDto.Id.HasValue)
        //    {
        //        if (cnpjDTO != null)
        //        {
        //            var clientUpdate = await clientService.UpdateClient(clientDto);
        //            if (clientUpdate == null)
        //            {
        //                var cnpj = false;
        //                return Ok(cnpj);
        //            }
        //        }
        //        else
        //        {

        //            var cnpj = false;
        //            return Ok(cnpj);
        //        }
        //    }
        //    else
        //    {
        //        if (cnpjDTO == null)
        //        {
        //            await clientService.SaveNewClient(clientDto);
        //        }
        //        else
        //        {
        //            var cnpj = true;
        //            return Ok(cnpj);
        //        }
        //    }
        //    return Ok();
        //}
        //[HttpGet]
        //[Route("GetClientById")]
        //public async Task<IActionResult> GetClientById(Guid Id)
        //{
        //    var clientDto = await clientService.GetClientById(Id);
        //    return Ok(clientDto);
        //}

        [HttpPost("MarkAsDeleted")]
        [Route("MarkAsDeleted/{id:Guid}")]
        public async Task<IActionResult> MarkAsDeleted([FromRoute] Guid Id)
        {
            await services.MarkAsDeleted(Id);
            return Ok();
        }

    }
}
