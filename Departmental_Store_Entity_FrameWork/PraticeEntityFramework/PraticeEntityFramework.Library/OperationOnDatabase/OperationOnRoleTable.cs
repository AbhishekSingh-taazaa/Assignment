using PraticeEntityFramework.Library.Entites;
using PraticeEntityFramework.Library.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PraticeEntityFramework.Library.OperationOnDatabase
{
   public class OperationOnRoleTable
    {
        public void AddRole(Role role)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {

                context.Role.Add(role);
                context.SaveChanges();
            }

        }


        public bool RemoveRoleById(long id)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {
                try
                {

                    var role = context.Role.Single(x => x.Role_Id == id);

                    context.Role.Remove(role);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }

        }

        public Role FindRoleById(long id)
        {

            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {


                try
                {

                    var role = context.Role.Single(x => x.Role_Id == id);
                   
                    return role;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }

        public List<Role> GetAllListOfRoles()
        {


            using (DepartmentalStoreContext context = new DepartmentalStoreContext())
            {


                try
                {

                    var roles = context.Role.ToList<Role>();
                    return roles;
                }
                catch (Exception)
                {

                    return null;
                }
            }

        }
    }
}
