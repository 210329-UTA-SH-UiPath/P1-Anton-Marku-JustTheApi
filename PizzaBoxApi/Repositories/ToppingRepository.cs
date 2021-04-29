using Microsoft.EntityFrameworkCore;
using PizzaBoxApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxApi.Repositories
{
    public class ToppingRepository : IRepository<Topping>
    {
        private readonly PizzaBoxContext _context;
        public ToppingRepository(PizzaBoxContext context)
        {
            _context = context;
        }

        public List<Topping> GetAll()
        {
            return _context.Toppings.ToList();
        }

        public Topping GetOne(int id)
        {
            return _context.Toppings.Find(id);
        }




























        public Task<Topping> Create(Topping item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Topping>> Get()
        {
            return await _context.Toppings.ToListAsync();
        }

        public async Task<Topping> Get(int id)
        {
            return await _context.Toppings.FindAsync(id);
        }

        public Task Update(Topping item)
        {
            throw new NotImplementedException();
        }

        public Topping GetOne(string name)
        {
            throw new NotImplementedException();
        }

        public void Add(string name)
        {
            throw new NotImplementedException();
        }

        public List<Topping> GetPresets()
        {
            throw new NotImplementedException();
        }

        public void Add(Topping item)
        {
            throw new NotImplementedException();
        }

        public void IncreasePrice(int id, double price)
        {
            throw new NotImplementedException();
        }

        public void DecreasePrice(int id, double price)
        {
            throw new NotImplementedException();
        }
    }
}
