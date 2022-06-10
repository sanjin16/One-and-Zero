using AutoMapper;
using NormativeCalculator.Database.Entities;
using NormativeCalculator.DTOs.Request;

namespace Internship_Project.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {
            CreateMap<Recipe, RecipesInsertDto>();
            CreateMap<RecipeCategories, RecipeCategoriesGetDto>();
            CreateMap<Recipe, AddRecipesDto>().ReverseMap();
            CreateMap<RecipeCategories, RecipeCategoryInsertDto>().ReverseMap();
        }
    }
}
