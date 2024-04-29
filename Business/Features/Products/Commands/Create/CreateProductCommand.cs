using AutoMapper;
using Business.Abstracts;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using ValidationException = Core.CrossCuttingConcerns.Exceptions.Types.ValidationException;

namespace Business.Features.Products.Commands.Create
{
    public class CreateProductCommand : IRequest
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }

        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
        {
            private readonly IProductRepository _productRepository;
            private readonly ICategoryService _categoryService;
            private readonly IMapper _mapper;

            public CreateProductCommandHandler(IProductRepository productRepository,ICategoryService categoryService, IMapper mapper)
            {
                _productRepository = productRepository;
                _categoryService = categoryService;
                _mapper = mapper;
            }

            public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                //Ürün fiyatı 0 dan küçük olamaz. //validasyon
                //if (request.UnitPrice < 0)
                //    throw new BusinessException("Ürün fiyatı 0'dan küçük olamaz.");

                IValidator<CreateProductCommand> validator = new CreateProductCommandValidator();

                // validator.ValidateAndThrow(request); // kendi ex. fırlatacak.

                ValidationResult result = validator.Validate(request); // Validation'ı yapıcak. Sonucu vericek.

                if (!result.IsValid)
                {
                    throw new ValidationException(result.Errors.Select(i => i.ErrorMessage).ToList());
                }

                //Aynı isimde 2. ürün eklenemez. //iş kuralı
                Product? productWithSameName = await _productRepository.GetAsync(p => p.Name == request.Name);
                if (productWithSameName is not null)
                    throw new BusinessException("Aynı isimde 2. ürün eklenemez.");

                //Kategorileri ulaşma //iş kuralı
                Category? catergory = await _categoryService.GetByIdAsync(request.CategoryId);
                if (catergory is null)
                    throw new BusinessException("Böyle bir kategori bulunamadı.");

                //Mapping (Manual)
                //Product product = new();
                //product.Name = dto.Name;
                //product.UnitPrice = dto.UnitPrice;
                //product.Stock = dto.Stock;
                //product.CategoryId = dto.CategoryId;
                //product.CreatedDate = DateTime.Now;

                //Mapping (auto)
                Product product = _mapper.Map<Product>(request);
                await _productRepository.AddAsync(product);

                //CreateProductResponse response = _mapper.Map<CreateProductResponse>(product);
                //return response;
            }
        }
    }
}