using Business.Abstracts;

namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        //public void Delete(int id)
        //{
        //    Product? productToDelete = _productRepository.Get(i=>i.Id == id);
        //    throw new NotImplementedException();
        //}

        //public async Task<List<ListProductResponce>> GetAll()
        //{
        //    List<Product> products = await _productRepository.GetListAsync();

        //    //List<ProductForListingDto> response = new List<ProductForListingDto>();
        //    //foreach (Product product in products)
        //    //{
        //    //    ProductForListingDto dto = new();
        //    //    dto.Name=product.Name;
        //    //    dto.UnitPrice = product.UnitPrice;
        //    //    dto.Id = product.Id;
        //    //    response.Add(dto);
        //    //}

        //    //Manual Mapping
        //    //List<ProductForListingDto> response = products.Select(p => new ProductForListingDto()
        //    //{
        //    //    Id=p.Id,
        //    //    Name=p.Name,
        //    //    UnitPrice=p.UnitPrice,
        //    //}).ToList();

        //    List<ListProductResponce> response = _mapper.Map<List<ListProductResponce>>(products);
        //    return response;
        //}

        //public Product? GetById(int id)
        //{
        //    return _productRepository.Get(p => p.Id == id);
        //}

        //public void Update(Product product)
        //{
        //    throw new NotImplementedException();
        //}
    }
}