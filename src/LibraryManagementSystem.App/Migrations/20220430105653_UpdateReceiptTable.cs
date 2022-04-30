using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreManagementSystem.App.Migrations
{
    public partial class UpdateReceiptTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerAddress",
                table: "Receipts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerEmail",
                table: "Receipts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Receipts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerPhoneNumber",
                table: "Receipts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Debt",
                table: "Receipts",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerAddress",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "CustomerEmail",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "CustomerPhoneNumber",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "Debt",
                table: "Receipts");
        }
    }
}
