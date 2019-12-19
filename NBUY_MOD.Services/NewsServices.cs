using System.Collections.Generic;

using NBUY_MOD.DAL.Repository;
using NBUY_MOD.Entities.DTO;
using NBUY_MOD.Entities.Entity;
using NBUY_MOD.Helpers.Extensions;

namespace NBUY_MOD.Services
{
    public class NewsServices
    {
        private readonly NewsRepository _newsRepository;

        public NewsServices()
        {
            _newsRepository = new NewsRepository();
        }

        public List<NewsDTO> GetNewsDTOs()
        {
            List<News> newsList = _newsRepository.GetAllNews();
            List<NewsDTO> dtoNewsList = newsList.GetNewsDto();

            return dtoNewsList;
        }

    }
}