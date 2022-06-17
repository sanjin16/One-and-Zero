using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.DTOs.Request
{
    public class RecipesDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public IEnumerable<AddRecipeIngredientDto> RecipeIngredients { get; set; }
    }
}
