using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Client.Shared
{
    public class Basket 
    {
        public Customer Customer { get; set; } = new Customer();
        public List<int> Orders { get; set; } = new List<int>();
        public bool HasPaid { get; set; } = false;




        public void Add(int pizzaID)
        {
            Orders.Add(pizzaID);
        }

        public void RemoveAt(int index)
        {
            Orders.RemoveAt(index);
        }


    }
    
}



