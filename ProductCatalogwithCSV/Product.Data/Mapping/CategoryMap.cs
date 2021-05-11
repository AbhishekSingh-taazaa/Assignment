using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using Product.Data.Entites;

namespace Product.Data.Mapping
{
   public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Map(m => m.Id).Index(0).Name("Id");
            Map(m => m.Name).Index(1).Name("Name");
            Map(m => m.ShortCode).Index(2).Name("ShortCode");
            Map(m => m.Description).Index(3).Name("Description");
        }
    }
}
