using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticeApiForDStore.Models
{
    public class ProductModel
    {
        public string Product_Code { get; set; }

        public string Product_Name { get; set; }
        public string Category_Name { get; set; }


        public DateTime Manufacturing_Date { get; set; }

        public DateTime Expiry_Date { get; set; }


        public List<ProductPriceModel> ProductPrice { get; set; }

        public InventoryModel Inventory { get; set; }
    }
}
