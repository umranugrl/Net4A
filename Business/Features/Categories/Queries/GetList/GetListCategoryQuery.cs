using AutoMapper;
using DataAccess.Abstracts;
using Entities;
using MediatR;

namespace Business.Features.Categories.Queries.GetList
{
    public class GetListCategoryQuery : IRequest<List<GetAllCategoryResponse>>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }

        public class GetListCategoryQueryHandler : IRequestHandler<GetListCategoryQuery, List<GetAllCategoryResponse>>
        {
            private readonly ICategoryRepository _categoryRepository;
            private readonly IMapper _mapper;

            public GetListCategoryQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
            {
                _categoryRepository = categoryRepository;
                _mapper = mapper;
            }

            public async Task<List<GetAllCategoryResponse>> Handle(GetListCategoryQuery request, CancellationToken cancellationToken)
            {
                List<Category> categories = await _categoryRepository.GetListAsync();
                List<GetAllCategoryResponse> response = _mapper.Map<List<GetAllCategoryResponse>>(categories);
                return response;
            }
        }
    }
}