using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.Database.Helper;
using NormativeCalculator.DTOs.Request;
using NormativeCalculator.Service.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Internship_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeCategoriesController : ControllerBase
    {
        private readonly IRecipeCategoryService _recipeCategoryService;
        public RecipeCategoriesController( IRecipeCategoryService recipeCategoryService)
        {
            _recipeCategoryService = recipeCategoryService;
        }
        [HttpGet]
        public async Task<PaginationModel<List<RecipeCategoriesGetDto>>> GetRecipeCategory(int skip)
        {
            return await _recipeCategoryService.GetRecipeCategoryAsync(skip);
        }
        [HttpPost]
        public async Task InsertRecipeCategory (RecipeCategoryInsertDto request)
        {
             await _recipeCategoryService.AddRecipeCategoryAsync(request);
        }
        [HttpDelete("{Id}")]
        public async Task<bool> Delete(int Id)
        {
            return await _recipeCategoryService.DeleteRecipeCategoryAsync(Id);
        }
    }
}
