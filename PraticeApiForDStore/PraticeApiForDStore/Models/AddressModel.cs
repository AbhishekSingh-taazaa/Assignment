using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticeApiForDStore.Models
{
    public class AddressModel
    {
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string Pincode { get; set; }

        public string City { get; set; }

        public string State { get; set; }
    }
}
