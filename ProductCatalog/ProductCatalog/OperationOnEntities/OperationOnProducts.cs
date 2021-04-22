using ProductCatalog.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductCatalog.OperationOnEntities
{
    public class OperationOnProducts
    {
       public static List<Product> products = new List<Product> { 
       
           new Product{
           Name ="Rex",
           Description="Human",
           Manufacturer="Rex",
           SellingPrice=20000,
           ShortCode="rex",
           ProductCategory = "Engineer"
           },
            new Product{
           Name ="Duke",
           Description="Human",
           Manufacturer="Rex",
           SellingPrice=20000,
           ShortCode="Json",
           ProductCategory = "Engineer"
           },

       };
        OperationOnCategory operationCategory = new OperationOnCategory();
        public HashSet<string> ShortCode = new HashSet<string>();

        public void AddProduct() {

          
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
            bool iscategoryPresent = false;
            foreach (Category c in OperationOnCategory.categoryList)
            {
                if (c.Name.ToLower() == category.ToLower())
                    iscategoryPresent = true;
            }
            if (iscategoryPresent == false)
            {
                Console.WriteLine("\nThis category is not Added You Have To Add This Category\n");
                operationCategory.AddCategory();
            }

            if (name.Length <=0 || sellingprice <=0 || description.Length <= 0 || shortcode.Length <=0 || manufacturer.Length <=0 ) {

                Console.WriteLine("All fields are Mandatory");
                return;
            }

            if (shortcode.Length > 4) {

                Console.WriteLine("Shortcode Can't be greater than 4 digit ");
                return;

            }

            if (this.ShortCode.Contains(shortcode)) {

                Console.WriteLine("ShortCode Must Be Unique");
                return;
            }

            ShortCode.Add(shortcode);
            products.Add(new Product { 
            
                Name = name,
                Manufacturer = manufacturer,
                ShortCode = shortcode,
                Description = description,
                SellingPrice = sellingprice,
                ProductCategory = category

            });

           

        }

        public void DisplayProduct() {
        
       foreach(Product p in products) {

               Console.WriteLine(p.ToString());
            }
        
        }


        public void DeleteProduct() {

            bool deleteproductstatus = false;

            while (deleteproductstatus != true) {

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

                        try {
                            var findid = products.Single(s => id == s.Id);
                            products.Remove(findid);
                            Console.WriteLine("Removed Successfully");
                        } catch (System.InvalidOperationException) {

                            Console.WriteLine("Product Not Found!!");
                        }
                       
                       
                        break;
                    case 2:
                        Console.WriteLine("Enter ShortCode");
                        string shortcodee = Console.ReadLine();
                        try
                        {
                            var findshortcode = products.Single(s => shortcodee == s.ShortCode);
                            products.Remove(findshortcode);
                            Console.WriteLine("Removed Successfully");
                        }
                        catch (System.InvalidOperationException) {

                            Console.WriteLine("Product Not Found !!");
                        }
                       
                        break;

                    case 3:
                        Console.WriteLine("Enter Name ");
                        string name = Console.ReadLine();
                        try
                        {
                            var findname = products.Single(s => name == s.Name);
                            products.Remove(findname);
                            Console.WriteLine("Removed Successfully");
                        }
                        catch (System.InvalidOperationException)
                        {

                            Console.WriteLine("Product Not Found !!");
                        }
                       
                       
                        break;
                    case 4:
                        Console.WriteLine("Exiting.....");
                        deleteproductstatus = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }

            }
        

        }

        public void findProduct() {


            bool findproductstatus = false;

            while (findproductstatus != true)
            {
                Console.WriteLine("1. Find by Id");
                Console.WriteLine("2. Find by shortcode");
                Console.WriteLine("3. Find by Name");
                Console.WriteLine("4. Filter  by Selling Price");
                Console.WriteLine("5. Exit");
                int i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Enter Id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            var findid = products.Single(s => id == s.Id);
                           Console.WriteLine( findid.ToString());
                        } catch (System.InvalidOperationException) {
                            Console.WriteLine("Item Not Found !!");
                        }
                       
                        break;
                    case 2:
                        Console.WriteLine("Enter Short Code");
                        string shortcodee = Console.ReadLine();
                        try
                        {
                            var findshortcode = products.Single(s => shortcodee == s.ShortCode);
                            Console.WriteLine(findshortcode.ToString());
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
                            var findname = products.Single(s => name == s.Name);
                          Console.WriteLine(findname.ToString());
                        } catch (System.InvalidOperationException) {
                            Console.WriteLine("Item Not Found !!");
                        }
                       
                       

                        break;
                    case 4:
                        Console.WriteLine("Enter Selling Price - ");
                        int sellingprice = Convert.ToInt32(Console.ReadLine());
                        var maxlist = products.Where(s => sellingprice > s.SellingPrice);
                        var minlist = products.Where(s => sellingprice< s.SellingPrice);
                        try
                        {
                            var equal = products.Single(s => sellingprice == s.SellingPrice);
                            Console.WriteLine("\nProduct having price equal to " + sellingprice);
                            Console.WriteLine(equal.ToString());
                        }
                        catch (Exception e) {
                            Console.WriteLine("Product Not found" + e.Message);
                        }
                        Console.WriteLine("Product having price greater than "+sellingprice);
                        foreach (Product p in maxlist) {
                            Console.WriteLine(p.ToString());
                        };
                        Console.WriteLine("\nProduct having price less than " + sellingprice);
                        foreach (Product p in minlist)
                        {
                            Console.WriteLine(p.ToString());
                        };
                        break;
                    case 5:
                        Console.WriteLine("Exiting.....");
                        findproductstatus = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }

            }


        }

    }
    
}
