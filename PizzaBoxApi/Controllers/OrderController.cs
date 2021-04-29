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
    public class OrderController : ControllerBase
    {
        private readonly IRepository<Order> _repository;

        public OrderController(IRepository<Order> repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public void Add([FromBody] Order Order)
        {
            _repository.Add(Order);
        }

        [HttpPut("{id}/{price}")]
        public void IncreasePrice(int id, double price)
        {
            _repository.IncreasePrice(id, price);
        }

        [HttpGet]
        public List<Order> GetAll()
        {
            return _repository.GetAll();
        }

    }
}
