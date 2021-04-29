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
    public class SizeController : ControllerBase
    {
        private readonly IRepository<Size> _repository;

        public SizeController(IRepository<Size> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public List<Size> GetAll()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public Size GetOne(int id)
        {
            return _repository.GetOne(id);
        }
    }
}
