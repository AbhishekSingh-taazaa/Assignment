using PraticeEntityFramework.Library.Entites;
using PraticeEntityFramework.Library.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PraticeEntityFramework.Library.OperationOnDatabase
{
   public class OperationOnAddressTable
    {
        public void  AddAddress(Address address ) {
        
            using(DepartmentalStoreContext  context = new DepartmentalStoreContext()){

                context.Address.Add(address);
                context.SaveChanges();
            }
        
        }


        public bool RemoveAddressById(long  id)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {
                try {

                    var Address = context.Address.Single(x => x.Address_Id == id);

                    context.Address.Remove(Address);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception) {

                    return false;
                }
            }

        }

        public Address FindById(long id)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {

               
                try
                {

                    var Address = context.Address.Single(x => x.Address_Id == id);
                    context.SaveChanges();
                    return Address;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }

        public List<Address> GetAllListOfAddress() {


            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {


                try
                {

                    var Address = context.Address.ToList<Address>();
                    return Address;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }
    }
}
