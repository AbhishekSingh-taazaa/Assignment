using Microsoft.EntityFrameworkCore;
using PraticeEntityFramework.Library.Entites;
using PraticeEntityFramework.Library.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PraticeEntityFramework.Library.OperationOnDatabase
{
  public class OperationOnOrderDetailTable
    {
        public void AddOrderDetail(OrderDetail order)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {

                context.OrderDetail.Add(order);
                context.SaveChanges();
            }

        }


        public bool RemoveOrderById(long id)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {
                try
                {

                    var order = context.OrderDetail.Single(x => x.Order_Id == id);

                    context.OrderDetail.Remove(order);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }

        }

        public OrderDetail FindOrderById(long id)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {


                try
                {

                    var order = context.OrderDetail.Single(x => x.Order_Id == id);
                    context.SaveChanges();
                    return order;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }

        public List<OrderDetail> GetAllListOfOrders()
        {


            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {


                try
                {

                    var order = context.OrderDetail.ToList<OrderDetail>();
                    return order;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }

        //        List of Product with different suppliers, with the recent date of supply and the amount supplied on the most recent occasion.Here this can also be filtered based on -

        //a.Product Name

        //b.Supplier Name

        //c.Product Code

        //d.Supplied after a particular date

        //e. Supplied before a particular date

        //f. Product has inventory more than or less than a given qty

        public List<OrderDetail> OrdersProductQuery(string value )
        {


            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {

                var query = context.OrderDetail.Include(x => x.Product).Include(x => x.Supplier).ThenInclude(x => x.Address).Where(x => x.Supplier.First_Name == value || x.Product.Product_Name== value );

               

                    return null;
                
            }

        }

        public List<OrderDetail> OrdersProductSuppliedBeforeDate(DateTime datebefore)
        {


            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {

                var query = context.OrderDetail.Where(x => x.Date_Of_Delivery < datebefore);



                return null;

            }

        }


        public List<OrderDetail> OrdersProductSuppliedAfterDate(DateTime datebefore)
        {


            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {

                var query = context.OrderDetail.Where(x => x.Date_Of_Delivery > datebefore);



                return null;

            }

        }

    }
}
