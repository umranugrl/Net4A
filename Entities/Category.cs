using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Category : Entity
    {
        public Category()
        {
        }
        public Category(int id,string categoryName)
        {
            Id = id;
            CategoryName = categoryName;
        }

        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set;}
    }
}