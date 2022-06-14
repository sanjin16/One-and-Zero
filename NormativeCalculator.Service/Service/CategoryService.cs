﻿using AutoMapper;
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
    public class CategoryService : ICategoryService
    {
        private readonly NormativeCalculatorDbContext _context;
        private readonly IMapper _mapper;
        public CategoryService(NormativeCalculatorDbContext context, IMapper mapper)
        {
            _context = context; 
            _mapper = mapper;
        }
        public async Task<GetCategoryDto> GetCategoryByIdAsync(int id)
        {
            var entity = await _context.Category.FindAsync(id);

            return _mapper.Map<GetCategoryDto>(entity);
        }
        public async Task<PaginationModel<List<GetCategoryDto>>> GetCategoryAsync(int skip)
        {
            var list = await _context.Category.OrderByDescending(c => c.DateCreated).Skip(skip).Take(10).ToListAsync();
            var data = _mapper.Map<List<GetCategoryDto>>(list);
            var count = _context.Category.Count();
            return new PaginationModel<List<GetCategoryDto>>(data, count);
        }

        public async Task<GetCategoryDto> AddRecipeCategoryAsync(AddCategoryRequestDto request)
        {
            var entity = _mapper.Map<Category>(request);
            entity.DateCreated = DateTime.Now;

            await _context.Set<Category>().AddAsync(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<GetCategoryDto>(entity);
        }

        public async Task<GetCategoryDto> UpdateRecipeCategoryAsync(int id, AddCategoryRequestDto request)
        {
            var entity = await _context.Category.FindAsync(id);
            _context.Set<Category>().Update(entity);
            entity.DateCreated = DateTime.Now;

            _mapper.Map(request, entity);

            await _context.SaveChangesAsync();

            return _mapper.Map<GetCategoryDto>(entity);
        }

        public async Task<bool> DeleteRecipeCategoryAsync(int Id)
        {
            var entity = await _context.Category.Where(i => i.Id == Id).FirstOrDefaultAsync();
            if (entity != null)
            {
                _context.Category.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
           return false;
        }
    }
}
