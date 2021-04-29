using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxApi.Repositories
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> Get();
        Task<T> Get(int id);
        Task<T> Create(T item);
        Task Update(T item);
        Task Delete(int id);
        //store,top,crust,size
        List<T> GetAll();

        T GetOne(int id);

        //customer
        T GetOne(string name);

        //Pizza
        public List<T> GetPresets();
        public void Add(T item);

        //order
        public void IncreasePrice(int id, double price);
        public void DecreasePrice(int id, double price);
        //orderpizza
        public void DeleteOne(int id) { }
        public List<T> GetAllById(int id) { return new List<T>(); }
    }
}
