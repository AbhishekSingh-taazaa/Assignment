using PraticeEntityFramework.Library.Infrastructure;
using PraticeEntityFramework.Library.Entites;
using System;

namespace Store.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (DepartmentalStoreContext departmentalStoreContext = new DepartmentalStoreContext()) {

                Address a1 = new Address {
                Address_Id = 1,
                AddressLine1 ="1/46 Dalmandi Fatehgarh",
                Pincode="209601",
                City="Farukhabad",
                State="Uttar Pradesh"
                };

                departmentalStoreContext.Addresses.Add(a1);

                departmentalStoreContext.SaveChanges();
             


            }

           
        }
    }
}
