using Microsoft.EntityFrameworkCore.Migrations;

namespace WebService.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bars");

            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.RenameTable(
                name: "SpecificPrices",
                newName: "SpecificPrice");

            migrationBuilder.AddColumn<int>(
                name: "SpecificPriceID",
                table: "SpecificPrice",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpecificPrice",
                table: "SpecificPrice",
                column: "SpecificPriceID");

            migrationBuilder.CreateTable(
                name: "Bar",
                columns: table => new
                {
                    BarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    DrinkID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrinkName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drink", x => x.DrinkID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SpecificPrice_BarID",
                table: "SpecificPrice",
                column: "BarID");

            migrationBuilder.CreateIndex(
                name: "IX_SpecificPrice_DrinkID",
                table: "SpecificPrice",
                column: "DrinkID");

            migrationBuilder.AddForeignKey(
                name: "FK_SpecificPrice_Bar_BarID",
                table: "SpecificPrice",
                column: "BarID",
                principalTable: "Bar",
                principalColumn: "BarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SpecificPrice_Drink_DrinkID",
                table: "SpecificPrice",
                column: "DrinkID",
                principalTable: "Drink",
                principalColumn: "DrinkID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpecificPrice_Bar_BarID",
                table: "SpecificPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_SpecificPrice_Drink_DrinkID",
                table: "SpecificPrice");

            migrationBuilder.DropTable(
                name: "Bar");

            migrationBuilder.DropTable(
                name: "Drink");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SpecificPrice",
                table: "SpecificPrice");

            migrationBuilder.DropIndex(
                name: "IX_SpecificPrice_BarID",
                table: "SpecificPrice");

            migrationBuilder.DropIndex(
                name: "IX_SpecificPrice_DrinkID",
                table: "SpecificPrice");

            migrationBuilder.DropColumn(
                name: "SpecificPriceID",
                table: "SpecificPrice");

            migrationBuilder.RenameTable(
                name: "SpecificPrice",
                newName: "SpecificPrices");

            migrationBuilder.CreateTable(
                name: "Bars",
                columns: table => new
                {
                    barID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    barLocation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    barName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bars", x => x.barID);
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    drinkID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    drinkName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.drinkID);
                });
        }
    }
}
