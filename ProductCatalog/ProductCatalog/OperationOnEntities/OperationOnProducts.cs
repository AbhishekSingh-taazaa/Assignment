using ProductCatalog.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductCatalog.OperationOnEntities
{
    public class OperationOnProducts
    {
       public static List<Product> products = new List<Product>();
        OperationOnCategory operationCategory = new OperationOnCategory();


        //public static int AutoIncrement = 0;
        //public int Id { get; }
        //public string Name { get; set; }
        //public string Manufacturer { get; set; }

        //public string ShortCode { get; set; }

        //public List<Category> Categories { get; set; }

        //public string Description { get; set; }

        //public int SellingPrice { get; set; }
        public void AddProduct() {

          
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Manufactror Name");
            string manufacturer = Console.ReadLine();

            Console.WriteLine("Enter Short Code ");
            string shortcode = Console.ReadLine();

            Console.WriteLine("Enter Description");
            string description = Console.ReadLine();

           

            Console.WriteLine("Enter Selling Price");
            int sellingprice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter category Of Product");
            string category = Console.ReadLine();
            bool iscategoryPresent = false;
            foreach (Category c in OperationOnCategory.categoryList)
            {
                if (c.Name != category)
                    iscategoryPresent = true;
            }
            if (iscategoryPresent == true)
            {
                operationCategory.AddCategory();
            }

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

                Console.WriteLine("Id -   "+p.Id+"\nName - "+p.Name+"\nManufactror - "+p.Manufacturer+"\nDescription -"+p.Description+"\nSelling Price -"+p.SellingPrice);
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
                        var findid = products.Single(s => id == s.Id);
                        products.Remove(findid);
                        Console.WriteLine("Removed Successfully");
                        deleteproductstatus = true;
                        break;
                    case 2:
                        Console.WriteLine("Short Code");
                        deleteproductstatus = true;
                        break;

                    case 3:
                        Console.WriteLine("Enter Name ");
                        string name = Console.ReadLine();
                        var findname = products.Single(s => name == s.Name);
                        products.Remove(findname);
                        deleteproductstatus = true;

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
                        var findid = products.Single(s => id == s.Id);
                       
                        Console.WriteLine("Product Id - "+findid.Id+" Name - "+findid.Name+" Manufacturer - "+findid.Manufacturer+" Description - "+findid.Description+" Selling Price - "+findid.SellingPrice);
                       findproductstatus = true;
                        break;
                    case 2:
                        Console.WriteLine("Short Code");
                        findproductstatus = true;
                        break;

                    case 3:
                        Console.WriteLine("Enter Name ");
                        string name = Console.ReadLine();
                        var findname = products.Single(s => name == s.Name);
                        Console.WriteLine("Product Id - " + findname.Id + " Name - " + findname.Name + " Manufacturer - " + findname.Manufacturer + " Description - " + findname.Description + " Selling Price - " + findname.SellingPrice);

                        findproductstatus = true;

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
                            Console.WriteLine("Product Id - " + equal.Id + " Name - " + equal.Name + " Manufacturer - " + equal.Manufacturer + " Description - " + equal.Description + " Selling Price - " + equal.SellingPrice);


                        }
                        catch (Exception e) {

                            Console.WriteLine("Product Not found"+ e);

                        }

                        Console.WriteLine("Product having price greater than "+sellingprice);

                        foreach (Product p in maxlist) {
                            Console.WriteLine("Product Id - " + p.Id + " Name - " + p.Name + " Manufacturer - " + p.Manufacturer + " Description - " + p.Description + " Selling Price - " + p.SellingPrice);
                        };

                        Console.WriteLine("\nProduct having price less than " + sellingprice);

                        foreach (Product p in minlist)
                        {
                            Console.WriteLine("Product Id - " + p.Id + " Name - " + p.Name + " Manufacturer - " + p.Manufacturer + " Description - " + p.Description + " Selling Price - " + p.SellingPrice);
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
