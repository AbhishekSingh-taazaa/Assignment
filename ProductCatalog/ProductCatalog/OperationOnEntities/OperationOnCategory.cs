using ProductCatalog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductCatalog.OperationOnEntities
{
    public class OperationOnCategory
    {
        public static List<Category> categoryList = new List<Category>
        {
                new Category
                {
                    Name="Grocery",
                    Description="Necessary Items"
                },
                new Category
                {
                    Name="Food",
                    Description="Daily accomodation"
                }
        };

        public void AddCategory()
        {
            Console.WriteLine("Enter Category Details :");
            Console.WriteLine($"ID : {Category.AutoIncrement}\n");
            Console.WriteLine("Enter New Category Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("\nEnter Description : ");
            string description = Console.ReadLine();
            categoryList.Add(new Category
            {
                Name = name,
                Description = description,
            });
            Console.WriteLine("New Catogery Added succesfully");

        }
        public void DisplayCategories()
        {
            Console.WriteLine("Catogriess Are:");
            foreach (Category c in categoryList)
            {
                Console.WriteLine("Id : " + c.Id + "\nName : " + c.Name + "\nDescription : " + c.Description + "\nShort Code : Null\n\n\n");
            }

        }
        public void DeleteCategory()
        {
            bool ExitDelete = false;
            while (ExitDelete != true)
            {
                Console.WriteLine("----- Deleting Product");
                Console.WriteLine("a. Delete by Name");
                Console.WriteLine("b. Delete by Id ");
                Console.WriteLine("c. Delete by Short Code ");
                Console.WriteLine("d. Exit");
                switch (Console.ReadLine().ToLower())
                {
                    case "a":
                        break;
                    case "b":
                        Console.WriteLine("Enter Id : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        var findid = categoryList.Single(s => id == s.Id);
                        categoryList.Remove(findid);
                        Console.WriteLine("Removed Successfully");
                        break;
                    case "c":
                        Console.WriteLine("Enter Name : ");
                        string inputName = Console.ReadLine();
                        var findname = categoryList.Single(s => inputName == s.Name);
                        categoryList.Remove(findname);
                        Console.WriteLine("Removed Successfully");
                        break;
                    case "d":
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
            bool ExitSearch = false;
            while (ExitSearch != true)
            {
                Console.WriteLine("----- Search A Product -----");
                Console.WriteLine("a. By Id");
                Console.WriteLine("b. By Name");
                Console.WriteLine("c. By Short Code");
                Console.WriteLine("d. Exit");
                switch (Console.ReadLine().ToLower())
                {
                    case "a":
                        Console.WriteLine("Enter Id To Search");
                        int id = Convert.ToInt32(Console.ReadLine());
                        var Prod = categoryList.Single(s => id == s.Id);
                        Console.WriteLine("\nID : " + Prod.Id);
                        Console.WriteLine("\nName : " + Prod.Name);
                        Console.WriteLine("\nDescription : " + Prod.Description);
                        Console.WriteLine("Found Succesfully");
                        break;
                    case "b":
                        Console.WriteLine("Enter Name ");
                        string name = Console.ReadLine();
                        var findname = categoryList.Single(s => name == s.Name);
                        Console.WriteLine("Product Id - " + findname.Id + " Name - " + findname.Name + " Description - " + findname.Description);
                        break;
                    case "c":
                        break;
                    case "d":
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
