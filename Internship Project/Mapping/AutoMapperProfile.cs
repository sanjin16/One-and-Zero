using AutoMapper;
using NormativeCalculator.Database.Entities;
using NormativeCalculator.DTOs.IngredientDto;
using NormativeCalculator.DTOs.Request;

namespace Internship_Project.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {
            CreateMap<Recipe, AddRecipeRequestDto>().ReverseMap();
            CreateMap<Recipe, UpdateRecipeRequestDto>().ReverseMap();
            CreateMap<Category, GetCategoryDto>();
            CreateMap<Recipe, RecipeDto>();
            CreateMap<GetRecipesDto, RecipeDto>();
            CreateMap<Category, AddCategoryRequestDto>().ReverseMap();

            CreateMap<AddIngredientDto, Ingredient>();
            CreateMap<Ingredient, GetIngredientDto>();
        }
    }
}
