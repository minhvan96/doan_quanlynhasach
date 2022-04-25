using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreManagementSystem.App.Migrations
{
    public partial class UpdateBookCodeAndPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Books",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Books");
        }
    }
}
