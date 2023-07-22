using AutoMapper;
using SouDizimista.Domain;
using SouDizimista.Domain.Interfaces;
using SouDizimista.Services.Interfaces;
using SouDizimista.Services.ServicesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            this.repository = repository;   
        }

        public async Task AddSave(ServiceEndereco serviceEndereco)
        {
            try
            {
                var endereco = mapper.Map<Endereco>(serviceEndereco);
                await repository.AddSave(endereco);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<ServiceEndereco>> GetAll()
        {
            try
            {
                var enderecos = await repository.GetAll();
                var listEnderecos = mapper.Map<IEnumerable<ServiceEndereco>>(enderecos);
                return listEnderecos;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
          
        }

        public async Task<ServiceEndereco> GetById(Guid id)
        {
            try
            {
                var endereco = await repository.GetById(id);
                var serviceEndereco = mapper.Map<ServiceEndereco>(endereco);
                return serviceEndereco;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task MarkAsDeleted(Guid? id)
        {
            var endereco = await repository.GetById(id);
            endereco.Deleted = true;
            await repository.MarkDeleted(endereco);
        }

        public async Task<ServiceEndereco> Update(ServiceEndereco serviceEndereco)
        {
            var endereco = mapper.Map<Endereco>(serviceEndereco);
            var enderencoService = await repository.Update(endereco);
            var enderecoServ = mapper.Map<ServiceEndereco>(enderencoService);
            return enderecoServ;
        }
    }
}
