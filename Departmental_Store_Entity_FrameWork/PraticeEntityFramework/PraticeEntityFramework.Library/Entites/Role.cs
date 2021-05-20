using System;
using System.Collections.Generic;
using System.Text;

namespace PraticeEntityFramework.Library.Entites
{
   public class Role
    {
        public int Role_Id { get; set; }

        public string Role_Name { get; set; }

        public string Description { get; set; }

        public ICollection<Staff> Staff { get; set; }
    }
}
