using Microsoft.AspNetCore.Mvc;
using PizzaBoxApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxApi.Repositories
{
    public class OrderPizzaRepository : IRepository<OrderPizza>
    {
        private readonly PizzaBoxContext _context;
        public OrderPizzaRepository(PizzaBoxContext context)
        {
            _context = context;
        }
             
        public void Add(OrderPizza item)
        {
            var Order = _context.Orders.Find(item.OrderId);
            var Pizza = _context.Pizzas.Find(item.PizzaId);
            if (Order.OrderPizzas == null)
            {
                Order.OrderPizzas = new List<OrderPizza>();
            }
            if(Order.OrderPizzas.Count() < 50 && Order.TotalPrice + Pizza.Price <= 250)
            {
                Order.TotalPrice += Pizza.Price;
                _context.OrderPizzas.Add(item);
                _context.SaveChanges();
            }
        }
        [HttpDelete("{id}")]
        public void DeleteOne(int id)
        {
            var item = _context.OrderPizzas.Find(id);
            if(item != null)
            {
                var order = _context.Orders.Find(item.OrderId);
                var pizza = _context.Pizzas.Find(item.PizzaId);
                order.TotalPrice -= pizza.Price;
                _context.OrderPizzas.Remove(item);
                _context.SaveChanges();
            }
        }

        public List<OrderPizza> GetAllById(int id)
        {
            return _context.OrderPizzas.Where(o => o.OrderId == id).ToList();
        }

        public List<OrderPizza> GetAll()
        {
            return _context.OrderPizzas.ToList();
        }






































        public void Add(string name)
        {
            throw new NotImplementedException();
        }

        public Task<OrderPizza> Create(OrderPizza item)
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

        public Task<IEnumerable<OrderPizza>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<OrderPizza> Get(int id)
        {
            throw new NotImplementedException();
        }

        

        public OrderPizza GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public OrderPizza GetOne(string name)
        {
            throw new NotImplementedException();
        }

        public List<OrderPizza> GetPresets()
        {
            throw new NotImplementedException();
        }

        public void IncreasePrice(int id, double price)
        {
            throw new NotImplementedException();
        }

        public Task Update(OrderPizza item)
        {
            throw new NotImplementedException();
        }
    }
}
