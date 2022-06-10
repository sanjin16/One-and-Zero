using AutoMapper;
using NormativeCalculator.Database.Entities;
using NormativeCalculator.DTOs.IngredientDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AddIngredientDto, Ingredient>();
            CreateMap<Ingredient, GetIngredientDto>();
        }
    }
}
