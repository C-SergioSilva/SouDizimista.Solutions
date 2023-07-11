using SouDizimista.Domain.Entities;
using SouDizimista.Domain.Interfaces;
using SouDizimista.Repository.ContextDB;

namespace SouDizimista.Repository.Repositories
{
    public class CapelaRepository : RepositoryBase<Capela>, ICapelaRepository
    {
        public CapelaRepository(Context context) : base(context){}
    }
}
