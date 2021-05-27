using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticeApiForDStore.Entities
{
    public class OrderDetail
    {
        public int Order_Id { get; set; }

        public long Supplier_Id { get; set; }

        public long Customer_Id { get; set; }

        public string Product_Code { get; set; }

        public int Ordered_Quantity { get; set; }


        public DateTime Date_Of_Order { get; set; }

        public DateTime Date_Of_Delivery { get; set; }

        public long Address_Id { get; set; }


        public Product Product { get; set; }

        public Supplier Supplier { get; set; }

        public Customer Customer { get; set; }


        public Address Address { get; set; }

    }
}
