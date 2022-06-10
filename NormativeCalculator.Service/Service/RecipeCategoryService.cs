using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Database.EF;
using NormativeCalculator.Database.Entities;
using NormativeCalculator.Database.Helper;
using NormativeCalculator.DTOs.Request;
using NormativeCalculator.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Service.Service
{
    public class RecipeCategoryService : IRecipeCategoryService
    {
        private readonly NormativeCalculatorDbContext _context;
        private readonly IMapper _mapper;
        public RecipeCategoryService(NormativeCalculatorDbContext context, IMapper mapper)
        {
            _context = context; 
            _mapper = mapper;
        }
        public async Task<PaginationModel<List<RecipeCategoriesGetDto>>> GetRecipeCategoryAsync(int skip)
        {
            var list = await _context.RecipeCategories.OrderByDescending(c => c.DateCreated).Skip(skip).Take(10).ToListAsync();
            var data = _mapper.Map<List<RecipeCategoriesGetDto>>(list);
            var count = _context.RecipeCategories.Count();
            return new PaginationModel<List<RecipeCategoriesGetDto>>(data, count);
        }

        public async Task AddRecipeCategoryAsync(RecipeCategoryInsertDto request)
        {
            var entity = _mapper.Map<RecipeCategories>(request);
            _context.Set<RecipeCategories>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteRecipeCategoryAsync(int Id)
        {
            var entity = await _context.RecipeCategories.Where(i => i.Id == Id).FirstOrDefaultAsync();
            if (entity != null)
            {
                _context.RecipeCategories.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
           return false;
        }
    }
}
