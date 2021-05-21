using PraticeEntityFramework.Library.Entites;
using PraticeEntityFramework.Library.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PraticeEntityFramework.Library.OperationOnDatabase
{
   public class OperationOnProductPrice
    {
        public void AddPrice(ProductPrice price)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {

                context.ProductPrice.Add(price);
                context.SaveChanges();
            }

        }


        public bool RemoveProductPriceByCode(string code)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {
                try
                {

                    var pricepro = context.ProductPrice.Single(x => x.Product_Code == code);

                    context.ProductPrice.Remove(pricepro);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }

        }

        public List<ProductPrice> FindProductPriceByCode(string code)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {


                try
                {

                   
                    List<ProductPrice> productprice = context.ProductPrice.Where(x=> x.Product_Code == code).ToList<ProductPrice>();
                    context.SaveChanges();
                    return productprice;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }

        public List<ProductPrice> GetAllListOfProductPrice()
        {


            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {


                try
                {

                    var productprice = context.ProductPrice.ToList<ProductPrice>();
                    return productprice;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }
    }
}
