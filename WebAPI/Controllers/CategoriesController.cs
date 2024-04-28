using Business.Features.Categories.Commands.Create;
using Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        //[HttpGet]
        //public async Task<List<ListCategoryResponce>> GetAll()
        //{
        //    return null;
        //}

        [HttpPost]
        public async Task AddAsync([FromBody] CreateCategoryCommand command)
        { 
            await _mediator.Send(command);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return null;
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Category category)
        {
            return null;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return null;
        }
    }
}