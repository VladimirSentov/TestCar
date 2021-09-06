using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test111_aangular.Data.Repository
{
    public interface IRepo
    {
        Task<List<T>> SelectAll<T>() where T : class;
        Task<T> SelectById<T>(long id) where T : class;
        //Task<T> SelectByName<T>(long name) where T : class;
        Task CreateAsync<T>(T entity) where T : class;
        Task<T> UpdateAsync<T>(T entity) where T : class;
        Task DeleteAsync<T>(T entity) where T : class;
    }
}
