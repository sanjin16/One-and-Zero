using AutoMapper;
using NormativeCalculator.Database.Entities;
using NormativeCalculator.DTOs.Request;

namespace Internship_Project.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {
            CreateMap<Recipe, AddRecipeRequestDto>().ReverseMap();
            CreateMap<Recipe, UpdateRecipeRequestDto>().ReverseMap();
            CreateMap<RecipeCategories, RecipeCategoriesGetDto>();
            CreateMap<Recipe, RecipeDto>();
            CreateMap<GetRecipesDto, RecipeDto>();
            CreateMap<RecipeCategories, RecipeCategoryInsertDto>().ReverseMap();
        }
    }
}
