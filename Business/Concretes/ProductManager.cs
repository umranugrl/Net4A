using Business.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        List<Product> products;

        public ProductManager()
        {
            this.products = new List<Product>();
        }

        public void Add(Product product)
        {
            products.Add(product);
        }

        public List<Product> GetAll()
        {
            return this.products;
        }

        public void Delete(int id)
        {
            Product product = products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                products.Remove(product);
            }
        }

        public Product GetById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public void Update(Product updatedProduct)
        {
            Product product = products.FirstOrDefault(p => p.Id == updatedProduct.Id);
            if (product != null)
            {
                product.Name = updatedProduct.Name;
                product.UnitPrice = updatedProduct.UnitPrice;
            }
        }
    }
}