using PraticeEntityFramework.Library.Entites;
using PraticeEntityFramework.Library.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PraticeEntityFramework.Library.OperationOnDatabase
{
   public class OperationOnInventoryTable
    {
        public void AddInventory(Inventory inventory)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {

                context.Inventory.Add(inventory);
                context.SaveChanges();
            }

        }


        public bool RemoveInventoryByCode(string code)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {
                try
                {

                    var inventory = context.Inventory.Single(x => x.Product_Code == code);

                    context.Inventory.Remove(inventory);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }

        }

        public Inventory FindInventoryProductByCode(string code)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {


                try
                {

                    var inventory = context.Inventory.Single(x => x.Product_Code == code);
                    context.SaveChanges();
                    return inventory;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }

        public List<Inventory> GetAllListOfIncventory()
        {


            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {


                try
                {

                    var inventory = context.Inventory.ToList<Inventory>();
                    return inventory;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }
    }
}
