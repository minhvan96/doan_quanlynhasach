using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreManagementSystem.App.Migrations
{
    public partial class UpdateStaffAndBookStoreRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BookStoreId",
                table: "Staffs",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BookStoreId1",
                table: "Staffs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_BookStoreId",
                table: "Staffs",
                column: "BookStoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_BookStoreId1",
                table: "Staffs",
                column: "BookStoreId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_BookStores_BookStoreId",
                table: "Staffs",
                column: "BookStoreId",
                principalTable: "BookStores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_BookStores_BookStoreId1",
                table: "Staffs",
                column: "BookStoreId1",
                principalTable: "BookStores",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_BookStores_BookStoreId",
                table: "Staffs");

            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_BookStores_BookStoreId1",
                table: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_Staffs_BookStoreId",
                table: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_Staffs_BookStoreId1",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "BookStoreId",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "BookStoreId1",
                table: "Staffs");
        }
    }
}
