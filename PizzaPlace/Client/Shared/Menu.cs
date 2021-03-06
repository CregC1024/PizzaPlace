using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Client.Shared
{
    public class Menu
    {
        public List<Pizza> Pizzas { get; set; }
        = new List<Pizza>();
        public Pizza GetPizza(int id)
            => Pizzas.SingleOrDefault(Pizza => Pizza.ID == id);
    }
}
