using PraticeEntityFramework.Library.Infrastructure;
using PraticeEntityFramework.Library.Entites;
using System;
using PraticeEntityFramework.Library.OperationOnDatabase;
using System.Linq;
namespace Store.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //using (DepartmentalStoreContext departmentalStoreContext = new DepartmentalStoreContext()) {

            //Address a1 = new Address
            //{
            //    Address_Id = 1,
            //    AddressLine1 = "1/46 Dalmandi Fatehgarh",
            //    Pincode = "209601",
            //    City = "Farukhabad",
            //    State = "Uttar Pradesh"
            //};

            //    var query = from c in departmentalStoreContext.Set<Customer>()
            //                from a in departmentalStoreContext.Set<Address>()
            //                select new { c, a };

            //    query.ToList().ForEach(x => Console.WriteLine(x.a.AddressLine1));


            //}
            //Address a1 = new Address
            //{
            //    Address_Id = 1,
            //    AddressLine1 = "1/46 Dalmandi Fatehgarh",
            //    Pincode = "209601",
            //    City = "Farukhabad",
            //    State = "Uttar Pradesh"
            //};

            //OperationOnAddressTable operationOnAddressTable = new OperationOnAddressTable();
            //operationOnAddressTable.AddAddress(a1);

            //Customer c1 = new Customer { Customer_Id = 1, First_Name = "Abhishek", Last_Name = "Singh", Email = "abhi@gmail.com", Gender = "M", Address_Id = 1, Phone_Number = "6393011081" };
            //OperationOnCustomerTable operationOnCustomerTable = new OperationOnCustomerTable();

            //operationOnCustomerTable.AddCustomer(c1);

            //ProductCategory pc1 = new ProductCategory { ProductCategory_Id = 121, Category_Name = "Body Essentials" };
            //OperationOnProductCategoryTable opct = new OperationOnProductCategoryTable();
            //opct.AddProductCategory(pc1);

            //Product p1 = new Product { Product_Code = "USTRAACLAY", Product_Name = "CLAY SHAMPOO", Expiry_Date = new DateTime(2022, 10, 21), Manufacturing_Date = new DateTime(2021, 01, 12), ProductCategory_Id = 121 };
            OperationOnProductTable onProductTable = new OperationOnProductTable();
            //onProductTable.AddProduct(p1);

            //Inventory I1 = new Inventory { Product_Code = "USTRAACLAY", Brand_Name = "Ustraa", Product_Quantity = 200, InStock = true };
            //OperationOnInventoryTable onInventoryTable = new OperationOnInventoryTable();
            //onInventoryTable.AddInventory(I1);

            //ProductPrice pp1 = new ProductPrice { Product_Code = "USTRAACLAY", Cost_Price = 200, Selling_Price = 400, Date_Of_Register = new DateTime(2019, 10, 02) };
            OperationOnProductPrice onProductPrice = new OperationOnProductPrice();
            //onProductPrice.AddPrice(pp1);

            //Role r1 = new Role { Role_Id=111, Role_Name="Accountant", Description="Manage Bills" };
            //OperationOnRoleTable operationOnRoleTable = new OperationOnRoleTable();
            //operationOnRoleTable.AddRole(r1);

            //Staff sa1 = new Staff { Staff_Id=222, First_Name="Jimmy", Last_Name="Lanister", Role_Id=111, Phone_Number="3344556678", Address_Id=1, Gender="M", Salary=10000 };
            OperationOnStaffTable operationOnStaffTable = new OperationOnStaffTable();
            //operationOnStaffTable.AddStaff(sa1);

            //Supplier s1 = new Supplier { Supplier_Id=1, First_Name="Sacin", Last_Name="Katiyar", Email="sani@gmail.com", Gender="M", Phone_Number="3456789066", Address_Id=1 };
            //OperationOnSupplierTable operationOnSupplierTable = new OperationOnSupplierTable();
            //operationOnSupplierTable.AddSupplier(s1);

           //var staffbyNumberorname = operationOnStaffTable.GetStaffByNameOrNumber("5");

           // staffbyNumberorname.ForEach(x => Console.WriteLine($"{x.First_Name}  {x.Last_Name}  {x.Phone_Number}"));

           // var staffbyRole = operationOnStaffTable.GetStaffByRole("Ac");

           // staffbyRole.ForEach(x => Console.WriteLine($"{x.First_Name}  {x.Last_Name}  {x.Phone_Number} {x.Role.Role_Name}"));

            onProductTable.GetProductHavingSPLessThan(100).ForEach(x => Console.WriteLine($"{x.Product_Code} {x.Product_Name} {x.ProductPrice.Select(x => x.Selling_Price)}"));
        }
    }
}
