using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using NBUY_MOD.DAL.Database;
using NBUY_MOD.Entities.Entity;

namespace NBUY_MOD.DAL.Repository
{
    public class NewsRepository
    {
        public List<News> GetAllNews()
        {
            List<News> news;
            using (ProjectContext databaseContext = new ProjectContext())
            {
                //news = databaseContext.News.ToList();
                //news = databaseContext.News.Include(i => i.Category).ToList();
                news = databaseContext.News.Include("Category").ToList();
            }

            return news;
        }
    }
}