using eCommerceApp.Application.DTOs.Product;
using eCommerceApp.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceApp.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IProductService productService) : ControllerBase
    {
        [HttpGet("All")]
        public async Task<IActionResult> GetAll()
        {
            var data = await productService.GetAllAsync();
            return data.Any() ? Ok(data) : NotFound();
        }

        [HttpGet("Single/{id:guid}")]
        public async Task<IActionResult> GetSingle(Guid id)
        {
            var data = await productService.GetByIdAsync(id);
            return data.Id != Guid.Empty ? Ok(data) : NotFound();
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(CreateProduct product)
        {
            var result = await productService.AddAsync(product);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(UpdateProduct product)
        {
            var result = await productService.UpdateAsync(product);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpDelete("Delete/{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await productService.DeleteAsync(id);
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }
}