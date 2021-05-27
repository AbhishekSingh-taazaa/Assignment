using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticeApiForDStore.Models
{
    public class ProductPriceModel
    {
        public string Product_Code { get; set; }

        public decimal Cost_Price { get; set; }

        public decimal Selling_Price { get; set; }

        public DateTime Date_Of_Register { get; set; }


    }
}
