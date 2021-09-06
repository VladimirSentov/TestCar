using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test111_aangular.Data.Repository;
using test111_aangular.Models;

namespace test111_aangular.Controllers
{
    [ApiController]
    [Route("car")]
    public class CarController : ControllerBase
    {
        private readonly IRepo _carRepo;
        public CarController(IRepo carRepo)
        {
            _carRepo = carRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<Car>> GetAll()
        {
            return await _carRepo.SelectAll<Car>();
        }



    }
}
