using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test111_aangular.Data.Repository
{
    public class Repo<TDbContext> : IRepo where TDbContext : ApplicationDbContext
    {
        protected TDbContext dbContext;

        public Repo(TDbContext context)
        {
            dbContext = context;
        }

/// <summary>
/// insert
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="entity"></param>
/// <returns></returns>
        public async Task CreateAsync<T>(T entity) where T : class
        {
            this.dbContext.Set<T>().Add(entity);
             await this.dbContext.SaveChangesAsync();
        }



        public async Task DeleteAsync<T>(T entity) where T : class
        {
            this.dbContext.Set<T>().Remove(entity);
            await this.dbContext.SaveChangesAsync();
        }


        public async Task<List<T>> SelectAll<T>() where T : class
        {
            return await this.dbContext.Set<T>().ToListAsync();
        }

        public Task<T> SelectById<T>(long id) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
