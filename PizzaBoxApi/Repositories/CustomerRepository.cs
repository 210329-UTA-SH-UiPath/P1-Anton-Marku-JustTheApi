using PizzaBoxApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxApi.Repositories
{
    public class CustomerRepository : IRepository<Customer>
    {
        private readonly PizzaBoxContext _context;
        public CustomerRepository(PizzaBoxContext context)
        {
            _context = context;
        }

        public Customer GetOne(string name)
        {
            return _context.Customers.SingleOrDefault(c => c.Name == name);
        }

        public List<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public void Add(Customer item)
        {
            _context.Customers.Add(item);
            _context.SaveChanges();
        }



























        public Task<Customer> Create(Customer item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> Get(int id)
        {
            throw new NotImplementedException();
        }

       

        public Customer GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Customer item)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetPresets()
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
