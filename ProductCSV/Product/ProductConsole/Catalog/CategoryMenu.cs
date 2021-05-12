using ProductConsole.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductConsole.Catalog
{
   public class CategoryMenu
    {
        public string CategoryFilePath { get; }
        public CategoryMenu(string categoryFilePath)
        {
            this.CategoryFilePath = categoryFilePath;
            this.DisplayCategoryCatalog();
        }

        public void DisplayCategoryCatalog()
        {
            CategoryOperations categoryOperations = new CategoryOperations(CategoryFilePath);
            

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
                        categoryOperations.AddCategory();

                        break;
                    case 2:

                        categoryOperations.DisplayCategories();

                        break;
                    case 3:
                        categoryOperations.DeleteCategory();

                        break;
                    case 4:
                        categoryOperations.SearchCategory();
                        break;
                    case 5:
                        categoryStop = true;
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
