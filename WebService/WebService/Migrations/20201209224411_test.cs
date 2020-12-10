using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebService.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bar",
                columns: table => new
                {
                    BarID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BarName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BarLocation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bar", x => x.BarID);
                });

            migrationBuilder.CreateTable(
                name: "Drink",
                columns: table => new
                {
                    DrinkID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DrinkName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drink", x => x.DrinkID);
                });

            migrationBuilder.CreateTable(
                name: "SpecificPrice",
                columns: table => new
                {
                    SpecificPriceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BarID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DrinkID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DrinkPrice = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecificPrice", x => x.SpecificPriceID);
                    table.ForeignKey(
                        name: "FK_SpecificPrice_Bar_BarID",
                        column: x => x.BarID,
                        principalTable: "Bar",
                        principalColumn: "BarID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpecificPrice_Drink_DrinkID",
                        column: x => x.DrinkID,
                        principalTable: "Drink",
                        principalColumn: "DrinkID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SpecificPrice_BarID",
                table: "SpecificPrice",
                column: "BarID");

            migrationBuilder.CreateIndex(
                name: "IX_SpecificPrice_DrinkID",
                table: "SpecificPrice",
                column: "DrinkID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpecificPrice");

            migrationBuilder.DropTable(
                name: "Bar");

            migrationBuilder.DropTable(
                name: "Drink");
        }
    }
}
