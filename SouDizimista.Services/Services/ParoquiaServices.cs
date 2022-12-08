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
    public class ParoquiaServices : IParoquiaServices
    {
        protected readonly IMapper mapper;
        protected readonly IParoquiaRepository repository;
        public ParoquiaServices(IParoquiaRepository repository,IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;   
        }
        public async Task AddSave(ParoquiaDTO paroquia)
        {
            try
            {
                var entity = mapper.Map<Paroquia>(paroquia);
                await repository.AddSave(entity);
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);
            }
            
        }
        public async Task<IEnumerable<ParoquiaDTO>> GetAll()
        {
            try
            {
                var listEntityParoquia = await repository.GetAll();
                var listDtoParoquia = mapper.Map<IEnumerable<ParoquiaDTO>>(listEntityParoquia);
                return listDtoParoquia;

            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);
            }
        }
        public async Task<ParoquiaDTO> GetById(Guid id)
        {
            try
            {
                var entityParoquia = await repository.GetById(id);
                var dtoParoquia = mapper.Map<ParoquiaDTO>(entityParoquia);
                return dtoParoquia;
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

                var entityParoquia = await repository.GetById(id);
                entityParoquia.Deleted = true;
                await repository.MarkDeleted(entityParoquia);
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message,exception);
            }
        }
        public async Task<ParoquiaDTO> Update(ParoquiaDTO paroquia)
        {
            try
            {
                var entityParoquia = mapper.Map<Paroquia>(paroquia);
                var paroquiaentity = await repository.Update(entityParoquia);
                var dtoParoquia = mapper.Map<ParoquiaDTO>(paroquiaentity);
                return dtoParoquia;
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);
            }
        }
    }
}
