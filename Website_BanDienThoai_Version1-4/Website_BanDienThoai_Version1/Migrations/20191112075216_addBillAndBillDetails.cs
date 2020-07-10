using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Website_BanDienThoai_Version1.Migrations
{
    public partial class addBillAndBillDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bill",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<int>(nullable: false),
                    BillDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bill_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bill_Details",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    BillId = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill_Details", x => new { x.ProductId, x.BillId });
                    table.ForeignKey(
                        name: "FK_Bill_Details_Bill_BillId",
                        column: x => x.BillId,
                        principalTable: "Bill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                       name: "FK_Bill_Details_Products_ProductId",
                       column: x => x.ProductId,
                       principalTable: "Products",
                       principalColumn: "Id",
                       onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_UserId",
                table: "Bill",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_Details_BillId",
                table: "Bill_Details",
                column: "BillId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bill_Details");

            migrationBuilder.DropTable(
                name: "Bill");
        }
    }
}
