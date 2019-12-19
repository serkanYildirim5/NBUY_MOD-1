using System.Collections.Generic;

using NBUY_MOD.Entities;
//Extensions
namespace NBUY_MOD.Models
{
    public class HomeIndexViewModel
    {
        public List<News> News { get; set; }

        public List<Category> Categories { get; set; }
    }
}