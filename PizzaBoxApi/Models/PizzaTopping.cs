using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxApi.Models
{
    public class PizzaTopping
    {
        public int Id { get; set; }
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }
        public int ToppingId { get; set; }
        public Topping Topping { get; set; }
    }
}
