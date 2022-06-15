﻿using NormativeCalculator.Common.Enum;

namespace NormativeCalculator.DTOs.Request
{
    public class AddRecipeIngredientDto
    {
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
        public int Quantity { get; set; }
        public MeasureType MeasureType { get; set; }
    }
}
