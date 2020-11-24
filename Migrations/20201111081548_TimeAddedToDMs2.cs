using Microsoft.EntityFrameworkCore.Migrations;

namespace CarMarket.Migrations
{
    public partial class TimeAddedToDMs2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "timePosted",
                table: "DirectMessages",
                newName: "TimePosted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TimePosted",
                table: "DirectMessages",
                newName: "timePosted");
        }
    }
}
