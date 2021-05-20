using System;
using System.Collections.Generic;
using System.Text;

namespace PraticeEntityFramework.Library.Entites
{
  public  class ProductCategory
    {
        public int ProductCategory_Id { get; set; }

        public string Category_Name { get; set; }


        public ICollection<Product>  Product { get; set; }

    }
}
