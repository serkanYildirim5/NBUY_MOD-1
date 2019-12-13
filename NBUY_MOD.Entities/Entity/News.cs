using System.ComponentModel.DataAnnotations.Schema;

namespace NBUY_MOD.Entities.Entity
{
    public class News
    {
        public int Id { get; set; }

        public string NewsName { get; set; }

        public string NewsDescription { get; set; }

        //NewsDetails
        public string NewsTitle { get; set; }

        public string NewsSubTitle { get; set; }

        public string NewsContent { get; set; }

        public string NewsImagePath { get; set; }

        public Category Category { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
    }
}