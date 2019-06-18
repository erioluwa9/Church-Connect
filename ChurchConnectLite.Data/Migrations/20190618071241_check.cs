using Microsoft.EntityFrameworkCore.Migrations;

namespace ChurchConnectLite.Data.Migrations
{
    public partial class check : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Churches_ChurchesID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ChurchesID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ChurchesID",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Churches",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Churches_ApplicationUserId",
                table: "Churches",
                column: "ApplicationUserId",
                unique: true,
                filter: "[ApplicationUserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Churches_AspNetUsers_ApplicationUserId",
                table: "Churches",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Churches_AspNetUsers_ApplicationUserId",
                table: "Churches");

            migrationBuilder.DropIndex(
                name: "IX_Churches_ApplicationUserId",
                table: "Churches");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Churches");

            migrationBuilder.AddColumn<int>(
                name: "ChurchesID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ChurchesID",
                table: "AspNetUsers",
                column: "ChurchesID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Churches_ChurchesID",
                table: "AspNetUsers",
                column: "ChurchesID",
                principalTable: "Churches",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
