using Business.Dtos.Product.Request;
using Business.Dtos.Product.Response;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IProductService
    {
        Product GetById(int id);
        Task<List<ListProductResponce>> GetAll();
        Task Add(AddProductRequest product);
        void Update(Product product);
        void Delete(int id);
    }
}