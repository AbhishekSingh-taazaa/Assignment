using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalog.Entities
{
    public class Category
    {
        public static int AutoIncrement = 0;
        public int Id { get; }
        public string Name { get; set; }

        public string ShortCode { get; set; }
        public string Description { get; set; }

        public Category()
        {
            AutoIncrement++;
            Id = AutoIncrement;
        }
    }
}
