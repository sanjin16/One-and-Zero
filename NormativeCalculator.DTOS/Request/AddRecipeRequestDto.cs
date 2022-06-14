using NormativeCalculator.Database.Entities;
using NormativeCalculator.DTOs.IngredientDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.DTOs.Request
{
    public class AddRecipeRequestDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public List<GetIngredientDto> Ingredients { get; set; }

    }
}
