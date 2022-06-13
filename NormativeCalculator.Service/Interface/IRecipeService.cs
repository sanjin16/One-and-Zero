using NormativeCalculator.Database.Entities;
using NormativeCalculator.Database.Helper;
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
        Task<PaginationModel<List<RecipeDto>>> GetRecipeAsync(RecipeCategoryRequestDto request);
        Task DeleteRecipeAsync(int Id);
        Task<RecipeDto> InsertRecipeAsync(AddRecipeRequestDto request);
        Task UpdateRecipeAsync(UpdateRecipeRequestDto request);

    }
}
