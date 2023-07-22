using SouDizimista.Domain;
using SouDizimista.Domain.Interfaces;
using SouDizimista.Repository.ContextDB;

namespace SouDizimista.Repository.Repositories
{
    public  class EnderecoRepository : RepositoryBase<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(Context context) : base(context){ }
    }
}
