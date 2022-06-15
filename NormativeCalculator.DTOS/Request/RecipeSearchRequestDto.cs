using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.DTOs.Request
{
    public class RecipeSearchRequestDto
    { 
        public int CategoryId { get; set; } 
        public string SearchText { get; set; }

        public string Sort { get; set; }
    }
}
