using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

using NBUY_MOD.DAL.Repository;
using NBUY_MOD.Entities.DTO;
using NBUY_MOD.Entities.Entity;
using NBUY_MOD.Helpers.Extensions;

namespace NBUY_MOD.Services
{
    public class CategoryServices
    {
        private readonly CategoryRepository _categoryRepository;
        private static int _rowNumber;

        public CategoryServices()
        {
            _categoryRepository = new CategoryRepository();
            _rowNumber = Convert.ToInt32(ConfigurationManager.AppSettings["TopRowNumber"]);
        }

        public List<Category> GetCategories()
        {
            var categories = _categoryRepository.GetAllCategories();
            return categories;
        }


        public List<CategoryDTO> GetCategoriesDTO()
        {
            var categories = _categoryRepository.GetAllCategories();

            var categoryDto = categories.GetCategoryDto();

            return categoryDto;
        }

        public List<CategoryDTO> GetTopCategoriesDTO()
        {
            var categories = _categoryRepository.GetAllCategories();

            var categoryDto = categories.Take(_rowNumber).GetCategoryDto();

            return categoryDto;
        }

        public Category GetCategory(int id)
        {
            if (id < 0)
                return null;

            var result = _categoryRepository.GetCategory(id);

            return result;
        }
    }
}