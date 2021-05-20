using System;
using System.Collections.Generic;
using System.Text;

namespace PraticeEntityFramework.Library.Entites
{
   public class ProductPrice
    {
        public string Product_Code { get; set; }

        public  decimal Cost_Price { get; set; }

        public decimal Selling_Price { get; set; }

        public DateTime Date_Of_Register { get; set; }

        public Product Product { get; set; }
    }
}
