using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticeApiForDStore.Entities
{
    public class ProductCategory
    {
        public int ProductCategory_Id { get; set; }

        public string Category_Name { get; set; }


        public ICollection<Product> Product { get; set; }
    }
}
