using PraticeEntityFramework.Library.Entites;
using PraticeEntityFramework.Library.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PraticeEntityFramework.Library.OperationOnDatabase
{
   public class OperationOnCustomerTable
    {
        public void AddCustomer(Customer customer)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {

                context.Customer.Add(customer);
                context.SaveChanges();
            }

        }


        public bool RemoveCustomerById(long id)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {
                try
                {

                    var customer = context.Customer.Single(x => x.Address_Id == id);

                    context.Customer.Remove(customer);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }

        }

        public Customer FindCustomerById(long id)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {


                try
                {

                    var customer = context.Customer.Single(x => x.Customer_Id == id);
                    context.SaveChanges();
                    return customer;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }

        public List<Customer> GetAllListOfCustomer()
        {


            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {


                try
                {

                    var customer = context.Customer.ToList<Customer>();
                    return customer;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }
    }
}
