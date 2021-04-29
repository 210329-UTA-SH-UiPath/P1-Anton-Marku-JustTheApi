using PizzaBoxApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxApi.Repositories
{
    public class PizzaToppingRepository : IRepository<PizzaTopping>
    {
        private readonly PizzaBoxContext _context;
        public PizzaToppingRepository(PizzaBoxContext context)
        {
            _context = context;
        }

        public void Add(PizzaTopping item)
        {
            if(_context.PizzaToppings.Where(p => p.Id == item.PizzaId).ToList().Count() < 5)
            {
                var pizza = _context.Pizzas.Find(item.PizzaId);
                var orderPizza = _context.OrderPizzas.SingleOrDefault(p => p.PizzaId == pizza.Id);
                var order = _context.Orders.SingleOrDefault(o => o.Id == orderPizza.OrderId);
                var topping = _context.Toppings.Find(item.ToppingId);
                if (order.TotalPrice + topping.Price < 250)
                {
                    _context.PizzaToppings.Add(item);
                    pizza.Price += topping.Price;
                    order.TotalPrice += topping.Price;
                    _context.SaveChanges();
                }
            }
        }

        public List<PizzaTopping> GetAll()
        {
            return _context.PizzaToppings.ToList();
        }






























        public void Add(string name)
        {
            throw new NotImplementedException();
        }

        public Task<PizzaTopping> Create(PizzaTopping item)
        {
            throw new NotImplementedException();
        }

        public void DecreasePrice(int id, double price)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PizzaTopping>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<PizzaTopping> Get(int id)
        {
            throw new NotImplementedException();
        }

        

        public PizzaTopping GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public PizzaTopping GetOne(string name)
        {
            throw new NotImplementedException();
        }

        public List<PizzaTopping> GetPresets()
        {
            throw new NotImplementedException();
        }

        public void IncreasePrice(int id, double price)
        {
            throw new NotImplementedException();
        }

        public Task Update(PizzaTopping item)
        {
            throw new NotImplementedException();
        }
    }
}
