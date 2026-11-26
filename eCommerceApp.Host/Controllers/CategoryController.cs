using eCommerceApp.Application.DTOs.Category;
using eCommerceApp.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceApp.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController(ICategoryService categoryService) : ControllerBase
    {
        [HttpGet("All")]
        public async Task<IActionResult> GetAll()
        {
            var data = await categoryService.GetAllAsync();
            return data.Any() ? Ok(data) : NotFound();
        }

        [HttpGet("Single/{id:guid}")]
        public async Task<IActionResult> GetSingle(Guid id)
        {
            var data = await categoryService.GetByIdAsync(id);
            return data.Id != Guid.Empty ? Ok(data) : NotFound();
        }



        [HttpPost("Add")]
        public async Task<IActionResult> Add(CreateCategory category)
        {
            var result = await categoryService.AddAsync(category);
            return result.Success ? Ok(result) : BadRequest(result);
        }



        [HttpPut("Update")]
        public async Task<IActionResult> Update(UpdateCategory category)
        {
            var result = await categoryService.UpdateAsync(category);
            return result.Success ? Ok(result) : BadRequest(result);
        }



        [HttpDelete("Delete/{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await categoryService.DeleteAsync(id);
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }
}