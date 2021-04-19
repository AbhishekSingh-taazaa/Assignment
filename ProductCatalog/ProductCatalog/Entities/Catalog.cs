using System;
using System.Collections.Generic;
using System.Text;
using ProductCatalog.OperationOnEntities;

namespace ProductCatalog.Entities
{
    public class Catalog
    {
        public static OperationOnCategory OperationOnCategory { get; set; }
        public OperationOnProducts OperationOnProducts  { get; set; }
        public Catalog()
        {
            Catalog.OperationOnCategory = new OperationOnCategory();
            this.OperationOnProducts = new OperationOnProducts();
        }
        public void DisplayCatalog()
        {
            bool stop = false;
            while(stop != true)
            Console.WriteLine("--welcome--");
            Console.WriteLine("1. Category ");
            Console.WriteLine("2. Product");
            Console.WriteLine("3. Exit the App");


            int i = Int32.TryParse(Console.ReadLine());
            switch (i) {

                case 1 :
                    Console.WriteLine("Category Catalog");
                    break;
                case 2:
                    Console.WriteLine("Product Catalog");
                    break;
                case 3:
                    stop = true;
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    break;
            }         
            
        }

    }
}
