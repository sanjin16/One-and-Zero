using NormativeCalculator.Database.Helper;
using NormativeCalculator.DTOs.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NormativeCalculator.Service.Interface
{
    public interface ICategoryService
    {
        Task<PaginationModel<List<GetCategoryDto>>> GetCategoryAsync(int skip);
        Task<GetCategoryDto> GetCategoryByIdAsync(int id);
        Task<GetCategoryDto> AddCategoryAsync(AddCategoryRequestDto request);
        Task<GetCategoryDto> UpdateCategoryAsync(int id, AddCategoryRequestDto request);
        Task<GetCategoryDto> DeleteCategoryAsync(int id);
    }
}
