using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticeApiForDStore.Entities
{
    public class Address
    {
        public long Address_Id { get; set; }
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string Pincode { get; set; }

        public string City { get; set; }

        public string State { get; set; }


        public ICollection<Staff> Staff { get; set; }
        public ICollection<Customer> Customer { get; set; }
        public ICollection<Supplier> Supplier { get; set; }

        public ICollection<OrderDetail> OrderDetail { get; set; }

    }
}
