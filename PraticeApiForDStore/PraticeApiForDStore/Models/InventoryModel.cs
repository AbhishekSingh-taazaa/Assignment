using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticeApiForDStore.Models
{
    public class InventoryModel
    {

        public string Product_Code { get; set; }
        public string Brand_Name { get; set; }

        public long Product_Quantity { get; set; }

        public bool InStock { get; set; }
    }
}
