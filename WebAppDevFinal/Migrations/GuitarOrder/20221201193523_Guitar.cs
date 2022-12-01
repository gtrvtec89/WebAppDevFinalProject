using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppDevFinal.Migrations.GuitarOrder
{
    public partial class Guitar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guitars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    List = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guitars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    DatePlaced = table.Column<DateTime>(nullable: false),
                    ProductID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Guitars",
                columns: new[] { "Id", "Brand", "Cost", "List", "Model", "Quantity", "Type" },
                values: new object[] { 1, "Grog Guitars", 3000.00m, 5000.00m, "S-type", 3, "Ibanez" });

            migrationBuilder.InsertData(
                table: "Guitars",
                columns: new[] { "Id", "Brand", "Cost", "List", "Model", "Quantity", "Type" },
                values: new object[] { 2, "Ibanez Guitars", 2500.00m, 4000.00m, "670qm", 6, "S-type" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guitars");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
