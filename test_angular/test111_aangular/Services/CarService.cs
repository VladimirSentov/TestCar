using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test111_aangular.Data.Repository;
using test111_aangular.Models;

namespace test111_aangular.Services
{
    public class CarService : ICarService

    {
      

        public Task CreateAsync(Car car)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Car>> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Task<Car> SelectById(long id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int Id, Car car)
        {
            throw new NotImplementedException();
        }
    }
}
