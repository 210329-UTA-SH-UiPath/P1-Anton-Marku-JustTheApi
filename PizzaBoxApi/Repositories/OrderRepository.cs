using PizzaBoxApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxApi.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private readonly PizzaBoxContext _context;
        public OrderRepository(PizzaBoxContext context)
        {
            _context = context;
        }
        public void IncreasePrice(int id, double price)
        {
            var Order = _context.Orders.Find(id);
            if(Order.TotalPrice + price <= 250)
            {
                Order.TotalPrice += price;
                _context.SaveChanges();
            }
        }

        public void DecreasePrice(int id, double price)
        {
            var Order = _context.Orders.Find(id);
            Order.TotalPrice -= price;
            _context.SaveChanges();
        }

        public void Add(Order item)
        {
            var customer = _context.Customers.Find(item.CustomerId);
            var time = customer.LastTimeOrdered;
            if (time.HasValue)
            {
                if (customer.StoreId == item.StoreId && time.Value.AddHours(2) < item.DateTime)
                {
                    _context.Orders.Add(item);
                    customer.LastTimeOrdered = DateTime.Now;
                }
            }
            if(time == null || customer.StoreId == null)
            {
                _context.Orders.Add(item);
                customer.StoreId = item.StoreId;
                customer.StoreVisitTime = DateTime.Now;
                customer.LastTimeOrdered = DateTime.Now;
            }
            if(customer.StoreId != item.StoreId && customer.StoreVisitTime.Value.AddHours(24) < item.DateTime && time.Value.AddHours(2) < item.DateTime)
            {
                _context.Orders.Add(item);
                customer.StoreId = item.StoreId;
                customer.StoreVisitTime = DateTime.Now;
                customer.LastTimeOrdered = DateTime.Now;
            }
            _context.SaveChanges();
        }

        public List<Order> GetAll()
        {
            return _context.Orders.ToList();
        }












        public void Add(string name)
        {
            throw new NotImplementedException();
        }
            
        public Task<Order> Create(Order item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Order> Get(int id)
        {
            throw new NotImplementedException();
        }

        

        public Order GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public Order GetOne(string name)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetPresets()
        {
            throw new NotImplementedException();
        }

        public Task Update(Order item)
        {
            throw new NotImplementedException();
        }
    }
}
