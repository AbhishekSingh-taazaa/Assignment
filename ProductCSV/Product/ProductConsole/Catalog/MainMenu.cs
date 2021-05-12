using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductConsole.Catalog
{
  public  class MainMenu
    {
        private string ProductFilePath { get; }
        public string  CategoryFilePath { get; }
        public MainMenu(string productfilePath,string categoryFilePath )
        {
            if (!File.Exists(productfilePath))
            {
                Console.WriteLine("Product File Not Exist");
                return;
            }
            else if (!File.Exists(categoryFilePath))
            {
                Console.WriteLine("Category File Not Exist");
                return;
            }
            else {

                this.ProductFilePath = productfilePath;
                this.CategoryFilePath = categoryFilePath;
                this.DisplayMainMenu();

            }
        }
        public void DisplayMainMenu() {

            bool stop = false;
            while (stop != true)
            {

                Console.WriteLine("--welcome--");
                Console.WriteLine("1. Category ");
                Console.WriteLine("2. Product");
                Console.WriteLine("3. Exit the App");


                int k = Convert.ToInt32(Console.ReadLine());
                switch (k)
                {

                    case 1:
                        Console.WriteLine("Category Catalog");
                        CategoryMenu categoryMenu = new CategoryMenu(CategoryFilePath);

                       // stop = true;
                        break;

                    case 2:
                        Console.WriteLine("Product Catalog");
                        ProductMenu productMenu = new ProductMenu(ProductFilePath);
                       // stop = true;
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
    }

}
