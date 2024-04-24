using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        public Product(int ıd, string name, double unitPrice)
        {
            Id = ıd;
            Name = name;
            UnitPrice = unitPrice;
        }

        public Product()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
    }
}
