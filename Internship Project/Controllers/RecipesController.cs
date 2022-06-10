using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.DTOs.Request;
using NormativeCalculator.Service.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Internship_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly IRecipeService _recipeService;
        public RecipesController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }
    
    }
}
