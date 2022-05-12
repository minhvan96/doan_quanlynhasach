using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreManagementSystem.App.Migrations
{
    public partial class UpdateStaffAndBookStoreRelationRemoveDuplicateForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_BookStores_BookStoreId1",
                table: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_Staffs_BookStoreId1",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "BookStoreId1",
                table: "Staffs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BookStoreId1",
                table: "Staffs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_BookStoreId1",
                table: "Staffs",
                column: "BookStoreId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_BookStores_BookStoreId1",
                table: "Staffs",
                column: "BookStoreId1",
                principalTable: "BookStores",
                principalColumn: "Id");
        }
    }
}
