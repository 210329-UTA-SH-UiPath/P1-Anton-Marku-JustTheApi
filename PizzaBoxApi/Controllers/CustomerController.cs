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
    public class CustomerController : ControllerBase
    {
        private readonly IRepository<Customer> _repository;

        public CustomerController(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public void Add([FromBody]Customer Customer)
        {
            _repository.Add(Customer);
        }

        [HttpGet("{name}")]
        public Customer GetOne(string name)
        {
            return _repository.GetOne(name);
        }

        [HttpGet]
        public List<Customer> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
