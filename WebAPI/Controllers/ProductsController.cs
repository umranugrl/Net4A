using Business.Abstracts;
using Business.Concretes;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    //api/products  
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public List<Product> GetAll()
        {
            return productService.GetAll();
        }

        [HttpPost]
        public void Add([FromBody] Product product)
        {
            productService.Add(product);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }
            productService.Update(product);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            productService.Delete(id);
            return NoContent();
        }
    }
}