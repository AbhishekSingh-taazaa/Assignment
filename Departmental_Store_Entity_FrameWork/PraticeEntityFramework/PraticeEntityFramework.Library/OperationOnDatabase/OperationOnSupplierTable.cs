using PraticeEntityFramework.Library.Entites;
using PraticeEntityFramework.Library.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PraticeEntityFramework.Library.OperationOnDatabase
{
  public  class OperationOnSupplierTable
    {
        public void AddSupplier(Supplier supplier)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {

                context.Supplier.Add(supplier);
                context.SaveChanges();
            }

        }


        public bool RemoveSupplierById(long id)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {
                try
                {

                    var supplier = context.Supplier.Single(x => x.Supplier_Id == id);

                    context.Supplier.Remove(supplier);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }

        }

        public Supplier FindSupplierById(long id)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {


                try
                {

                    var supplier = context.Supplier.Single(x => x.Supplier_Id == id);

                    return supplier;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }

        public List<Supplier> GetAllListOfSuppliers()
        {


            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {


                try
                {

                    var suppliers = context.Supplier.ToList<Supplier>();
                    return suppliers;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }
    }
}
