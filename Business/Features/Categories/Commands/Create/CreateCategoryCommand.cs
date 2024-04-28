using AutoMapper;
using Business.Abstracts;
using DataAccess.Abstracts;
using Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Features.Categories.Commands.Create
{
    public class CreateCategoryCommand : IRequest
    {
        public string CategoryName { get; set; }

        public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand>
        {
            private readonly ICategoryRepository _categoryRepository;
            private readonly IMapper _mapper;

            public CreateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
            {
                _categoryRepository = categoryRepository;
                _mapper = mapper;
            }

            public async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
            {
                //Manual mapping
                //Category category = new();
                //category.CategoryName = dto.CategoryName;
                //category.CreatedDate = DateTime.Now;

                //Kategori eklenirken içerisinde 3 adet gönderilmelidir.


                //Auto mapping
                Category category = _mapper.Map<Category>(request);
                await _categoryRepository.AddAsync(category);
            }
        }
    }
}