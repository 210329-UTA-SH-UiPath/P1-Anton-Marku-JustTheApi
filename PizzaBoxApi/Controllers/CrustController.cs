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
    public class CrustController : ControllerBase
    {
        private readonly IRepository<Crust> _repository;

        public CrustController(IRepository<Crust> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public List<Crust> GetAll()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public Crust GetOne(int id)
        {
            return _repository.GetOne(id);
        }




























        [HttpPost]
        public async Task<ActionResult<Crust>> Post([FromBody] Crust book)
        {
            var newBook = await _repository.Create(book);
            return CreatedAtAction(nameof(GetOne), new { id = newBook.Id }, newBook);
        }

        [HttpPut]
        public async Task<ActionResult> Put(int id, [FromBody] Crust book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }
            await _repository.Update(book);
            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var itemToDelete = await _repository.Get(id);
            if (itemToDelete == null)
            {
                return NotFound();
            }
            await _repository.Delete(itemToDelete.Id);
            return NoContent();
        }
    }
}
