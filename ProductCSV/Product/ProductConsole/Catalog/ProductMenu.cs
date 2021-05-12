using ProductConsole.Operations;
using ProductLibrary.OperationsOnFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductConsole.Catalog
{
   public class ProductMenu
    {
        
        public string ProductFilePath { get; }

       
        public ProductMenu(string productFilePath)
        {
            this.ProductFilePath = productFilePath;
            this.DisplayProductCatalog();
        }

        public void DisplayProductCatalog()
        {
            ProductOperations productOperations = new ProductOperations(ProductFilePath);
           
            bool ProductStop = false;
            while (ProductStop != true)
            {

                Console.WriteLine("1. Add a Product");
                Console.WriteLine("2. List all Products");
                Console.WriteLine("3. Delete a Product(Enter Short Code or ID to delete)");
                Console.WriteLine("4. Search a Product");
                Console.WriteLine("5. Exit");

                int i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {

                    case 1:
                        Console.WriteLine("Enter a Product Details");
                        productOperations.AddProduct();

                        break;
                    case 2:
                        Console.WriteLine("List all Product");
                        productOperations.DisplayProduct();

                        break;
                    case 3:
                        Console.WriteLine("Delete a Product");
                        productOperations.DeleteProduct();
                        break;
                    case 4:
                        Console.WriteLine("Search a Product");
                        productOperations.findProduct();
                        break;
                    case 5:
                        ProductStop = true;
                        Console.WriteLine("Exiting");
                        Console.Clear();
                       // this.DisplayCatalog();
                        break;

                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }

            }

        }

    }
}
