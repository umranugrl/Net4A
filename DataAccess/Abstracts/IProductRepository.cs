using Core.DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    //Ürün veri deposunun interface hali
    public interface IProductRepository : IRepository<Product>, IAsyncRepository<Product>
    {

    }
}