using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestSalesDB.Migrations
{
    /// <inheritdoc />
    public partial class AddedMetaFiled : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OptionalProducts_Products_Id",
                table: "OptionalProducts");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Suppliers");

            migrationBuilder.AddColumn<string>(
                name: "CreationInfo",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OptionalProducts_Products_Id",
                table: "OptionalProducts",
                column: "Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OptionalProducts_Products_Id",
                table: "OptionalProducts");

            migrationBuilder.DropColumn(
                name: "CreationInfo",
                table: "Suppliers");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Suppliers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Suppliers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_OptionalProducts_Products_Id",
                table: "OptionalProducts",
                column: "Id",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
