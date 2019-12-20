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
            var categoryDto = categories.Select(category => new CategoryDTO
            {
                Id = category.Id,
                Name = category.CategoryName,
                Description = category.CategoryDescription
            }).ToList();

            return categoryDto;
        }

        public static CategoryDTO GetCategoryDto(this Category category)
        {
            var categoryDto = new CategoryDTO
            {
                Id = category.Id,
                Name = category.CategoryName,
                Description = category.CategoryDescription
            };

            return categoryDto;
        }

        public static Category GetCategory(this CategoryDTO categoryDto)
        {
            var category = new Category
            {
                Id = categoryDto.Id,
                CategoryName = categoryDto.Name,
                CategoryDescription = categoryDto.Description
            };

            return category;
        }
    }
}