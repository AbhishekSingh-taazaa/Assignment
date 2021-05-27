//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace PraticeApiForDStore
//{
//    public class DepartmentalStoreContextold
//    {

//        public DbSet<Staff> Staff { get; set; }

//        public DbSet<Role> Role { get; set; }
//        public DbSet<Address> Address { get; set; }

//        public DbSet<Customer> Customer { get; set; }

//        public DbSet<Inventory> Inventory { get; set; }
//        public DbSet<OrderDetail> OrderDetail { get; set; }

//        public DbSet<Product> Product { get; set; }

//        public DbSet<ProductCategory> ProductCategory { get; set; }

//        public DbSet<Supplier> Supplier { get; set; }

//        public DbSet<ProductPrice> ProductPrice { get; set; }


//        //public DbSet<Product_Category_Many> Product_Category_Manies { get; set; }



//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//            => optionsBuilder.UseNpgsql("Host=localhost;DataBase=DStore;username=postgres;password=Abhi.Singh02");

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            //Staff Configuration
//            modelBuilder.Entity<Staff>().HasKey(r => r.Staff_Id);
//            modelBuilder.Entity<Staff>().HasOne<Address>(r => r.Address).WithMany(s => s.Staff).HasForeignKey(x => x.Address_Id);
//            modelBuilder.Entity<Staff>().HasOne<Role>(x => x.Role).WithMany(x => x.Staff).HasForeignKey(x => x.Role_Id);
//            modelBuilder.Entity<Staff>().Property(x => x.First_Name).HasMaxLength(80).IsRequired();
//            modelBuilder.Entity<Staff>().Property(x => x.Last_Name).HasMaxLength(60).IsRequired();
//            modelBuilder.Entity<Staff>().Property(x => x.Gender).HasMaxLength(1).IsRequired();
//            modelBuilder.Entity<Staff>().Property(x => x.Phone_Number).HasMaxLength(10).IsRequired();


//            //Address Configuration
//            modelBuilder.Entity<Address>().HasKey(k => k.Address_Id);
//            modelBuilder.Entity<Address>().Property(k => k.AddressLine1).HasMaxLength(140).IsRequired();
//            modelBuilder.Entity<Address>().Property(k => k.AddressLine2).HasMaxLength(100);
//            modelBuilder.Entity<Address>().Property(k => k.Pincode).HasMaxLength(6).IsRequired().IsFixedLength();
//            modelBuilder.Entity<Address>().Property(k => k.City).HasMaxLength(150).IsRequired();
//            modelBuilder.Entity<Address>().Property(k => k.State).HasMaxLength(120).IsRequired();

//            //Role Configuration
//            modelBuilder.Entity<Role>().HasKey(k => k.Role_Id);
//            modelBuilder.Entity<Role>().Property(k => k.Role_Name).HasMaxLength(80).IsRequired();
//            modelBuilder.Entity<Role>().Property(k => k.Description).HasMaxLength(200).IsRequired();
//            //modelBuilder.Entity<Role>().Property(k => k.Role_Id).IsRequired().UseNpgsqlSerialColumn();

//            //Customer Configuration
//            modelBuilder.Entity<Customer>().HasKey(x => x.Customer_Id);
//            modelBuilder.Entity<Customer>().HasOne<Address>(x => x.Address).WithMany(x => x.Customer).HasForeignKey(x => x.Address_Id);
//            modelBuilder.Entity<Customer>().Property(x => x.Email).HasMaxLength(120).IsRequired();
//            modelBuilder.Entity<Customer>().HasIndex(x => x.Email).IsUnique();
//            modelBuilder.Entity<Customer>().Property(x => x.First_Name).HasMaxLength(80).IsRequired();
//            modelBuilder.Entity<Customer>().Property(x => x.Last_Name).HasMaxLength(60).IsRequired();
//            modelBuilder.Entity<Customer>().Property(x => x.Gender).HasMaxLength(1).IsRequired().IsFixedLength();
//            modelBuilder.Entity<Customer>().Property(x => x.Phone_Number).HasMaxLength(10).IsRequired();


//            //Inventory Configuration
//            modelBuilder.Entity<Inventory>().HasKey(x => x.Product_Code);
//            modelBuilder.Entity<Inventory>().HasOne<Product>(s => s.Product).WithOne(ad => ad.Inventory).HasForeignKey<Product>(ad => ad.Product_Code);
//            modelBuilder.Entity<Inventory>().Property(x => x.Brand_Name).HasMaxLength(100).IsRequired();
//            modelBuilder.Entity<Inventory>().Property(x => x.Product_Quantity).IsRequired();
//            modelBuilder.Entity<Inventory>().Property(x => x.InStock).IsRequired();


//            //Order Detail Configuration
//            modelBuilder.Entity<OrderDetail>().HasKey(x => x.Order_Id);
//            modelBuilder.Entity<OrderDetail>().HasOne<Supplier>(x => x.Supplier).WithMany(x => x.OrderDetail).HasForeignKey(x => x.Supplier_Id);
//            modelBuilder.Entity<OrderDetail>().HasOne<Product>(x => x.Product).WithMany(x => x.OrderDetail).HasForeignKey(x => x.Product_Code);
//            modelBuilder.Entity<OrderDetail>().HasOne<Customer>(x => x.Customer).WithMany(x => x.OrderDetail).HasForeignKey(x => x.Customer_Id);
//            modelBuilder.Entity<OrderDetail>().HasOne<Address>(x => x.Address).WithMany(x => x.OrderDetail).HasForeignKey(x => x.Address_Id);
//            modelBuilder.Entity<OrderDetail>().Property(x => x.Ordered_Quantity).IsRequired();
//            modelBuilder.Entity<OrderDetail>().Property(x => x.Date_Of_Order).IsRequired().HasColumnType("date");
//            modelBuilder.Entity<OrderDetail>().Property(x => x.Date_Of_Delivery).IsRequired().HasColumnType("date");


//            //Product Configuration
//            modelBuilder.Entity<Product>().HasKey(x => x.Product_Code);
//            modelBuilder.Entity<Product>().HasOne<ProductCategory>(x => x.ProductCategory).WithMany(x => x.Product).HasForeignKey(x => x.ProductCategory_Id);
//            modelBuilder.Entity<Product>().Property(x => x.Product_Name).HasMaxLength(120).IsRequired();
//            modelBuilder.Entity<Product>().Property(x => x.Manufacturing_Date).IsRequired().HasColumnType("date");
//            modelBuilder.Entity<Product>().Property(x => x.Expiry_Date).HasColumnType("date");

//            //Prodcut Category Configuration
//            modelBuilder.Entity<ProductCategory>().HasKey(x => x.ProductCategory_Id);
//            modelBuilder.Entity<ProductCategory>().Property(x => x.Category_Name).HasMaxLength(150).IsRequired();


//            //Product Price Configuration
//            modelBuilder.Entity<ProductPrice>().HasKey(x => x.Product_Code);
//            modelBuilder.Entity<ProductPrice>().HasOne<Product>(x => x.Product).WithMany(x => x.ProductPrice).HasForeignKey(x => x.Product_Code);
//            modelBuilder.Entity<ProductPrice>().Property(x => x.Cost_Price).HasMaxLength(12).IsRequired();
//            modelBuilder.Entity<ProductPrice>().Property(x => x.Selling_Price).HasMaxLength(12).IsRequired();
//            modelBuilder.Entity<ProductPrice>().Property(x => x.Date_Of_Register).IsRequired().HasColumnType("date");

//            //Supplier Configuration
//            modelBuilder.Entity<Supplier>().HasKey(x => x.Supplier_Id);
//            modelBuilder.Entity<Supplier>().HasOne<Address>(x => x.Address).WithMany(x => x.Supplier).HasForeignKey(x => x.Address_Id);
//            modelBuilder.Entity<Supplier>().Property(x => x.Email).HasMaxLength(120).IsRequired();
//            modelBuilder.Entity<Supplier>().HasIndex(x => x.Email).IsUnique();
//            modelBuilder.Entity<Supplier>().Property(x => x.First_Name).HasMaxLength(80).IsRequired();
//            modelBuilder.Entity<Supplier>().Property(x => x.Last_Name).HasMaxLength(60).IsRequired();
//            modelBuilder.Entity<Supplier>().Property(x => x.Gender).HasMaxLength(1).IsRequired().IsFixedLength();
//            modelBuilder.Entity<Supplier>().Property(x => x.Phone_Number).HasMaxLength(10).IsRequired().IsFixedLength();

//        }

//    }
//}
////protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//       //     => optionsBuilder.UseNpgsql("Host=localhost;DataBase=DStore;username=postgres;password=Abhi.Singh02");
