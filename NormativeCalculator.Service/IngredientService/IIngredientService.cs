﻿using NormativeCalculator.Database.Entities;
using NormativeCalculator.DTOs.IngredientDto;
using NormativeCalculator.DTOs.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NormativeCalculator.Service.IngredientService
{
    public interface IIngredientService
    {
        Task<ServiceResponse<List<GetIngredientDto>>> GetAllIngredients();
        Task<ServiceResponse<GetIngredientDto>> GetOneIngredient(int id);
        Task<ServiceResponse<List<GetIngredientDto>>> AddIngredient(AddIngredientDto newIngredient);
        Task<ServiceResponse<GetIngredientDto>> UpdateIngredient(UpdateIngredientDto updatedIngredient);
        Task<ServiceResponse<List<GetIngredientDto>>> DeleteIngredient(int id);
    }
}
