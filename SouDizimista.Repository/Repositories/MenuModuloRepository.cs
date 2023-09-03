using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SouDizimista.Domain.Entities;
using SouDizimista.Domain.Interfaces;
using SouDizimista.Repository.ContextDB;
using System.Collections.Generic;
using System.Linq;

namespace SouDizimista.Repository.Repositories
{
    public class MenuModuloRepository : RepositoryBase<MenuItem>, IMenuModuloRepository
    {
        public MenuModuloRepository(Context context) : base(context){}

        public List<MenuItem> GetMenuItems(string items)
        {
            var query = @" select 
                           [Id]
                          ,[Controller]
                          ,[Action]
                          ,[Icon]
                          ,[Title]
                          ,[CreateAt]
                          ,[Deleted]
                           from ModuloMenu 
                           Where Controller = @items";
            var returnQuery = context.MenuItems.FromSqlRaw(query, new SqlParameter("@items", items)).ToList();
            return returnQuery;
        }
    }
}
