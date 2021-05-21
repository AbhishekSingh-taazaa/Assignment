using PraticeEntityFramework.Library.Entites;
using PraticeEntityFramework.Library.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PraticeEntityFramework.Library.OperationOnDatabase
{
   public class OperationOnProductCategoryTable
    {
        public void AddProductCategory(ProductCategory productcategory)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {

                context.ProductCategory.Add(productcategory);
                context.SaveChanges();
            }

        }


        public bool RemoveProductCategoryByCode(long id)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {
                try
                {

                    var productcategory = context.ProductCategory.Single(x => x.ProductCategory_Id == id);

                    context.ProductCategory.Remove(productcategory);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }

        }

        public ProductCategory FindProductByCode(long id)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {


                try
                {

                    var productcategory = context.ProductCategory.Single(x => x.ProductCategory_Id == id);
                    context.SaveChanges();
                    return productcategory;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }

        public List<ProductCategory> GetAllListOfProductCategories()
        {


            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {


                try
                {

                    var productcategory = context.ProductCategory.ToList<ProductCategory>();
                    return productcategory;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }
    }
}
