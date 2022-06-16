using AutoMapper;
using NormativeCalculator.Database.Entities;
using NormativeCalculator.DTOs.IngredientDto;
using NormativeCalculator.DTOs.Request;

namespace Internship_Project.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Recipe, AddRecipeRequestDto>().ReverseMap();
            CreateMap<Category, GetCategoryDto>();
            CreateMap<Recipe, RecipeDto>().ReverseMap();
            CreateMap<Recipe, RecipesDto>().ReverseMap();
            CreateMap<Recipe, GetRecipesDto>().ReverseMap();
            CreateMap<GetRecipesDto, RecipeDto>().ReverseMap();
            CreateMap<Category, AddCategoryRequestDto>().ReverseMap();
            CreateMap<AddIngredientDto, Ingredient>();
            CreateMap<Ingredient, GetIngredientDto>();
            CreateMap<RecipeIngredients, AddRecipeIngredientDto>().ReverseMap();
        }
    }
}
