using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ProjectEF.Data.Contexts;
using ProjectEF.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEF.Data.Repositories
{
#pragma warning disable
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private StudentDbContext studentDbContext;

        private DbSet<T> dbSet { get; set; }

        public GenericRepository()
        {
            studentDbContext = new StudentDbContext();

            dbSet = studentDbContext.Set<T>();
        }
        public async Task<T> CreateAsync(T entity)
        {
            
           EntityEntry entry =  dbSet.Add(entity);
            studentDbContext.SaveChanges();
            return (T)entry.Entity;

        }

        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            var DelEnt = await dbSet.FirstOrDefaultAsync(predicate);
            if(DelEnt is null)
                return false;

            dbSet.Remove(DelEnt);
            studentDbContext.SaveChangesAsync();
            return true;
            
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await dbSet.FirstOrDefaultAsync(predicate);

        }

        public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            Expression<Func<T, bool>> pred = p => true;
            return  dbSet.Where(predicate ?? pred);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            studentDbContext.Update(entity);

            await studentDbContext.SaveChangesAsync();

            return entity;
        }
    }
}
