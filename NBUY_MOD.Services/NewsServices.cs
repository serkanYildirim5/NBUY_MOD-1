using System.Collections.Generic;

using NBUY_MOD.DAL.Repository;
using NBUY_MOD.Entities;

namespace NBUY_MOD.Services
{
    public class NewsServices
    {
        private readonly NewsRepository _newsRepository;

        public NewsServices()
        {
            _newsRepository = new NewsRepository();
        }

        public List<News> GetNews()
        {
            var newsList = _newsRepository.GetAllNews();

            return newsList;
        }

        //TODO burası hatalı kullanım olacak çünkü; EF Bağımlılığı var | SRP , OCP
        //public List<News> GetAllNews()
        //{
        //    List<News> list = new List<News>();
        //    using (ProjectContext database = new ProjectContext())
        //    {
        //        list = database.News.ToList();
        //    }
        //}
    }
}