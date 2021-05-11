using Product.Data.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data.Entites
{
   public class Catalog
    {

        OperationOnProducts OperationOnProducts = new OperationOnProducts();
        OperationOnCategory operationOnCategory = new OperationOnCategory();

        public void DisplayCatalog()
        {
            Console.WriteLine("--welcome--");
            Console.WriteLine("1. Category ");
            Console.WriteLine("2. Product");
            Console.WriteLine("3. Exit the App");

            bool stop = false;
            while (stop != true)
            {


                int k = Convert.ToInt32(Console.ReadLine());
                switch (k)
                {

                    case 1:
                        Console.WriteLine("Category Catalog");
                        this.DisplayCategoryCatalog();
                        stop = true;
                        break;

                    case 2:
                        Console.WriteLine("Product Catalog");
                        this.DisplayProductCatalog();
                        stop = true;
                        break;
                    case 3:
                        stop = true;
                        Console.WriteLine("Exiting...");

                        break;
                    default:
                        Console.WriteLine("Invalid Operation");

                        break;
                }

                Console.Clear();
            }

        }
        //Category Catalog
        public void DisplayCategoryCatalog()
        {
            bool categoryStop = false;
            while (categoryStop != true)
            {
                Console.WriteLine("1. Enter a Category");
                Console.WriteLine("2. List all Categories");
                Console.WriteLine("3. Delete a Category");
                Console.WriteLine("4. Search a Category");
                Console.WriteLine("5. Exit");
                int l = Convert.ToInt32(Console.ReadLine());
                switch (l)
                {
                    case 1:
                        Console.WriteLine("Enter a Category");
                        operationOnCategory.AddCategory();

                        break;
                    case 2:

                        operationOnCategory.DisplayCategories();

                        break;
                    case 3:
                        operationOnCategory.DeleteCategory();

                        break;
                    case 4:
                        operationOnCategory.SearchCategory();
                        break;
                    case 5:
                        categoryStop = true;
                        Console.WriteLine("Exiting");
                        Console.Clear();
                        this.DisplayCatalog();
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;

                }

            }

        }
        // Product Catelog
        public void DisplayProductCatalog()
        {
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
                        OperationOnProducts.AddProduct();

                        break;
                    case 2:
                        Console.WriteLine("List all Product");
                        OperationOnProducts.DisplayProduct();

                        break;
                    case 3:
                        Console.WriteLine("Delete a Product");
                        OperationOnProducts.DeleteProduct();
                        break;
                    case 4:
                        Console.WriteLine("Search a Product");
                        OperationOnProducts.findProduct();
                        break;
                    case 5:
                        ProductStop = true;
                        Console.WriteLine("Exiting");
                        Console.Clear();
                        this.DisplayCatalog();
                        break;

                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }

            }

        }
    }
}
