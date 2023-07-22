using AutoMapper;
using SouDizimista.Domain.Entities;
using SouDizimista.Domain.Interfaces;
using SouDizimista.Services.ServicesEntity;
using SouDizimista.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SouDizimista.Services.Services
{
    public class DizimistaServices : IDizimistaServices
    {
        protected readonly IMapper mapper;
        protected readonly IDizimistaRepository dizimistaRepository;
        //protected readonly IEnderecoRepository enderecoRepository;

        public DizimistaServices(IMapper mapper, IDizimistaRepository repository)
        {
            this.mapper = mapper;
            this.dizimistaRepository = repository;
        }

        public async Task AddSave(ServiceDizimista dizimista)
        {
            try
            {
                var entityDizimista = mapper.Map<Dizimista>(dizimista);
                await dizimistaRepository.AddSave(entityDizimista);
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);
            }
        }

        public async Task<IEnumerable<ServiceDizimista>> GetAll()
        {

            try
            {
                var entityDizimista = await dizimistaRepository.GetAll();
                var dtoDizimista = mapper.Map<IEnumerable<ServiceDizimista>>(entityDizimista);
                return dtoDizimista;
                
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);
            }
        }

        public async Task<ServiceDizimista> GetById(Guid id)
        {

            try
            {
                var entityDizimista = await dizimistaRepository.GetById(id);
                var dtoDizimista = mapper.Map<ServiceDizimista>(entityDizimista);
                return dtoDizimista;
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);
            }
        }

        public async Task MarkAsDeleted(Guid? id)
        {

            try
            {
                if(id != null)
                {
                    var entityDizimista = await dizimistaRepository.GetById(id);
                    entityDizimista.Deleted = true;
                    await dizimistaRepository.MarkDeleted(entityDizimista);
                }

            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);
            }
        }

        public async Task<ServiceDizimista> Update(ServiceDizimista dizimista)
        {

            try
            {
                var entityDizimista = mapper.Map<Dizimista>(dizimista);
                var dtoDizimista =  await dizimistaRepository.Update(entityDizimista);
                var dizimistaDto = mapper.Map<ServiceDizimista>(dtoDizimista);
                return dizimista;
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);
            }
        }
    }
}
