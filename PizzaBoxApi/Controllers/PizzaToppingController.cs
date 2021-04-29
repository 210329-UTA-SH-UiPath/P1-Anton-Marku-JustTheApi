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
    public class PizzaToppingController : ControllerBase
    {
        private readonly IRepository<PizzaTopping> _repository;

        public PizzaToppingController(IRepository<PizzaTopping> repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public void Add([FromBody] PizzaTopping item)
        {
            _repository.Add(item);
        }

        [HttpGet]
        public List<PizzaTopping> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
