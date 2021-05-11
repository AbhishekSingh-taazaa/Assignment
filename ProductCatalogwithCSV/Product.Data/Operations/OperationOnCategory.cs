using Product.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data.Operations
{
   public class OperationOnCategory
    {
        public static List<Category> categoryList = new List<Category>
        {
                new Category
                {
                    Name="Grocery",
                    Description="Necessary Items",
                    ShortCode = "Gro"

                },
                new Category
                {
                    Name="Food",
                    Description="Daily accomodation",
                     ShortCode = "Foo"
                }
        };

        public static HashSet<string> CategoryShortCode = new HashSet<string> { "Gro", "Foo" };


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

            if (CategoryShortCode.Contains(categoryshortcode))
            {

                Console.WriteLine("ShortCode Mustbe Unique");
                return;
            }
            categoryList.Add(new Category
            {
                Name = name,
                Description = description,
                ShortCode = categoryshortcode
            });
            Console.WriteLine("New Catogery Added succesfully");

        }

        public void DisplayCategories()
        {
            Console.WriteLine("Catogriess Are:");
            foreach (Category c in categoryList)
            {
                Console.WriteLine(c.ToString());
            }

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
                            var findcshortcode = categoryList.Single(code => code.ShortCode == categoryshortcode);
                            categoryList.Remove(findcshortcode);
                            OperationOnProducts.Products.RemoveAll(finding => finding.ProductCategory == findcshortcode.Name);

                            Console.WriteLine("Removed ..!");

                        }
                        catch (System.InvalidOperationException) { Console.WriteLine("Category not found"); }

                        break;
                    case 2:
                        Console.WriteLine("Enter Id : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            var findid = categoryList.Single(s => id == s.Id);
                            categoryList.Remove(findid);
                            OperationOnProducts.Products.RemoveAll(finding => finding.ProductCategory == findid.Name);
                            Console.WriteLine("Removed Successfully");
                        }
                        catch (System.InvalidOperationException) { Console.WriteLine("Category not found"); }

                        break;
                    case 3:
                        Console.WriteLine("Enter Name : ");
                        string inputName = Console.ReadLine();
                        try
                        {
                            var findname = categoryList.Single(s => inputName == s.Name);
                            categoryList.Remove(findname);
                            OperationOnProducts.Products.RemoveAll(finding => finding.ProductCategory == findname.Name);
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
                            var Prod = categoryList.Single(s => id == s.Id);
                            Console.WriteLine(Prod.ToString());
                            Console.WriteLine("Found Succesfully");
                        }
                        catch (System.InvalidOperationException) { Console.WriteLine("Category not found"); }
                        break;
                    case 2:
                        Console.WriteLine("Enter Name ");
                        string name = Console.ReadLine();
                        try
                        {
                            var findname = categoryList.Single(s => name == s.Name);
                            Console.WriteLine(findname.ToString());
                        }
                        catch (System.InvalidOperationException) { Console.WriteLine("Category not found"); }

                        break;
                    case 3:
                        Console.WriteLine("Enter Short Code");
                        string categoryshortcode = Console.ReadLine();
                        try
                        {

                            var findcshortcode = categoryList.Single(code => code.ShortCode == categoryshortcode);

                            Console.WriteLine(findcshortcode.ToString());

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
