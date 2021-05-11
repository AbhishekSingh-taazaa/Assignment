using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using prod = Product.Data.Entites;

namespace Product.Data.Mapping
{
   public class ProductMap : ClassMap<prod.Product>
    {
        public ProductMap()
        {
            Map(m => m.Id).Index(0).Name("Id");
            Map(m => m.Name).Index(1).Name("Name");
            Map(m => m.Manufacturer).Index(2).Name("Manufacturer");
            Map(m => m.ShortCode).Index(3).Name("ShortCode");
            Map(m => m.Description).Index(4).Name("Description");
            Map(m => m.SellingPrice).Index(5).Name("SellingPrice");
            Map(m => m.ProductCategory).Index(6).Name("ProductCategory");
          

        }
    }
}
