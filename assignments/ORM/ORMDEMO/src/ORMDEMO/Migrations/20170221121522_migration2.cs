using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ORMDEMO.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    PID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HomePageUrl = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.PID);
                });

            migrationBuilder.CreateTable(
                name: "Updates",
                columns: table => new
                {
                    UpdateID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductTablePID = table.Column<int>(nullable: true),
                    UpdateDescription = table.Column<string>(nullable: true),
                    UpdateName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Updates", x => x.UpdateID);
                    table.ForeignKey(
                        name: "FK_Updates_Products_ProductTablePID",
                        column: x => x.ProductTablePID,
                        principalTable: "Products",
                        principalColumn: "PID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Updates_ProductTablePID",
                table: "Updates",
                column: "ProductTablePID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Updates");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
