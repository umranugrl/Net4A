using Business.Abstracts;
using Business.Concretes;
using Business.Dtos.Product.Request;
using Business.Dtos.Product.Response;
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
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            this._productService = productService;
        }

        [HttpGet]
        public async Task<List<ListProductResponce>> GetAll()
        {
            return await _productService.GetAll();
        }

        [HttpPost]
        public async Task Add([FromBody] AddProductRequest product)
        {
            await _productService.Add(product);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _productService.GetById(id);
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
            _productService.Update(product);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productService.Delete(id);
            return NoContent();
        }
    }
}