using System.Collections.Generic;
using System.Linq;

using NBUY_MOD.Entities.DTO;
using NBUY_MOD.Entities.Entity;

namespace NBUY_MOD.Helpers.Extensions
{
    public static class NewsExtensions
    {
        public static NewsDTO GetNewsDto(News news)
        {
            NewsDTO DTONews = new NewsDTO
            {
                NewsSubTitle = news.NewsSubTitle,
                NewsTitle = news.NewsTitle,
                NewsImagePath = news.NewsImagePath,
                NewsInformation = news.NewsContent.Substring(0, 20)
            };

            return DTONews;
        }

        public static List<NewsDTO> GetNewsDto(this IEnumerable<News> news)
        {
            List<NewsDTO> newsList = news.Select(i => new NewsDTO
            {
                NewsSubTitle = i.NewsSubTitle,
                NewsTitle = i.NewsTitle,
                NewsImagePath = i.NewsImagePath,
                NewsInformation = i.NewsContent.Substring(0, 20),
                CategoryName = i.Category.CategoryName
            }).ToList();

            return newsList;
        }
    }
}