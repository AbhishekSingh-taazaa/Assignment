using CsvHelper.Configuration;
using ProductLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary.EntityCSVMapper
{
   public class CategoryMapper : ClassMap<Category>
    {
        public CategoryMapper()
        {
            Map(m => m.Id).Index(0).Name("Id");
            Map(m => m.Name).Index(1).Name("Name");
            Map(m => m.ShortCode).Index(2).Name("ShortCode");
            Map(m => m.Description).Index(3).Name("Description");
        }
    }
}