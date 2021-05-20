using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace PraticeEntityFramework.Library.Migrations
{
    public partial class version1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Addresses_AddressId",
                table: "Staffs");

            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Roles_RoleId",
                table: "Staffs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_Staffs_AddressId",
                table: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_Staffs_RoleId",
                table: "Staffs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "RoleID",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Addresses");

            migrationBuilder.AddColumn<long>(
                name: "Staff_Id",
                table: "Staffs",
                nullable: false,
                defaultValue: 0L)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<long>(
                name: "Address_Id",
                table: "Staffs",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "Role_Id",
                table: "Staffs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Role_Id",
                table: "Roles",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<long>(
                name: "Address_Id",
                table: "Addresses",
                nullable: false,
                defaultValue: 0L)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs",
                column: "Staff_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Role_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Address_Id");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Customer_Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    First_Name = table.Column<string>(maxLength: 80, nullable: false),
                    Last_Name = table.Column<string>(maxLength: 60, nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Phone_Number = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 120, nullable: false),
                    Address_Id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Customer_Id);
                    table.ForeignKey(
                        name: "FK_Customers_Addresses_Address_Id",
                        column: x => x.Address_Id,
                        principalTable: "Addresses",
                        principalColumn: "Address_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    Product_Code = table.Column<string>(nullable: false),
                    Brand_Name = table.Column<string>(nullable: true),
                    Product_Quantity = table.Column<long>(nullable: false),
                    InStock = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.Product_Code);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Order_Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Supplier_Id = table.Column<int>(nullable: false),
                    Customer_Id = table.Column<int>(nullable: false),
                    Product_Code = table.Column<string>(nullable: true),
                    Ordered_Quantity = table.Column<int>(nullable: false),
                    Date_Of_Order = table.Column<DateTime>(nullable: false),
                    Date_Of_Delivery = table.Column<DateTime>(nullable: false),
                    Address_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Order_Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductCategory_Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Category_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.ProductCategory_Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Supplier_Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    First_Name = table.Column<string>(nullable: true),
                    Last_Name = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Phone_Number = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address_Id = table.Column<long>(nullable: false),
                    Address_Id1 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Supplier_Id);
                    table.ForeignKey(
                        name: "FK_Suppliers_Addresses_Address_Id1",
                        column: x => x.Address_Id1,
                        principalTable: "Addresses",
                        principalColumn: "Address_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Product_Code = table.Column<string>(nullable: false),
                    Product_Name = table.Column<string>(nullable: true),
                    Category_Id = table.Column<int>(nullable: false),
                    Manufacturing_Date = table.Column<DateTime>(nullable: false),
                    Expiry_Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Product_Code);
                    table.ForeignKey(
                        name: "FK_Products_Inventories_Product_Code",
                        column: x => x.Product_Code,
                        principalTable: "Inventories",
                        principalColumn: "Product_Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productPrices",
                columns: table => new
                {
                    Product_Code = table.Column<string>(nullable: false),
                    Cost_Price = table.Column<decimal>(nullable: false),
                    Selling_Price = table.Column<decimal>(nullable: false),
                    Date_Of_Register = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productPrices", x => x.Product_Code);
                    table.ForeignKey(
                        name: "FK_productPrices_Products_Product_Code",
                        column: x => x.Product_Code,
                        principalTable: "Products",
                        principalColumn: "Product_Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_Address_Id",
                table: "Staffs",
                column: "Address_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_Role_Id",
                table: "Staffs",
                column: "Role_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Address_Id",
                table: "Customers",
                column: "Address_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_Address_Id1",
                table: "Suppliers",
                column: "Address_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Addresses_Address_Id",
                table: "Staffs",
                column: "Address_Id",
                principalTable: "Addresses",
                principalColumn: "Address_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Roles_Role_Id",
                table: "Staffs",
                column: "Role_Id",
                principalTable: "Roles",
                principalColumn: "Role_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Addresses_Address_Id",
                table: "Staffs");

            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Roles_Role_Id",
                table: "Staffs");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "productPrices");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_Staffs_Address_Id",
                table: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_Staffs_Role_Id",
                table: "Staffs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Staff_Id",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "Address_Id",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "Role_Id",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "Role_Id",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "Address_Id",
                table: "Addresses");

            migrationBuilder.AddColumn<long>(
                name: "StaffId",
                table: "Staffs",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<long>(
                name: "AddressId",
                table: "Staffs",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "Staffs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoleID",
                table: "Roles",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<long>(
                name: "AddressId",
                table: "Addresses",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs",
                column: "StaffId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "RoleID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_AddressId",
                table: "Staffs",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_RoleId",
                table: "Staffs",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Addresses_AddressId",
                table: "Staffs",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Roles_RoleId",
                table: "Staffs",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
