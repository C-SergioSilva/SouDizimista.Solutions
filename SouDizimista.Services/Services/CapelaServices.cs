﻿using AutoMapper;
using SouDizimista.Domain.Entities;
using SouDizimista.Domain.Interfaces;
using SouDizimista.Services.ServicesEntity;
using SouDizimista.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouDizimista.Services.Services
{
    public class CapelaServices : ICapelaServices
    {
        protected readonly IMapper mapper;
        protected readonly ICapelaRepository repository;

        public CapelaServices(ICapelaRepository repository, IMapper mapper)
        {
            this.mapper = mapper;
            this.repository = repository;
        }
        public async Task AddSave(ServiceCapela capela)
        {
            try
            {
                var capelaEntitie = mapper.Map<Capela>(capela);
                await repository.AddSave(capelaEntitie);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<ServiceCapela>> GetAll()
        {
            try
            {
                var listCapelaEntitie = await repository.GetAll();
                var listCapelas = mapper.Map<IEnumerable<ServiceCapela>>(listCapelaEntitie);
                return listCapelas;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<ServiceCapela> GetById(Guid id)
        {
            try
            {
                var capelaEntitie = await repository.GetById(id);
                var capela = mapper.Map<ServiceCapela>(capelaEntitie);
                return capela;
            }
            catch (Exception  ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        public async Task MarkAsDeleted(Guid? id)
        {
            try
            {
                var capela = await repository.GetById(id);
                capela.Deleted = true;
                await repository.MarkDeleted(capela);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<ServiceCapela> Update(ServiceCapela capelaDto)
        {
            try
            {
                var capelaEntitie = mapper.Map<Capela>(capelaDto);
                var capelaUpdated = await repository.Update(capelaEntitie);
                var capela = mapper.Map<ServiceCapela>(capelaUpdated);
                return capela;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    }
}
