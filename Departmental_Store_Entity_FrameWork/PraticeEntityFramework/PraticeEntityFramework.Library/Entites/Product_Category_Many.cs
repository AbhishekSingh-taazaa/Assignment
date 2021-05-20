using System;
using System.Collections.Generic;
using System.Text;

namespace PraticeEntityFramework.Library.Entites
{
  public  class Product_Category_Many
    {
        public string Product_Code { get; set; }

        public int Category_Id { get; set; }



        public Product Product { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }
}
