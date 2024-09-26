using Microsoft.EntityFrameworkCore.Migrations;

namespace Website_BanDienThoai_Version1.Migrations
{
    public partial class DatabaseNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Bill_Details_BillId1",
                table: "Bill_Details",
                column: "BillId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Bill_Details_BillId1",
                table: "Bill_Details");
        }
    }
}
