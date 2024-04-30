using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities;
using MediatR;

namespace Business.Features.Products.Queries.GetById
{
    public class GetByIdProductQuery : IRequest<GetByIdProductResponse>
    {
        public int Id { get; set; }

        public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQuery, GetByIdProductResponse>
        {
            private readonly IProductRepository _productRepository;
            private readonly IMapper _mapper;

            public GetByIdProductQueryHandler(IProductRepository productRepository, IMapper mapper)
            {
                _productRepository = productRepository;
                _mapper = mapper;
            }

            public async Task<GetByIdProductResponse> Handle(GetByIdProductQuery request, CancellationToken cancellationToken)
            {
                Product? product = await _productRepository.GetAsync(p => p.Id == request.Id);

                if (product is null)
                    throw new BusinessException("Böyle bir veri bulunamadı.");

                GetByIdProductResponse response = _mapper.Map<GetByIdProductResponse>(product);
                return response;
            }
        }
    }
}