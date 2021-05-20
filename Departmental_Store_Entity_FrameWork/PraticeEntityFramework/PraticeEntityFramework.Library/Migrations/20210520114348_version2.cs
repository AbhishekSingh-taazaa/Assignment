using Microsoft.EntityFrameworkCore.Migrations;

namespace PraticeEntityFramework.Library.Migrations
{
    public partial class version2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Addresses_Address_Id1",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_Address_Id1",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "Address_Id1",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "Category_Id",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Phone_Number",
                table: "Suppliers",
                fixedLength: true,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Last_Name",
                table: "Suppliers",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Suppliers",
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "First_Name",
                table: "Suppliers",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Suppliers",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone_Number",
                table: "Staffs",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Last_Name",
                table: "Staffs",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Staffs",
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "First_Name",
                table: "Staffs",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Role_Name",
                table: "Roles",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Roles",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Product_Name",
                table: "Products",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductCategory_Id",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Category_Name",
                table: "ProductCategories",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Supplier_Id",
                table: "OrderDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "Customer_Id",
                table: "OrderDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "Address_Id",
                table: "OrderDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Brand_Name",
                table: "Inventories",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone_Number",
                table: "Customers",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Customers",
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Addresses",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Pincode",
                table: "Addresses",
                fixedLength: true,
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Addresses",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine2",
                table: "Addresses",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine1",
                table: "Addresses",
                maxLength: 140,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_Address_Id",
                table: "Suppliers",
                column: "Address_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_Email",
                table: "Suppliers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategory_Id",
                table: "Products",
                column: "ProductCategory_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Address_Id",
                table: "OrderDetails",
                column: "Address_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Customer_Id",
                table: "OrderDetails",
                column: "Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Product_Code",
                table: "OrderDetails",
                column: "Product_Code");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Supplier_Id",
                table: "OrderDetails",
                column: "Supplier_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Email",
                table: "Customers",
                column: "Email",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Addresses_Address_Id",
                table: "OrderDetails",
                column: "Address_Id",
                principalTable: "Addresses",
                principalColumn: "Address_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Customers_Customer_Id",
                table: "OrderDetails",
                column: "Customer_Id",
                principalTable: "Customers",
                principalColumn: "Customer_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_Product_Code",
                table: "OrderDetails",
                column: "Product_Code",
                principalTable: "Products",
                principalColumn: "Product_Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Suppliers_Supplier_Id",
                table: "OrderDetails",
                column: "Supplier_Id",
                principalTable: "Suppliers",
                principalColumn: "Supplier_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_ProductCategory_Id",
                table: "Products",
                column: "ProductCategory_Id",
                principalTable: "ProductCategories",
                principalColumn: "ProductCategory_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Addresses_Address_Id",
                table: "Suppliers",
                column: "Address_Id",
                principalTable: "Addresses",
                principalColumn: "Address_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Addresses_Address_Id",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Customers_Customer_Id",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_Product_Code",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Suppliers_Supplier_Id",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_ProductCategory_Id",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Addresses_Address_Id",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_Address_Id",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_Email",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductCategory_Id",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_Address_Id",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_Customer_Id",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_Product_Code",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_Supplier_Id",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_Customers_Email",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ProductCategory_Id",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Phone_Number",
                table: "Suppliers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldFixedLength: true,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Last_Name",
                table: "Suppliers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Suppliers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldFixedLength: true,
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "First_Name",
                table: "Suppliers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Suppliers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 120);

            migrationBuilder.AddColumn<long>(
                name: "Address_Id1",
                table: "Suppliers",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone_Number",
                table: "Staffs",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Last_Name",
                table: "Staffs",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Staffs",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "First_Name",
                table: "Staffs",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "Role_Name",
                table: "Roles",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Roles",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Product_Name",
                table: "Products",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 120);

            migrationBuilder.AddColumn<int>(
                name: "Category_Id",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Category_Name",
                table: "ProductCategories",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<int>(
                name: "Supplier_Id",
                table: "OrderDetails",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "Customer_Id",
                table: "OrderDetails",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "Address_Id",
                table: "OrderDetails",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<string>(
                name: "Brand_Name",
                table: "Inventories",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Phone_Number",
                table: "Customers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Customers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldFixedLength: true,
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Addresses",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "Pincode",
                table: "Addresses",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldFixedLength: true,
                oldMaxLength: 6);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Addresses",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine2",
                table: "Addresses",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine1",
                table: "Addresses",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 140);

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_Address_Id1",
                table: "Suppliers",
                column: "Address_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Addresses_Address_Id1",
                table: "Suppliers",
                column: "Address_Id1",
                principalTable: "Addresses",
                principalColumn: "Address_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
