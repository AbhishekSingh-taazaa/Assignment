using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticeApiForDStore.Models
{
    public class StaffModel 
    {
        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public string Gender { get; set; }

        public string Phone_Number { get; set; }

        public long Salary { get; set; }

        public long Address_Id { get; set; }

        public int Role_Id { get; set; }
        //        And take the department store structure and create APIs for - 



        //Create Staff Member
        //    Update Staff Member

        //    Get Staff Member(The query you had practiced, which included filters)

        //    Create Product

        //    Update Product

        //    Search for product(The query you had practice, which included filters)

        public RoleModel Role { get; set; }

        public AddressModel Address { get; set; }
    }
}
