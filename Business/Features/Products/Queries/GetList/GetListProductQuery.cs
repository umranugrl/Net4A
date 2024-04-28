using AutoMapper;
using DataAccess.Abstracts;
using Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Features.Products.Queries.GetList
{
    public class GetListProductQuery : IRequest<List<GetAllProductResponse>>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }

        public class GetListProductQueryHandler : IRequestHandler<GetListProductQuery, List<GetAllProductResponse>>
        {
            private readonly IProductRepository _productRepository;
            private readonly IMapper _mapper;

            public GetListProductQueryHandler(IProductRepository productRepository, IMapper mapper)
            {
                _productRepository = productRepository;
                _mapper = mapper;
            }

            public async Task<List<GetAllProductResponse>> Handle(GetListProductQuery request, CancellationToken cancellationToken)
            {
                List<Product> products = await _productRepository.GetListAsync();
                List<GetAllProductResponse> response = _mapper.Map<List<GetAllProductResponse>>(products);
                return response;
            }
        }
    }
}