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
            using (ProjectContext database = new ProjectContext())
            {
                categories = database.Categories.ToList();
            }

            return categories;
        }
    }
}