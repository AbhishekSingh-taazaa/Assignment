using Microsoft.EntityFrameworkCore;
using PraticeEntityFramework.Library.Entites;
using PraticeEntityFramework.Library.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PraticeEntityFramework.Library.OperationOnDatabase
{
  public  class OperationOnProductTable
    {
        public void AddProduct(Product product)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {

                context.Product.Add(product);
                context.SaveChanges();
            }

        }


        public bool RemoveProductByCode(string code)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {
                try
                {

                    var product = context.Product.Single(x => x.Product_Code == code);

                    context.Product.Remove(product);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }

        }

        public Product FindProductByCode(string code)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {


                try
                {

                    var product = context.Product.Single(x => x.Product_Code == code);
                    context.SaveChanges();
                    return product;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }

        public List<Product> GetAllListOfProduct()
        {


            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {


                try
                {

                    var product = context.Product.ToList<Product>();
                    return product;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }

        public List<Product> GetProductByName(string name)
        {
            //Query Product based on - Name

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {
                var products = context.Product.Where(x => x.Product_Name == name).ToList();
                return products;
            }

        }

        public List<Product> GetProductByCategory(string cname)
        {
            //Query Product based on - Category_Name

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {
                var products = context.Product.Include(x => x.ProductCategory).Where(x => x.ProductCategory.Category_Name.Contains(cname)).ToList();

                return products;
            }

        }

        public List<Product> GetProductInStock()
        {
            //Query Product based on - Instock

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {
                var products = context.Product.Include(x => x.Inventory).Where(x => x.Inventory.InStock == true).ToList();

                return products;
            }

        }


        public List<Product> GetProductOutStock()
        {
            //Query Product based on - OutOfStock

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {
                var products = context.Product.Include(x => x.Inventory).Where(x => x.Inventory.InStock == false).ToList();

                return products;
            }

        }


        public List<Product> GetProductHavingSPLessThan(decimal price)
        {
            //Query Product based on - OutOfStock

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {
                //var products = context.Product.Include(x => x.ProductPrice.Select( x => x.Selling_Price < price)).ToList();

                var pro = context.Product.Include(x => x.ProductPrice).Where(x => x.ProductPrice.Any(x => x.Selling_Price < price)).ToList();
                return pro;
            }

        }




    }
}
