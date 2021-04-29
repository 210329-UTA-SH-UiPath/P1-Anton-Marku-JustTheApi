using Microsoft.EntityFrameworkCore;
using PizzaBoxApi.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Size = PizzaBoxApi.Models.Size;

namespace PizzaBoxApi.Repositories
{
    public class SizeRepository : IRepository<Size>
    {
        private readonly PizzaBoxContext _context;
        public SizeRepository(PizzaBoxContext context)
        {
            _context = context;
        }

        public List<Size> GetAll()
        {
            return _context.Sizes.ToList();
        }

        public Size GetOne(int id)
        {
            return _context.Sizes.Find(id);
        }



























        public Task<Size> Create(Size item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Size>> Get()
        {
            return await _context.Sizes.ToListAsync();
        }

        public async Task<Size> Get(int id)
        {
            return await _context.Sizes.FindAsync(id);
        }
        public Task Update(Size item)
        {
            throw new NotImplementedException();
        }

        public Size GetOne(string name)
        {
            throw new NotImplementedException();
        }

        public void Add(string name)
        {
            throw new NotImplementedException();
        }

        public List<Size> GetPresets()
        {
            throw new NotImplementedException();
        }

        public void Add(Size item)
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
