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
    public class DizimistaServices : IDizimistaServices
    {
        protected readonly IMapper mapper;
        protected readonly IDizimistaRepository repository;

        public DizimistaServices(IMapper mapper, IDizimistaRepository repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        public async Task AddSave(DizimistaDTO dizimista)
        {
            try
            {
                var entityDizimista = mapper.Map<Dizimista>(dizimista);
                await repository.AddSave(entityDizimista);
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);
            }
        }

        public async Task<IEnumerable<DizimistaDTO>> GetAll()
        {

            try
            {
                var entityDizimista = await repository.GetAll();
                var dtoDizimista = mapper.Map<IEnumerable<DizimistaDTO>>(entityDizimista);
                return dtoDizimista;
                
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);
            }
        }

        public async Task<DizimistaDTO> GetById(Guid id)
        {

            try
            {
                var entityDizimista = await repository.GetById(id);
                var dtoDizimista = mapper.Map<DizimistaDTO>(entityDizimista);
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
                    var entityDizimista = await repository.GetById(id);
                    entityDizimista.Deleted = true;
                    await repository.MarkDeleted(entityDizimista);
                }

            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);
            }
        }

        public async Task<DizimistaDTO> Update(DizimistaDTO dizimista)
        {

            try
            {
                var entityDizimista = mapper.Map<Dizimista>(dizimista);
                var dtoDizimista =  await repository.Update(entityDizimista);
                var dizimistaDto = mapper.Map<DizimistaDTO>(dtoDizimista);
                return dizimista;
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);
            }
        }
    }
}
