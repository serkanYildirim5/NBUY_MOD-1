using System.Collections.Generic;

using NBUY_MOD.Entities.DTO;

//Extensions
namespace NBUY_MOD.Models
{
    public class HomeIndexViewModel
    {
        public HomeIndexViewModel()
        {
            News = new List<NewsDTO>();
            Categories = new List<CategoryDTO>();
        }

        public List<NewsDTO> News { get; set; }

        public List<CategoryDTO> Categories { get; set; }

    }
}