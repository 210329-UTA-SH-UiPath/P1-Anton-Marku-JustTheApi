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
    public class StoreController : ControllerBase
    {
        private readonly IRepository<Store> _repository;

        public StoreController(IRepository<Store> repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public List<Store> GetAll()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public Store GetOne(int id)
        {
            return _repository.GetOne(id);
        }

    }
}
