using Business.Abstracts;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public List<Category> GetAll()
        {
            return categoryService.GetAll();
        }

        [HttpPost]
        public void Add([FromBody] Category category)
        {
            categoryService.Add(category);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var category = categoryService.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Category category)
        {
            if (id != category.CategoryId)
            {
                return BadRequest();
            }
            categoryService.Update(category);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            categoryService.Delete(id);
            return NoContent();
        }
    }
}