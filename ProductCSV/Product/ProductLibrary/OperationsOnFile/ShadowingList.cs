using ProductLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProductLibrary.OperationsOnFile
{
   public class ShadowingList<T> : List<T>
    {
        public static List<Product> products = new List<Product>();

        public static List<Category> categories = new List<Category>();
        public new void Add(T item) {

            if (typeof(T) == typeof(Product))
            {

                Console.WriteLine("I am the Generic Product");

            }
            else {

                Console.WriteLine("I am the Generic Category");
            
            }
            
        
        
        }
    }
}
