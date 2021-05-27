using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticeApiForDStore.Entities
{
    public class Staff
    {
        public long Staff_Id { get; set; }

        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public string Gender { get; set; }

        public string Phone_Number { get; set; }

        public long Address_Id { get; set; }

        public int Role_Id { get; set; }

        public long Salary { get; set; }


        public Role Role { get; set; }

        public Address Address { get; set; }

    }
}
