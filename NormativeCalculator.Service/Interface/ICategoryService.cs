using NormativeCalculator.Database.Entities;
using NormativeCalculator.Database.Helper;
using NormativeCalculator.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Service.Interface
{
    public interface ICategoryService
    {
        Task<PaginationModel<List<GetCategoryDto>>> GetCategoryAsync(int skip);
        Task<GetCategoryDto> GetCategoryByIdAsync(int id);
        Task<GetCategoryDto> AddRecipeCategoryAsync(AddCategoryRequestDto request);
        Task<GetCategoryDto> UpdateRecipeCategoryAsync(int id, AddCategoryRequestDto request);
        Task<bool> DeleteRecipeCategoryAsync(int id);
    }
}
