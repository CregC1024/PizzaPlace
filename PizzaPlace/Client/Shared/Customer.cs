using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PizzaPlace.Client.Shared
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string city { get; set; }
    }
}
