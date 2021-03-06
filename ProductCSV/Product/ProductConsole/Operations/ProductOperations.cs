using ProductLibrary.Entities;
using ProductLibrary.OperationsOnFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductConsole.Operations
{
   public class ProductOperations
    {
       
        public  string ProductFilePathForOperations { get; set; }
        OperationOnProductFile operationOnProductFile;
        public ProductOperations(string ProductFile)
        {
            ProductFilePathForOperations = ProductFile;
            operationOnProductFile = new OperationOnProductFile(ProductFilePathForOperations);
        }

           
        public void AddProduct()
        {


            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Manufactror Name");
            string manufacturer = Console.ReadLine();

            Console.WriteLine("Enter Description");
            string description = Console.ReadLine();

            Console.WriteLine("Enter Selling Price");
            int sellingprice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Short Code ");
            string shortcode = Console.ReadLine();

            Console.WriteLine("Enter category Of Product");
            string category = Console.ReadLine();
           // bool iscategoryPresent = false;
            //foreach (Category c in OperationOnCategory.categoryList)
            //{
            //    if (c.Name.ToLower() == category.ToLower())
            //        iscategoryPresent = true;
            //}
            //if (iscategoryPresent == false)
            //{
            //    Console.WriteLine("\nThis category is not Added You Have To Add This Category\n");
            //    operationCategory.AddCategory();
            //}

            if (name.Length <= 0 || sellingprice <= 0 || description.Length <= 0 || shortcode.Length <= 0 || manufacturer.Length <= 0)
            {

                Console.WriteLine("All fields are Mandatory");
                return;
            }

            if (shortcode.Length > 4)
            {

                Console.WriteLine("Shortcode Can't be greater than 4 digit ");
                return;

            }

            if (OperationOnProductFile.ProductShortCodes.Contains(shortcode))
            {

                Console.WriteLine("ShortCode Must Be Unique");
                return;
            }


            operationOnProductFile.Add(new Product
            {
               
                Name = name,
                Manufacturer = manufacturer,
                ShortCode = shortcode,
                Description = description,
                SellingPrice = sellingprice,
                ProductCategory = category

            });
          
        }

        public void DisplayProduct()
        {
            operationOnProductFile.ListOfProductCSV().ForEach(x => Console.WriteLine(x.ToString()));

        }


        public void DeleteProduct()
        {

            bool deleteProductstatus = false;

            while (deleteProductstatus != true)
            {

                Console.WriteLine("1. Delete by Id");
                Console.WriteLine("2. Delete by shortcode");
                Console.WriteLine("3. Delete by Name");
                Console.WriteLine("4. Exit");

                int i = Convert.ToInt32(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        Console.WriteLine("Enter Id");
                        int id = Convert.ToInt32(Console.ReadLine());

                        try
                        {
                            operationOnProductFile.RemoveFromProductCSVById(id);
                            Console.WriteLine("Removed Successfully");
                        }
                        catch (System.InvalidOperationException)
                        {

                            Console.WriteLine("Product Not Found!!");
                        }


                        break;
                    case 2:
                        Console.WriteLine("Enter ShortCode");
                        string shortcodee = Console.ReadLine();
                        try
                        {
                            operationOnProductFile.RemoveRemoveFromProductCSVByShortCode(shortcodee);
                        }
                        catch (System.InvalidOperationException)
                        {

                            Console.WriteLine("Product Not Found !!");
                        }

                        break;

                    case 3:
                        Console.WriteLine("Enter Name ");
                        string name = Console.ReadLine();
                        try
                        {
                            operationOnProductFile.RemoveRemoveFromProductCSVByName(name);
                            Console.WriteLine("Removed Successfully");
                        }
                        catch (System.InvalidOperationException)
                        {

                            Console.WriteLine("Product Not Found !!");
                        }


                        break;
                    case 4:
                        Console.WriteLine("Exiting.....");
                        deleteProductstatus = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }

            }


        }

        public void findProduct()
        {


            bool findProductstatus = false;

            while (findProductstatus != true)
            {
                Console.WriteLine("1. Find by Id");
                Console.WriteLine("2. Find by shortcode");
                Console.WriteLine("3. Find by Name");
               // Console.WriteLine("4. Filter  by Selling Price");
                Console.WriteLine("4. Exit");
                int i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Enter Id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        try
                        {

                            operationOnProductFile.findInProductCSVById(id).ToString();
                        }
                        catch (System.InvalidOperationException)
                        {
                            Console.WriteLine("Item Not Found !!");
                        }

                        break;
                    case 2:
                        Console.WriteLine("Enter Short Code");
                        string shortcodee = Console.ReadLine();
                        try
                        {
                            operationOnProductFile.findInProductCSVByShortCode(shortcodee).ToString();
                        }
                        catch (System.InvalidOperationException)
                        {

                            Console.WriteLine("Product Not Found !!");
                        }

                        break;

                    case 3:
                        Console.WriteLine("Enter Name ");
                        string name = Console.ReadLine();
                        try
                        {
                            operationOnProductFile.findInProductCSVByName(name).ToString();
                        }
                        catch (System.InvalidOperationException)
                        {
                            Console.WriteLine("Item Not Found !!");
                        }



                        break;
                    //case 4:
                    //    Console.WriteLine("Enter Selling Price - ");
                    //    //int sellingprice = Convert.ToInt32(Console.ReadLine());
                    //    //var maxlist = Products.Where(s => sellingprice > s.SellingPrice);
                    //    ////var minlist = Products.Where(s => sellingprice < s.SellingPrice);
                    //    //try
                    //    //{
                    //    //    var equal = Products.Single(s => sellingprice == s.SellingPrice);
                    //    //    Console.WriteLine("\nProduct having price equal to " + sellingprice);
                    //    //    Console.WriteLine(equal.ToString());
                    //    //}
                    //    //catch (Exception e)
                    //    //{
                    //    //    Console.WriteLine("Product Not found" + e.Message);
                    //    //}
                    //    //Console.WriteLine("Product having price greater than " + sellingprice);
                    //    //foreach (Prod.Product p in maxlist)
                    //    //{
                    //    //    Console.WriteLine(p.ToString());
                    //    //};
                    //    //Console.WriteLine("\nProduct having price less than " + sellingprice);
                    //    //foreach (Prod.Product p in minlist)
                    //    //{
                    //    //    Console.WriteLine(p.ToString());
                    //    //};
                    //    break;
                    case 4:
                        Console.WriteLine("Exiting.....");
                        findProductstatus = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }

            }


        }
    }
}
