using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticeApiForDStore.Entities
{
    public class Supplier
    {
        public long Supplier_Id { get; set; }

        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public string Gender { get; set; }

        public string Phone_Number { get; set; }
        public string Email { get; set; }

        public long Address_Id { get; set; }

        public Address Address { get; set; }


        public ICollection<OrderDetail> OrderDetail { get; set; }

    }
}
