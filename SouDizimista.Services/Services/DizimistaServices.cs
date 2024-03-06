using AutoMapper;
using SouDizimista.Domain.Entities;
using SouDizimista.Domain.Interfaces;
using SouDizimista.Services.ServicesEntity;
using SouDizimista.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SouDizimista.Services.Services
{
    public class DizimistaServices : IDizimistaServices
    {
        protected readonly IMapper mapper;
        protected readonly IDizimistaRepository dizimistaRepository;
        protected readonly IEnderecoRepository enderecoRepository;

        public DizimistaServices(IMapper mapper, IDizimistaRepository repository, IEnderecoRepository enderecoRepository)
        {
            this.mapper = mapper;
            this.dizimistaRepository = repository;
            this.enderecoRepository = enderecoRepository;   
        }

        public async Task AddSave(ServiceDizimista dizimista)
        {
            try
            {
                var entityDizimista = mapper.Map<CADDizimista>(dizimista);
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
                var entityDizimista = await dizimistaRepository.Queryable().Include(d => d.Endereco).FirstOrDefaultAsync(w => w.Id.Equals(id));
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
                var enderecoDizimistaID = await dizimistaRepository.GetById(dizimista.Id);

                #region [Obtem o dizimista.Endereco.Id do Endereco na tabela Dizimista Para que seja atualizado o novo Endereço na Tabela Endereco ]

                  dizimista.Endereco.Id = enderecoDizimistaID.EnderecoId;
                  var AtualizaEndereco = mapper.Map<Endereco>(dizimista.Endereco);
                  var EnderecoAtualizado = await enderecoRepository.Update(AtualizaEndereco);

                #endregion

                #region [Obtem O dizimista.EnderecoId é obtido na Tabela Dizimista para poder atualizar o Dizimista ]

                  dizimista.EnderecoId = enderecoDizimistaID.EnderecoId;
                  var entityDizimista = mapper.Map<CADDizimista>(dizimista);
                  var dtoDizimista = await dizimistaRepository.Update(entityDizimista);
                  var dizimistaDto = mapper.Map<ServiceDizimista>(dtoDizimista);

                #endregion

                return dizimista;
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);
            }
        }

        public List<ServiceDizimista> ObterInformacoesDizimistasComEndereco(Guid id)
        {
            var ListDizimistaEndereco = dizimistaRepository.ObterInformacoesDizimistasComEndereco(id);
            var listDizimistaEnderecoServ = mapper.Map<List<ServiceDizimista>>(ListDizimistaEndereco);
            return listDizimistaEnderecoServ;

        }
    }
}
