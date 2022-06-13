using AutoMapper;
using NormativeCalculator.Common.Enum;
using NormativeCalculator.Database.EF;
using NormativeCalculator.Database.Entities;
using NormativeCalculator.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Service.Service
{
    public class RecipeIngredientPriceService : IRecipeIngredientPriceService
    {
        private readonly NormativeCalculatorDbContext _context;
        protected readonly IMapper _mapper;

        public RecipeIngredientPriceService(NormativeCalculatorDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public bool IsMeasuerTypeKgL(MeasureType type)
        {
            if (type.Equals(MeasureType.kg) || type.Equals(MeasureType.l))
                return true;

            return false;
        }
        public decimal ConvertQuantity(decimal quantity, MeasureType type)
        {
            if (IsMeasuerTypeKgL(type))
                return quantity * 1000;

            return quantity;
        }

        public decimal IngredientPrice(RecipeIngredients request)
        {
            decimal totalIngredinetPrice = 0;
            var ingredinet = _context.Ingredients.FirstOrDefault(i => i.Id == request.IngredientId);
            if (request.IngredientId == ingredinet.Id && !IsMeasuerTypeKgL(request.measureType))
            {
                totalIngredinetPrice = request.Quantity * ingredinet.Price;
            }
            totalIngredinetPrice = ConvertQuantity(request.Quantity, request.measureType) * ingredinet.Price;

            return Math.Round(totalIngredinetPrice, 2);
        }
    }
}
