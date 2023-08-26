using AutoMapper;
using SouDizimista.Domain.Entities;
using SouDizimista.Domain.Interfaces;
using SouDizimista.Services.Interfaces;
using SouDizimista.Services.ServicesEntity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SouDizimista.Services.Services
{
    public class UsuarioServices : IUsuarioServices
    {
        protected readonly IMapper mapper;
        protected readonly IUsuarioRepository userRepos;
        protected readonly IEnderecoRepository endRepos;

        public UsuarioServices(IMapper mapper, IUsuarioRepository dizimistaRepository, IEnderecoRepository enderecoRepository)
        {
            this.mapper = mapper;
            this.userRepos = dizimistaRepository;
            this.endRepos = enderecoRepository;
        }

        public async Task AddSave(ServicesUsuario usuario)
        {
            var user = mapper.Map<Usuario>(usuario);
            await userRepos.AddSave(user);
        }

        public async Task<IEnumerable<ServicesUsuario>> GetAll()
        {
            var users = await userRepos.GetAll();
            var returnUsers = mapper.Map<IEnumerable<ServicesUsuario>>(users);
            return returnUsers;
        }

        public async Task<ServicesUsuario> GetById(Guid id)
        {
            var user = await userRepos.GetById(id);
            var returnUser = mapper.Map<ServicesUsuario>(user);
            return returnUser;
        }

        public async Task MarkAsDeleted(Guid? id)
        {
            if (id != null)
            {
                var user = await userRepos.GetById(id);
                user.Deleted = true;
                await userRepos.MarkDeleted(user);

            }
        }

        public async Task<ServicesUsuario> Update(ServicesUsuario usuario)
        {
            var user = mapper.Map<Usuario>(usuario);
            var returnUserRepos =  await userRepos.Update(user);
            var userReturn = mapper.Map<ServicesUsuario>(returnUserRepos);
            return userReturn;
        }
    }
}
