using NormativeCalculator.Database.Entities;
using NormativeCalculator.DTOs.Models;
using NormativeCalculator.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Service.Interface
{
    public interface IRecipeService
    {
        Task<GetRecipesDto> GetRecipeByIdAsync(int id);
        Task<PaginationModel<List<RecipeDto>>> GetRecipeAsync(RecipeSearchRequestDto request);
        Task<RecipeDto> DeleteRecipeAsync(int id);
        Task<RecipesDto> InsertRecipeAsync(AddRecipeRequestDto request);
        Task<RecipesDto> UpdateRecipeAsync(int id, AddRecipeRequestDto request);
    }
}
