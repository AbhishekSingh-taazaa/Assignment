using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data.Entites
{
  public class Category
    {
        public static int AutoIncrement = 0;
        public int Id { get; set; }
        public string Name { get; set; }

        public string ShortCode { get; set; }
        public string Description { get; set; }

        public Category()
        {
            AutoIncrement++;
            Id = AutoIncrement;
        }

        public override string ToString()
        {
            return $"Id -- {this.Id}\nName -- {this.Name} \nDescription -- {this.Description} \nShortCode -- {this.ShortCode}\n\n\n";
        }
    }
}
