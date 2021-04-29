using Microsoft.EntityFrameworkCore;
using PizzaBoxApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxApi.Repositories
{
    public class StoreRepository : IRepository<Store>
    {
        private readonly PizzaBoxContext _context;
        public StoreRepository(PizzaBoxContext context)
        {
            _context = context;
        }

        public List<Store> GetAll()
        {
            return _context.Stores.ToList();
        }

        public Store GetOne(int id)
        {
            return _context.Stores.Find(id);
        }





























        public Task<Store> Create(Store item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Store>> Get()
        {
            return await _context.Stores.ToListAsync();
        }

        public async Task<Store> Get(int id)
        {
            return await _context.Stores.FindAsync(id);
        }

        public Task Update(Store item)
        {
            throw new NotImplementedException();
        }

        public Store GetOne(string name)
        {
            throw new NotImplementedException();
        }

        public void Add(string name)
        {
            throw new NotImplementedException();
        }

        public List<Store> GetPresets()
        {
            throw new NotImplementedException();
        }

        public void Add(Store item)
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
