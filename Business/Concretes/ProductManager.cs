using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Product.Request;
using Business.Dtos.Product.Response;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities;

namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductManager(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task Add(AddProductRequest dto)
        {
            //Ürün fiyatı 0 dan küçük olamaz.
            if(dto.UnitPrice <0)
                throw new BusinessException("Ürün fiyatı 0'dan küçük olamaz.");

            //Aynı isimde 2. ürün eklenemez.
            Product? productWithSameName = await _productRepository.GetAsync(p=>p.Name ==dto.Name);
            if (productWithSameName is not null)
                throw new BusinessException("Aynı isimde 2. ürün eklenemez.");

            //Mapping (Manual)
            //Product product = new();
            //product.Name = dto.Name;
            //product.UnitPrice = dto.UnitPrice;
            //product.Stock = dto.Stock;
            //product.CategoryId = dto.CategoryId;
            //product.CreatedDate = DateTime.Now;

            //Mapping (auto)
            Product product = _mapper.Map<Product>(dto);

            await _productRepository.AddAsync(product);
        }

        public void Delete(int id)
        {
            Product? productToDelete = _productRepository.Get(i=>i.Id == id);
            throw new NotImplementedException();
        }

        public async Task<List<ListProductResponce>> GetAll()
        {
            List<Product> products = await _productRepository.GetListAsync();

            //List<ProductForListingDto> response = new List<ProductForListingDto>();
            //foreach (Product product in products)
            //{
            //    ProductForListingDto dto = new();
            //    dto.Name=product.Name;
            //    dto.UnitPrice = product.UnitPrice;
            //    dto.Id = product.Id;
            //    response.Add(dto);
            //}

            //Manual Mapping
            //List<ProductForListingDto> response = products.Select(p => new ProductForListingDto()
            //{
            //    Id=p.Id,
            //    Name=p.Name,
            //    UnitPrice=p.UnitPrice,
            //}).ToList();

            List<ListProductResponce> response = _mapper.Map<List<ListProductResponce>>(products);
            return response;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}