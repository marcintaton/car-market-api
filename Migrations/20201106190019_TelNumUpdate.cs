using Microsoft.EntityFrameworkCore.Migrations;

namespace CarMarket.Migrations
{
    public partial class TelNumUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TelephoneNumber",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TelephoneNumber",
                table: "Users",
                type: "nvarchar(12)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
