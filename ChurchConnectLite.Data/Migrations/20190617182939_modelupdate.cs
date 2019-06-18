using Microsoft.EntityFrameworkCore.Migrations;

namespace ChurchConnectLite.Data.Migrations
{
    public partial class modelupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Churches",
                newName: "YearFounded");

            migrationBuilder.RenameColumn(
                name: "Account",
                table: "Churches",
                newName: "BankName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YearFounded",
                table: "Churches",
                newName: "Year");

            migrationBuilder.RenameColumn(
                name: "BankName",
                table: "Churches",
                newName: "Account");
        }
    }
}
