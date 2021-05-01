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
    public class PizzaController : ControllerBase
    {
        private readonly IRepository<Pizza> _repository;

        public PizzaController(IRepository<Pizza> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public List<Pizza> GetPresets()
        {
            return _repository.GetPresets();
        }

        [HttpGet("{id}")]
        public List<Pizza> GetAll(int id)
        {
            return _repository.GetAll();
        }

        [HttpPost]
        public void Post([FromBody] Pizza Pizza)
        {
            _repository.Add(Pizza);
        }
    }
}
