using System.Collections.Generic;
using System.Linq;

using NBUY_MOD.DAL.Database;
using NBUY_MOD.Entities.Entity;

namespace NBUY_MOD.DAL.Repository
{
    public class CategoryRepository
    {
        public List<Category> GetAllCategories()
        {
            List<Category> categories;
            using (var database = new ProjectContext())
            {
                categories = database.Categories.ToList();
            }

            return categories;
        }

        public Category GetCategory(int id)
        {
            Category category;
            using (var databaseContext = new ProjectContext())
            {
                //category = databaseContext.Categories.Find(id);
                category = databaseContext.Categories.FirstOrDefault(i => i.Id.Equals(id));
            }
            return category;
        }
    }
}