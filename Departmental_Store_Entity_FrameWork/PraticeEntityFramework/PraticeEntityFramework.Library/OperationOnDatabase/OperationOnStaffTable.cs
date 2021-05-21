using Microsoft.EntityFrameworkCore;
using PraticeEntityFramework.Library.Entites;
using PraticeEntityFramework.Library.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PraticeEntityFramework.Library.OperationOnDatabase
{
   public class OperationOnStaffTable
    {
        public void AddStaff(Staff staff)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {

                context.Staff.Add(staff);
                context.SaveChanges();
            }

        }


        public bool RemoveStaffById(long id)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {
                try
                {

                    var staff = context.Staff.Single(x => x.Staff_Id == id);

                    context.Staff.Remove(staff);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }

        }

        public Staff FindStaffById(long id)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {


                try
                {

                    var staff = context.Staff.Single(x => x.Staff_Id == id);
                   
                    return staff;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }

        public List<Staff> GetAllListOfStaffs()
        {


            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {


                try
                {

                    var staff = context.Staff.ToList<Staff>();
                    return staff;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }

        //

        public List<Staff> GetStaffByNameOrNumber(string value)
        {
            //Query Staff using name or phone number or both

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {
             
               List<Staff> staffs = context.Staff.Where<Staff>(x => x.First_Name.Contains(value) || x.Phone_Number.Contains(value)).ToList<Staff>();
                
                return staffs;
            }

            
        }

        public List<Staff> GetStaffByRole(string value)
        {
            //Query Staff using Role_Name

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {

                List<Staff> staffs = context.Staff.Include(s => s.Role).Where(x => x.Role.Role_Name.Contains(value)).ToList<Staff>();
                return staffs;
            }


        }
    }
}
