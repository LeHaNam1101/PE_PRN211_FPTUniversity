using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class Product
    {
        public Product(int id, string name, decimal price, bool isActive)
        {
            Id = id;
            Name = name;
            Price = (double)price;
            IsActive = isActive;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
    }
}
