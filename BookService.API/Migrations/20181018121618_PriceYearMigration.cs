using Microsoft.EntityFrameworkCore.Migrations;

namespace BookService.WebAPI.Migrations
{
    public partial class PriceYearMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Books",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "Year" },
                values: new object[] { 20.50m, 2018 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "Year" },
                values: new object[] { 25m, 2016 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "Year" },
                values: new object[] { 16m, 2017 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "Year" },
                values: new object[] { 20m, 2016 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Price", "Year" },
                values: new object[] { 50m, 2018 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Price", "Year" },
                values: new object[] { 48m, 2017 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Price", "Year" },
                values: new object[] { 40m, 2016 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Books");
        }
    }
}
