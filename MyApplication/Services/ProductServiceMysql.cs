using MyApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Services
{
    public class ProductServiceMysql : BaseProductService
    {
        public override void AddProduct(Product product)
        {
            Console.WriteLine("Ürün MySql e eklendi.");
        }

        public override void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public override void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
