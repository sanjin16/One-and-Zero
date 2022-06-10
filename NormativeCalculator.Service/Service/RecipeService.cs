using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Database.EF;
using NormativeCalculator.Database.Entities;
using NormativeCalculator.DTOs.Request;
using NormativeCalculator.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Service.Service
{
    public class RecipeService : IRecipeService
    {
        private readonly NormativeCalculatorDbContext _context;
        private readonly IMapper _mapper;
        public RecipeService(IMapper mapper)
        {
            _mapper = mapper;
        }

    }
}
