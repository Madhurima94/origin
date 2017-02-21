using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ORMDEMO.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Updates_Products_ProductTablePID",
                table: "Updates");

            migrationBuilder.DropIndex(
                name: "IX_Updates_ProductTablePID",
                table: "Updates");

            migrationBuilder.DropColumn(
                name: "ProductTablePID",
                table: "Updates");

            migrationBuilder.AddColumn<int>(
                name: "PID",
                table: "Updates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Updates_PID",
                table: "Updates",
                column: "PID");

            migrationBuilder.AddForeignKey(
                name: "FK_Updates_Products_PID",
                table: "Updates",
                column: "PID",
                principalTable: "Products",
                principalColumn: "PID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Updates_Products_PID",
                table: "Updates");

            migrationBuilder.DropIndex(
                name: "IX_Updates_PID",
                table: "Updates");

            migrationBuilder.DropColumn(
                name: "PID",
                table: "Updates");

            migrationBuilder.AddColumn<int>(
                name: "ProductTablePID",
                table: "Updates",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Updates_ProductTablePID",
                table: "Updates",
                column: "ProductTablePID");

            migrationBuilder.AddForeignKey(
                name: "FK_Updates_Products_ProductTablePID",
                table: "Updates",
                column: "ProductTablePID",
                principalTable: "Products",
                principalColumn: "PID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
