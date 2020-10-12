using System;
using System.Collections.Generic;
using System.Text;

namespace BeerhallEF.Models
{
    public class CategoryBrewer
    {
        public int BrewerId { get; set; }
        public int CategoryId { get; set; }
        public Brewer Brewer { get; set; }
        public Category Category { get; set; }


        protected CategoryBrewer()
        {

        }

        public CategoryBrewer(Category category, Brewer brewer)
        {
            Category = category;
            Brewer = brewer;

            BrewerId = Brewer.BrewerId;
            CategoryId = Category.CategoryId;
        }


       
    }
}
