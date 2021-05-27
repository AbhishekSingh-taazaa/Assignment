using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticeApiForDStore.Entities
{
    public class Product
    {
        public string Product_Code { get; set; }

        public string Product_Name { get; set; }
        public int ProductCategory_Id { get; set; }

        public DateTime Manufacturing_Date { get; set; }

        public DateTime Expiry_Date { get; set; }



        public ProductCategory ProductCategory { get; set; }
        public Inventory Inventory { get; set; }

        public ICollection<ProductPrice> ProductPrice { get; set; }
        public ICollection<OrderDetail> OrderDetail { get; set; }

    }
}
