using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test111_aangular.Models;

namespace test111_aangular.Services
{
    public interface ICarService
    {
        Task<List<Car>> SelectAll();
        Task<Car> SelectById(long id);
        //Task<T> SelectByName<T>(long name) where T : class;
        Task CreateAsync(Car car);
        Task UpdateAsync(int Id,Car car );
        Task DeleteAsync(int Id);
    }
}
