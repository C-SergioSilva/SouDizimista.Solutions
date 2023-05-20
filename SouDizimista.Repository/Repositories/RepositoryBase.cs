using Microsoft.EntityFrameworkCore;
using SouDizimista.Domain.Guids;
using SouDizimista.Domain.Interfaces;
using SouDizimista.Repository.ContextDB;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SouDizimista.Repository.Repositories 
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : EntityGuid
    {
        protected readonly Context context;
        protected DbSet<T> dbSet;
        public RepositoryBase(Context context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }
        public void Add(T item)
        {
            try
            {
                if (item.Id == Guid.Empty)
                {
                    item.Id = Guid.NewGuid();
                }
                dbSet.Add(item);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public async Task AddSave(T item)
        {
            try
            {
                if (item.Id == Guid.Empty)
                {
                    item.Id = Guid.NewGuid();
                }
                dbSet.Add(item);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
            
        }

        public async Task Commit()
        {
            try
            {
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> Delete(Guid Id)
        {
            try
            {
                var item = await dbSet.SingleOrDefaultAsync(d => d.Id.Equals(Id));
                if (item == null)
                    return false;
                else
                    context.Remove(item);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
            return true;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            try
            {
                return await dbSet.ToListAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<T> GetById(Guid? Id)
        {
            try
            {
                return await dbSet.SingleOrDefaultAsync(g => g.Id.Equals(Id));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public async Task MarkDeleted(T item)
        {
            try
            {
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<T> Update(T item)
        {
            try
            {
                var itemUpdate = await dbSet.SingleOrDefaultAsync(u => u.Id.Equals(item.Id));
                if (itemUpdate == null)
                    return null;
                else
                    context.Entry(itemUpdate).CurrentValues.SetValues(item);
                await context.SaveChangesAsync();


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

            return item;
        }
    }
}
