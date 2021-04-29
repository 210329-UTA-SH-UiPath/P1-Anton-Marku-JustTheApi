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
    public class ToppingController : ControllerBase
    {
        private readonly IRepository<Topping> _repository;

        public ToppingController(IRepository<Topping> repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public List<Topping> GetAll()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public Topping GetOne(int id)
        {
            return _repository.GetOne(id);
        }
    }
}
