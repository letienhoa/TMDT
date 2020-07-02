using Microsoft.EntityFrameworkCore.Migrations;

namespace Website_BanDienThoai_Version1.Migrations
{
    public partial class addDatabaseNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isConfirmed",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "CustomerNumberPhone",
                table: "Appointments",
                newName: "CustomerPhoneNumber");

            migrationBuilder.RenameColumn(
                name: "AppointmentsDate",
                table: "Appointments",
                newName: "BillDate");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppointmentDate",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerEmail",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalPrice",
                table: "Appointments",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentDate",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "CustomerEmail",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "CustomerPhoneNumber",
                table: "Appointments",
                newName: "CustomerNumberPhone");

            migrationBuilder.RenameColumn(
                name: "BillDate",
                table: "Appointments",
                newName: "AppointmentsDate");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Products",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<bool>(
                name: "isConfirmed",
                table: "Appointments",
                nullable: false,
                defaultValue: false);
        }
    }
}
