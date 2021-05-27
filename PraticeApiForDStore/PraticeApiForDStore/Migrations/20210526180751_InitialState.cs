using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace PraticeApiForDStore.Migrations
{
    public partial class InitialState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Address_Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AddressLine1 = table.Column<string>(maxLength: 140, nullable: false),
                    AddressLine2 = table.Column<string>(maxLength: 100, nullable: true),
                    Pincode = table.Column<string>(fixedLength: true, maxLength: 6, nullable: false),
                    City = table.Column<string>(maxLength: 150, nullable: false),
                    State = table.Column<string>(maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Address_Id);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    Product_Code = table.Column<string>(nullable: false),
                    Brand_Name = table.Column<string>(maxLength: 100, nullable: false),
                    Product_Quantity = table.Column<long>(nullable: false),
                    InStock = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.Product_Code);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    ProductCategory_Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Category_Name = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.ProductCategory_Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Role_Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Role_Name = table.Column<string>(maxLength: 80, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Role_Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Customer_Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    First_Name = table.Column<string>(maxLength: 80, nullable: false),
                    Last_Name = table.Column<string>(maxLength: 60, nullable: false),
                    Gender = table.Column<string>(fixedLength: true, maxLength: 1, nullable: false),
                    Phone_Number = table.Column<string>(maxLength: 10, nullable: false),
                    Email = table.Column<string>(maxLength: 120, nullable: false),
                    Address_Id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Customer_Id);
                    table.ForeignKey(
                        name: "FK_Customer_Address_Address_Id",
                        column: x => x.Address_Id,
                        principalTable: "Address",
                        principalColumn: "Address_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    Supplier_Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    First_Name = table.Column<string>(maxLength: 80, nullable: false),
                    Last_Name = table.Column<string>(maxLength: 60, nullable: false),
                    Gender = table.Column<string>(fixedLength: true, maxLength: 1, nullable: false),
                    Phone_Number = table.Column<string>(fixedLength: true, maxLength: 10, nullable: false),
                    Email = table.Column<string>(maxLength: 120, nullable: false),
                    Address_Id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.Supplier_Id);
                    table.ForeignKey(
                        name: "FK_Supplier_Address_Address_Id",
                        column: x => x.Address_Id,
                        principalTable: "Address",
                        principalColumn: "Address_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Product_Code = table.Column<string>(nullable: false),
                    Product_Name = table.Column<string>(maxLength: 120, nullable: false),
                    ProductCategory_Id = table.Column<int>(nullable: false),
                    Manufacturing_Date = table.Column<DateTime>(type: "date", nullable: false),
                    Expiry_Date = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Product_Code);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory_ProductCategory_Id",
                        column: x => x.ProductCategory_Id,
                        principalTable: "ProductCategory",
                        principalColumn: "ProductCategory_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Inventory_Product_Code",
                        column: x => x.Product_Code,
                        principalTable: "Inventory",
                        principalColumn: "Product_Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Staff_Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    First_Name = table.Column<string>(maxLength: 80, nullable: false),
                    Last_Name = table.Column<string>(maxLength: 60, nullable: false),
                    Gender = table.Column<string>(maxLength: 1, nullable: false),
                    Phone_Number = table.Column<string>(maxLength: 10, nullable: false),
                    Address_Id = table.Column<long>(nullable: false),
                    Role_Id = table.Column<int>(nullable: false),
                    Salary = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Staff_Id);
                    table.ForeignKey(
                        name: "FK_Staff_Address_Address_Id",
                        column: x => x.Address_Id,
                        principalTable: "Address",
                        principalColumn: "Address_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Staff_Role_Role_Id",
                        column: x => x.Role_Id,
                        principalTable: "Role",
                        principalColumn: "Role_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    Order_Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Supplier_Id = table.Column<long>(nullable: false),
                    Customer_Id = table.Column<long>(nullable: false),
                    Product_Code = table.Column<string>(nullable: true),
                    Ordered_Quantity = table.Column<int>(nullable: false),
                    Date_Of_Order = table.Column<DateTime>(type: "date", nullable: false),
                    Date_Of_Delivery = table.Column<DateTime>(type: "date", nullable: false),
                    Address_Id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Order_Id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Address_Address_Id",
                        column: x => x.Address_Id,
                        principalTable: "Address",
                        principalColumn: "Address_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Customer_Customer_Id",
                        column: x => x.Customer_Id,
                        principalTable: "Customer",
                        principalColumn: "Customer_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Product_Product_Code",
                        column: x => x.Product_Code,
                        principalTable: "Product",
                        principalColumn: "Product_Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Supplier_Supplier_Id",
                        column: x => x.Supplier_Id,
                        principalTable: "Supplier",
                        principalColumn: "Supplier_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductPrice",
                columns: table => new
                {
                    Product_Code = table.Column<string>(nullable: false),
                    Cost_Price = table.Column<decimal>(maxLength: 12, nullable: false),
                    Selling_Price = table.Column<decimal>(maxLength: 12, nullable: false),
                    Date_Of_Register = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPrice", x => x.Product_Code);
                    table.ForeignKey(
                        name: "FK_ProductPrice_Product_Product_Code",
                        column: x => x.Product_Code,
                        principalTable: "Product",
                        principalColumn: "Product_Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Address_Id",
                table: "Customer",
                column: "Address_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Email",
                table: "Customer",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_Address_Id",
                table: "OrderDetail",
                column: "Address_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_Customer_Id",
                table: "OrderDetail",
                column: "Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_Product_Code",
                table: "OrderDetail",
                column: "Product_Code");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_Supplier_Id",
                table: "OrderDetail",
                column: "Supplier_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCategory_Id",
                table: "Product",
                column: "ProductCategory_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_Address_Id",
                table: "Staff",
                column: "Address_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_Role_Id",
                table: "Staff",
                column: "Role_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_Address_Id",
                table: "Supplier",
                column: "Address_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_Email",
                table: "Supplier",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "ProductPrice");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "Inventory");
        }
    }
}
