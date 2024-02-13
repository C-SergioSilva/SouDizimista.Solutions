using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SouDizimista.Domain.Entities;
using SouDizimista.Domain.Interfaces;
using SouDizimista.Repository.ContextDB;
using System.Collections.Generic;
using System.Linq;

namespace SouDizimista.Repository.Repositories
{
    public class MenuModuloRepository : RepositoryBase<MenuItemLateral>, IMenuModuloRepository
    {
        public MenuModuloRepository(Context context) : base(context){}

        public List<MenuItemLateral> GetMenuItems(string items)
        {
            var query = @" select 
                           [Id]
                          ,[UrlModulo]
                          ,[Controller]
                          ,[Action]
                          ,[Icon]
                          ,[Title]
                          ,[CreateAt]
                          ,[Deleted]
                           from SEGModuloMenu 
                           Where UrlModulo = @items";
            var returnQuery = context.MenuItemLateral.FromSqlRaw(query, new SqlParameter("@items", items)).ToList();
            return returnQuery;
        }

        public List<MenuSuspenso> GetMenuSuspenso()  
        {
            var query = @"select
                           Id
                          ,NumeroFuncionalidade
                          ,[NomeFuncionalidade]
                          ,IDFuncionalidadePai
                          ,NumeroOrdenacaoFuncionalidade
                          ,[URLFuncionalidade]
                          ,[IndicadorAtivo]
                          ,[CreateAt]
                          ,[Deleted]
                           from SEGFuncionalidade where [IndicadorAtivo] = 1"; 
            var returnQuery = context.MenuSuspenso.FromSqlRaw(query).ToList();
            return returnQuery;
        }
    }
}
