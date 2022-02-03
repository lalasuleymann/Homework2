using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}  Name: {Name}  Price: {Price}  Category: {Category.Name}";
        }
    }
}
