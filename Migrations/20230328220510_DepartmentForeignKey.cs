using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesWebMvc.Migrations
{
    /// <inheritdoc />
    public partial class DepartmentForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seller",
                table: "Seller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.RenameTable(
                name: "Seller",
                newName: "seller");

            migrationBuilder.RenameTable(
                name: "SalesRecord",
                newName: "salesRecord");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "department");

            migrationBuilder.RenameIndex(
                name: "IX_Seller_DepartmentId",
                table: "seller",
                newName: "IX_seller_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecord_SellerId",
                table: "salesRecord",
                newName: "IX_salesRecord_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_seller",
                table: "seller",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_salesRecord",
                table: "salesRecord",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_department",
                table: "department",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_salesRecord_seller_SellerId",
                table: "salesRecord",
                column: "SellerId",
                principalTable: "seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_seller_department_DepartmentId",
                table: "seller",
                column: "DepartmentId",
                principalTable: "department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_salesRecord_seller_SellerId",
                table: "salesRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_seller_department_DepartmentId",
                table: "seller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_seller",
                table: "seller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_salesRecord",
                table: "salesRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_department",
                table: "department");

            migrationBuilder.RenameTable(
                name: "seller",
                newName: "Seller");

            migrationBuilder.RenameTable(
                name: "salesRecord",
                newName: "SalesRecord");

            migrationBuilder.RenameTable(
                name: "department",
                newName: "Department");

            migrationBuilder.RenameIndex(
                name: "IX_seller_DepartmentId",
                table: "Seller",
                newName: "IX_Seller_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_salesRecord_SellerId",
                table: "SalesRecord",
                newName: "IX_SalesRecord_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seller",
                table: "Seller",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
