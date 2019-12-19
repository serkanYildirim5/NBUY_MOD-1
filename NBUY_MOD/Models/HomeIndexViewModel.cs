using System.Collections.Generic;

using NBUY_MOD.Entities.DTO;

//Extensions
namespace NBUY_MOD.Models
{
    public class HomeIndexViewModel
    {
        public List<NewsDTO> News { get; set; }

        public List<CategoryDTO> Categories { get; set; }

    }
}