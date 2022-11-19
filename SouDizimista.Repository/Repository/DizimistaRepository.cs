using SouDizimista.Domain.Entities;
using SouDizimista.Domain.Interfaces;
using SouDizimista.Repository.ContextDB;

namespace SouDizimista.Repository.Repository
{
    public class DizimistaRepository : RepositoryBase<Dizimista>, IDizimistaRepository
    {
        public DizimistaRepository(Context context) : base(context){}
    }
}
