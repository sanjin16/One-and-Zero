using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.Database.Entities;
using NormativeCalculator.DTOs.Request;
using NormativeCalculator.Service.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Internship_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly IRecipeService _recipeService;
        public RecipesController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }
        [HttpGet]
        public async Task<IActionResult> GetRecipesAsync([FromQuery]RecipeCategoryRequestDto request)
        {
            return Ok( await _recipeService.GetRecipeAsync(request));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRecipeByIdAsync(int id)
        {
            return Ok(await _recipeService.GetRecipeByIdAsync(id));
        }

        [HttpDelete("{id}")]
        public async Task DeleteRecipeById(int id)
        {
             await _recipeService.DeleteRecipeAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> InsertRecipeAsync(AddRecipeRequestDto request)
        {
            return Ok(await _recipeService.InsertRecipeAsync(request));
        }
        [HttpPut]
        public async Task  UpdateRecipeAsync(UpdateRecipeRequestDto recipe)
        {
            await _recipeService.UpdateRecipeAsync(recipe);
        }
    }
}
