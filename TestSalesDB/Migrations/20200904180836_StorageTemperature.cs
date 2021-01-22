using Microsoft.EntityFrameworkCore.Migrations;

namespace TestSalesDB.Migrations
{
    public partial class StorageTemperature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "StorageTemperature",
                table: "Products",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MaxTemperature",
                table: "Branches",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MinTemperature",
                table: "Branches",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StorageTemperature",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MaxTemperature",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "MinTemperature",
                table: "Branches");
        }
    }
}
