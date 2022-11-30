using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DesignPattern.CQRS.PresentationLayer.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WorkArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartWork = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductPurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductSalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductBarcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductKdv = table.Column<int>(type: "int", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductStock = table.Column<int>(type: "int", nullable: false),
                    ProductMinStock = table.Column<int>(type: "int", nullable: false),
                    ProductMaxStock = table.Column<int>(type: "int", nullable: false),
                    ProductSizeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductSizeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductStorage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
