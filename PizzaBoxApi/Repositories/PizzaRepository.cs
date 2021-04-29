using PizzaBoxApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxApi.Repositories
{
    public class PizzaRepository : IRepository<Pizza>
    {
        private readonly PizzaBoxContext _context;
        public PizzaRepository(PizzaBoxContext context)
        {
            _context = context;
        }
        public List<Pizza> GetPresets()
        {
            return _context.Pizzas.Where(x => x.Id == 4 || x.Id == 6).ToList();
        }
        public void Add(Pizza item)
        {
            item.Price += item.Crust.Price;
            item.Price += item.Size.Price;
            var items = _context.PizzaToppings.Where(p => p.PizzaId == item.Id);
            foreach(var top in items)
            {
                item.Price += _context.Toppings.SingleOrDefault(t => t.Id == top.ToppingId).Price;
            }
            _context.Pizzas.Add(item);
            _context.SaveChanges();
        }
        public List<Pizza> GetAll()
        {
            return _context.Pizzas.ToList();
        }



























        public void Add(string name)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pizza>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Pizza> Get(int id)
        {
            throw new NotImplementedException();
        }
              
        public Pizza GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public Pizza GetOne(string name)
        {
            throw new NotImplementedException();
        }

        public Task Update(Pizza item)
        {
            throw new NotImplementedException();
        }

        public Task<Pizza> Create(Pizza item)
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
