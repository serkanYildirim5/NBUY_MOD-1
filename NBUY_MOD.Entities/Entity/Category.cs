using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NBUY_MOD.Entities.Entity
{
    public class Category
    {
        public Category()
        {
            News = new List<News>();
        }

        public int Id { get; set; }

        [Display(Name = "KATEGORI ADI")]
        [MinLength(5, ErrorMessage = "{0} uzunluğu en az {1} karakter olmalıdır!")]
        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public IEnumerable<News> News { get; set; }


    }
}