using Microsoft.EntityFrameworkCore;
using PizzaBoxApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxApi.Repositories
{
    public class CrustRepository : IRepository<Crust>
    {
        private readonly PizzaBoxContext _context;
        public CrustRepository(PizzaBoxContext context)
        {
            _context = context;
        }

        public List<Crust> GetAll()
        {
            return _context.Crusts.ToList();
        }

        public Crust GetOne(int id)
        {
            return _context.Crusts.Find(id);
        }



















        public async Task<Crust> Create(Crust item)
        {
            _context.Crusts.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task Delete(int id)
        {
            var crustToDelete = await _context.Crusts.FindAsync(id);
            _context.Crusts.Remove(crustToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Crust>> Get()
        {
            return await _context.Crusts.ToListAsync();
        }

        public async Task<Crust> Get(int id)
        {
            return await _context.Crusts.FindAsync(id);
        }

        public async Task Update(Crust item)
        {
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public Crust GetOne(string name)
        {
            throw new NotImplementedException();
        }

        public void Add(string name)
        {
            throw new NotImplementedException();
        }

        public List<Crust> GetPresets()
        {
            throw new NotImplementedException();
        }

        public void Add(Crust item)
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
