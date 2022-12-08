using AutoMapper;
using SouDizimista.Domain.Entities;
using SouDizimista.Domain.Interfaces;
using SouDizimista.Services.DTO;
using SouDizimista.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SouDizimista.Services.Services
{
    public class EnderecoServices : IEnderecoServices
    {
        protected readonly IMapper mapper;
        protected readonly IEnderecoRepository repository;
        public EnderecoServices(IMapper mapper, IEnderecoRepository repository)
        {
            this.mapper = mapper;
            this.repository= repository;
        }
        public async Task AddSave(EnderecoDTO endereco)
        {
            try
            {
                var enttiyEnderco = mapper.Map<Endereco>(endereco);
                await repository.AddSave(enttiyEnderco);
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);
            }
          
        }
        public async Task<IEnumerable<EnderecoDTO>> GetAll()
        {
            try
            {
                var listEndereco = await repository.GetAll();
                var listEnderecoDTO = mapper.Map<IEnumerable<EnderecoDTO>>(listEndereco);
                return listEnderecoDTO;
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);
            }
        }
        public async Task<EnderecoDTO> GetById(Guid id)
        {
            try
            {
                var enderecoEntity = await repository.GetById(id);
                var enderecoDTO = mapper.Map<EnderecoDTO>(enderecoEntity);
                return enderecoDTO;
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);
            }
        }
        public async Task MarkAsDeleted(Guid id)
        {
            try
            {
                var enderecoEntity = await repository.GetById(id);
                enderecoEntity.Deleted = true;
                await repository.MarkDeleted(enderecoEntity);

            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);
            }
        }
        public async Task<EnderecoDTO> Update(EnderecoDTO endereco)
        {
            try
            {
                 var enderecoEntity = mapper.Map<Endereco>(endereco);
                 var endcoEntity =  await repository.Update(enderecoEntity);
                 var enderecoDTO = mapper.Map<EnderecoDTO>(endcoEntity);
                return enderecoDTO;
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);
            }
        }
    }
}
