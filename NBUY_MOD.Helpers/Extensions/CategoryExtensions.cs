using System.Collections.Generic;
using System.Linq;

using NBUY_MOD.Entities.DTO;
using NBUY_MOD.Entities.Entity;

namespace NBUY_MOD.Helpers.Extensions
{
    public static class CategoryExtensions
    {
        public static List<CategoryDTO> GetCategoryDto(this IEnumerable<Category> categories)
        {
            var categoryDtos = categories.Select(i => new CategoryDTO
            {
                CategoryName = i.CategoryName
            }).ToList();

            return categoryDtos;
        }

    }
}