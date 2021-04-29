using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaBoxApi.Models;
using PizzaBoxApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderPizzaController : ControllerBase
    {
        private readonly IRepository<OrderPizza> _repository;

        public OrderPizzaController(IRepository<OrderPizza> repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public List<OrderPizza> GetAllById(int id)
        {
            return _repository.GetAllById(id);
        }

        [HttpDelete("{id}")]
        public void DeleteOne(int id)
        {
            _repository.DeleteOne(id);
        }

        [HttpPost]
        public void Add([FromBody] OrderPizza item)
        {
            _repository.Add(item);
        }

        [HttpGet]
        public List<OrderPizza> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
