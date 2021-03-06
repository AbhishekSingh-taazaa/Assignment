using ProductLibrary.Entities;
using ProductLibrary.OperationsOnFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductConsole.Operations
{
   public class CategoryOperations
    {
      

        public  string CategoryFilePathForOperations { get;} 

        OperationOnCategoryFile operationOnCategoryFile { get; set; }

        public CategoryOperations(string categoryFilePath)
        {
            CategoryFilePathForOperations = categoryFilePath;
            operationOnCategoryFile = new OperationOnCategoryFile(CategoryFilePathForOperations);
        }

        public void AddCategory()
        {
            Console.WriteLine("Enter Category Details :");

            Console.WriteLine("Enter New Category Name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter ShortCode ");
            string categoryshortcode = Console.ReadLine();

            Console.WriteLine("\nEnter Description : ");
            string description = Console.ReadLine();

            if (name.Length <= 0 || description.Length <= 0 || categoryshortcode.Length <= 0)
            {

                Console.WriteLine("All fields are mandatory...!");
                return;
            }
            if (categoryshortcode.Length > 4)
            {

                Console.WriteLine("ShortCode Range between 0 to 5");
                return;
            }

            if (OperationOnCategoryFile.categoriesShortCoeds.Contains(categoryshortcode))
            {

                Console.WriteLine("ShortCode Mustbe Unique");
                return;
            }

            operationOnCategoryFile.Add(new Category
            {
                Name = name,
                Description = description,
                ShortCode = categoryshortcode
            });

            Console.WriteLine("New Catogery Added succesfully");

        }

        public void DisplayCategories()
        {

             operationOnCategoryFile.ListOfCategoryCSV().ForEach(x => Console.WriteLine(x.ToString()));
        }
        public void DeleteCategory()
        {
            bool ExitDelete = false;
            while (ExitDelete != true)
            {
                Console.WriteLine("----- Deleting Product");
                Console.WriteLine("1. Delete by Short Code");
                Console.WriteLine("2. Delete by Id ");
                Console.WriteLine("3. Delete by Name ");
                Console.WriteLine("4. Exit");
                int i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Enter Short Code");
                        string categoryshortcode = Console.ReadLine();
                        try
                        {


                            operationOnCategoryFile.RemoveFromCategoryCSVByShortCode(categoryshortcode);
                            Console.WriteLine("Removed ..!");

                        }
                        catch (System.InvalidOperationException) { Console.WriteLine("Category not found"); }

                        break;
                    case 2:
                        Console.WriteLine("Enter Id : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        try
                        {

                            operationOnCategoryFile.RemoveFromCategoryCSVById(id);
                            Console.WriteLine("Removed Successfully");
                        }
                        catch (Exception) { Console.WriteLine("Category not found"); }

                        break;
                    case 3:
                        Console.WriteLine("Enter Name : ");
                        string inputName = Console.ReadLine();
                        try
                        {
                            operationOnCategoryFile.RemoveFromCategoryCSVByName(inputName);
                            Console.WriteLine("Removed Successfully");
                        }
                        catch (System.InvalidOperationException) { Console.WriteLine("Category not found"); }


                        break;
                    case 4:
                        ExitDelete = true;
                        Console.WriteLine("Exiting..............");
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid Operation\nTry Again");
                        break;
                }
            }


        }
        public void SearchCategory()
        {
            int i = 0;
            bool ExitSearch = false;
            while (ExitSearch != true)
            {
                Console.WriteLine("----- Search A Product -----");
                Console.WriteLine("1. By Id");
                Console.WriteLine("2. By Name");
                Console.WriteLine("3. By Short Code");
                Console.WriteLine("4. Exit");

                try { i = Convert.ToInt32(Console.ReadLine()); }
                catch (System.FormatException)
                {

                    Console.WriteLine("Please Enter a number...!");
                    i = Convert.ToInt32(Console.ReadLine());


                }

                switch (i)
                {
                    case 1:
                        Console.WriteLine("Enter Id To Search");
                        int id = Convert.ToInt32(Console.ReadLine());
                        try
                        {

                          Category categoryfind = operationOnCategoryFile.findInCategoryCSVById(id);
                            Console.WriteLine(categoryfind.ToString());
                            Console.WriteLine("Found Succesfully");
                        }
                        catch (Exception) { Console.WriteLine("Category not found"); }
                        break;
                    case 2:
                        Console.WriteLine("Enter Name ");
                        string name = Console.ReadLine();
                        try
                        {
                            Category categoryfind = operationOnCategoryFile.findInCategoryCSVByName(name);
                            Console.WriteLine(categoryfind.ToString());
                        }
                        catch (System.InvalidOperationException) { Console.WriteLine("Category not found"); }

                        break;
                    case 3:
                        Console.WriteLine("Enter Short Code");
                        string categoryshortcode = Console.ReadLine();
                        try
                        {

                            Category categoryfind = operationOnCategoryFile.findInCategoryCSVByShortCode(categoryshortcode);
                            Console.WriteLine(categoryfind.ToString());

                        }
                        catch (System.InvalidOperationException) { Console.WriteLine("Category not found"); }

                        break;
                    case 4:
                        ExitSearch = true;
                        Console.WriteLine("Exiting..............");
                        Console.Clear();

                        break;
                    default:
                        Console.WriteLine("Invalid Operation\nTry Again");
                        break;

                }

            }
        }
    }
}
