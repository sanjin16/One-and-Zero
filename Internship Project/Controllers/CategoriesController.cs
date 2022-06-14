using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.Database.Helper;
using NormativeCalculator.DTOs.Request;
using NormativeCalculator.Service.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Internship_Project.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _recipeCategoryService;
        public CategoriesController( ICategoryService recipeCategoryService)
        {
            _recipeCategoryService = recipeCategoryService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            return Ok(await _recipeCategoryService.GetCategoryByIdAsync(id));
        }

        [HttpGet]
        public async Task<PaginationModel<List<GetCategoryDto>>> GetRecipeCategory(int skip)
        {
            return await _recipeCategoryService.GetCategoryAsync(skip);
        }

        [HttpPost]
        public async Task<IActionResult> InsertRecipeCategory (AddCategoryRequestDto request)
        {
            return Ok(await _recipeCategoryService.AddRecipeCategoryAsync(request));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRecipeCategory(int id, AddCategoryRequestDto request)
        {
            return Ok(await _recipeCategoryService.UpdateRecipeCategoryAsync(id, request));
        }

        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _recipeCategoryService.DeleteRecipeCategoryAsync(id);
        }
    }
}
