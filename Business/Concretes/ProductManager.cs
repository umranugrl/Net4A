using Business.Abstracts;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationException = Core.CrossCuttingConcerns.Exceptions.Types.ValidationException;

namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async void Add(Product product)
        {
            //Ürün fiyatı 0 dan küçük olamaz.
            if(product.UnitPrice <0)
                throw new BusinessException("Ürün fiyatı 0'dan küçük olamaz.");

            //Aynı isimde 2. ürün eklenemez.
            Product? productWithSameName = await _productRepository.GetAsync(p=>p.Name ==product.Name);
            if (productWithSameName is not null)
                throw new BusinessException("Aynı isimde 2. ürün eklenemez.");

            await _productRepository.AddAsync(product);
        }

        public void Delete(int id)
        {
            Product? productToDelete = _productRepository.Get(i=>i.Id == id);
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetAll()
        {
            return await _productRepository.GetListAsync();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        //public void Delete(int id)
        //{
        //    Product product = products.FirstOrDefault(p => p.Id == id);
        //    if (product != null)
        //    {
        //        products.Remove(product);
        //    }
        //}

        //public Product GetById(int id)
        //{
        //    return products.FirstOrDefault(p => p.Id == id);
        //}

        //public void Update(Product updatedProduct)
        //{
        //    Product product = products.FirstOrDefault(p => p.Id == updatedProduct.Id);
        //    if (product != null)
        //    {
        //        product.Name = updatedProduct.Name;
        //        product.UnitPrice = updatedProduct.UnitPrice;
        //    }
        //}
    }
}