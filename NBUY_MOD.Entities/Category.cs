using System.Collections;
using System.Collections.Generic;

namespace NBUY_MOD.Entities
{
    public class Category
    {
        public Category()
        {
            News = new List<News>();
        }

        public int Id { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public IEnumerable<News> News { get; set; }


    }
}