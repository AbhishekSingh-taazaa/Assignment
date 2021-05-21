using Microsoft.EntityFrameworkCore.Migrations;

namespace PraticeEntityFramework.Library.Migrations
{
    public partial class version2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Addresses_Address_Id1",
                table: "Supplier");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_Address_Id1",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "Address_Id1",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "Category_Id",
                table: "Product");

            migrationBuilder.AlterColumn<string>(
                name: "Phone_Number",
                table: "Supplier",
                fixedLength: true,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Last_Name",
                table: "Supplier",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Supplier",
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "First_Name",
                table: "Supplier",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Supplier",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone_Number",
                table: "Staff",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Last_Name",
                table: "Staff",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Staff",
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "First_Name",
                table: "Staff",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Role_Name",
                table: "Role",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Role",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Product_Name",
                table: "Product",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductCategory_Id",
                table: "Product",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Category_Name",
                table: "ProductCategory",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Supplier_Id",
                table: "OrderDetail",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "Customer_Id",
                table: "OrderDetail",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "Address_Id",
                table: "OrderDetail",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Brand_Name",
                table: "Inventory",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone_Number",
                table: "Customer",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Customer",
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Address",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Pincode",
                table: "Address",
                fixedLength: true,
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Address",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine2",
                table: "Address",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine1",
                table: "Address",
                maxLength: 140,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_Address_Id",
                table: "Supplier",
                column: "Address_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_Email",
                table: "Supplier",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategory_Id",
                table: "Product",
                column: "ProductCategory_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Address_Id",
                table: "OrderDetail",
                column: "Address_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Customer_Id",
                table: "OrderDetail",
                column: "Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Product_Code",
                table: "OrderDetail",
                column: "Product_Code");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Supplier_Id",
                table: "OrderDetail",
                column: "Supplier_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Email",
                table: "Customer",
                column: "Email",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Addresses_Address_Id",
                table: "OrderDetail",
                column: "Address_Id",
                principalTable: "Address",
                principalColumn: "Address_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Customers_Customer_Id",
                table: "OrderDetail",
                column: "Customer_Id",
                principalTable: "Customer",
                principalColumn: "Customer_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_Product_Code",
                table: "OrderDetail",
                column: "Product_Code",
                principalTable: "Product",
                principalColumn: "Product_Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Suppliers_Supplier_Id",
                table: "OrderDetail",
                column: "Supplier_Id",
                principalTable: "Supplier",
                principalColumn: "Supplier_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_ProductCategory_Id",
                table: "Product",
                column: "ProductCategory_Id",
                principalTable: "ProductCategory",
                principalColumn: "ProductCategory_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Addresses_Address_Id",
                table: "Supplier",
                column: "Address_Id",
                principalTable: "Address",
                principalColumn: "Address_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Addresses_Address_Id",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Customers_Customer_Id",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_Product_Code",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Suppliers_Supplier_Id",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_ProductCategory_Id",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Addresses_Address_Id",
                table: "Supplier");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_Address_Id",
                table: "Supplier");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_Email",
                table: "Supplier");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductCategory_Id",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_Address_Id",
                table: "OrderDetail");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_Customer_Id",
                table: "OrderDetail");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_Product_Code",
                table: "OrderDetail");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_Supplier_Id",
                table: "OrderDetail");

            migrationBuilder.DropIndex(
                name: "IX_Customers_Email",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "ProductCategory_Id",
                table: "Product");

            migrationBuilder.AlterColumn<string>(
                name: "Phone_Number",
                table: "Supplier",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldFixedLength: true,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Last_Name",
                table: "Supplier",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Supplier",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldFixedLength: true,
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "First_Name",
                table: "Supplier",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Supplier",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 120);

            migrationBuilder.AddColumn<long>(
                name: "Address_Id1",
                table: "Supplier",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone_Number",
                table: "Staff",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Last_Name",
                table: "Staff",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Staff",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "First_Name",
                table: "Staff",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "Role_Name",
                table: "Role",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Role",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Product_Name",
                table: "Product",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 120);

            migrationBuilder.AddColumn<int>(
                name: "Category_Id",
                table: "Product",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Category_Name",
                table: "ProductCategory",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<int>(
                name: "Supplier_Id",
                table: "OrderDetail",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "Customer_Id",
                table: "OrderDetail",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "Address_Id",
                table: "OrderDetail",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<string>(
                name: "Brand_Name",
                table: "Inventory",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Phone_Number",
                table: "Customer",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Customer",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldFixedLength: true,
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Address",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "Pincode",
                table: "Address",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldFixedLength: true,
                oldMaxLength: 6);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Address",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine2",
                table: "Address",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine1",
                table: "Address",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 140);

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_Address_Id1",
                table: "Supplier",
                column: "Address_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Addresses_Address_Id1",
                table: "Supplier",
                column: "Address_Id1",
                principalTable: "Address",
                principalColumn: "Address_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
