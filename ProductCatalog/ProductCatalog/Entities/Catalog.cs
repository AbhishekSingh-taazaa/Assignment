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

        Category category = new Category();

        Product product = new Product();
        //public Catalog()
        //{
        //    Catalog.OperationOnCategory = new OperationOnCategory();
        //    this.OperationOnProducts = new OperationOnProducts();
        //}
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


        // Category Catalog
        public void DisplayCategoryCatalog()
        {

            //           a. Enter a Category.

            //    b.List all Categories

            //c.Delete a Category(Enter Short Code or ID to delete)

            //d.Search a Category(By Id, Name or Short Code)

            Console.WriteLine("1. Enter a Category");
            Console.WriteLine("2. List all Categories");
            Console.WriteLine("3. Delete a Category");
            Console.WriteLine("4. Search a Category");
            Console.WriteLine("5. Exit");

            bool categoryStop = false;

            while (categoryStop != true)
            {
                int l = Convert.ToInt32(Console.ReadLine());
                switch (l)
                {

                    case 1:
                        Console.WriteLine("Enter a Category");
                       
                        break;
                    case 2:
                        Console.WriteLine("List all Categories");
                       
                        break;
                    case 3:
                        Console.WriteLine("Delete a Category");
                       
                        break;
                    case 4:
                        Console.WriteLine("Search a Category");
                       
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

//            Enter a Product.

//  b.List all products.

// c.Delete a Product(Enter Short Code or ID to delete)

//d.Search a Product(By Id, Name, Short Code, Selling Price Greater than / Less Than / Equal To entered price)
            Console.WriteLine("1.  Enter a Product");
            Console.WriteLine("2. List all products");
            Console.WriteLine("3. Delete a Product(Enter Short Code or ID to delete)");
            Console.WriteLine("4. Search a Product");
            Console.WriteLine("5. Exit");

            bool ProductStop = false;

            while (ProductStop != true)
            {
                int i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {

                    case 1:
                        Console.WriteLine("Enter a Product");

                        break;
                    case 2:
                        Console.WriteLine("List all Product");

                        break;
                    case 3:
                        Console.WriteLine("Delete a Product");

                        break;
                    case 4:
                        Console.WriteLine("Search a Product");

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
