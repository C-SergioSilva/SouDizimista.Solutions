using SouDizimista.Domain.Entities;
using SouDizimista.Domain.Interfaces;
using SouDizimista.Repository.ContextDB;

namespace SouDizimista.Repository.Repository
{
    public class EnderecoRepository : RepositoryBase<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(Context context) : base(context){}
    }
}
