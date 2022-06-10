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
    public interface IRecipeCategoryService
    {
        Task<PaginationModel<List<RecipeCategoriesGetDto>>> GetRecipeCategoryAsync(int skip);
        Task AddRecipeCategoryAsync(RecipeCategoryInsertDto request);
        Task<bool> DeleteRecipeCategoryAsync(int ID);
    }
}
