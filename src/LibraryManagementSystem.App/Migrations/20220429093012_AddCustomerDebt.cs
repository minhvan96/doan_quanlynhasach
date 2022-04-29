using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreManagementSystem.App.Migrations
{
    public partial class AddCustomerDebt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AmountOfReceivedMoney",
                table: "Receipts",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<Guid>(
                name: "StaffId",
                table: "Receipts",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "CustomerDebts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomerId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Debt = table.Column<decimal>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDebts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerDebts_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_StaffId",
                table: "Receipts",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDebts_CustomerId",
                table: "CustomerDebts",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Receipts_Staffs_StaffId",
                table: "Receipts",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receipts_Staffs_StaffId",
                table: "Receipts");

            migrationBuilder.DropTable(
                name: "CustomerDebts");

            migrationBuilder.DropIndex(
                name: "IX_Receipts_StaffId",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "AmountOfReceivedMoney",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Receipts");
        }
    }
}
