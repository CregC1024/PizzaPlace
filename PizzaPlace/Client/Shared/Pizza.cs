using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Client.Shared
{
    public enum Spiciness
    {
        None, 
        Spicy,
        Hot,
    }
    public class Pizza
    {
        public Pizza(int id, string name, decimal price, Spiciness spiciness)
        {
            this.ID = id;
            this.Name = name
                ?? throw new ArgumentNullException(nameof(name), "A pizza needds a name!");
            this.Price = price;
            this.Spiciness = spiciness;

        }
        public int ID { get; }
        public string Name { get; }
        public decimal Price { get; }
        public Spiciness Spiciness { get; }
    }

}
