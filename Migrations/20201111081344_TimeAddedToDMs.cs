using Microsoft.EntityFrameworkCore.Migrations;

namespace CarMarket.Migrations
{
    public partial class TimeAddedToDMs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "timePosted",
                table: "DirectMessages",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "timePosted",
                table: "DirectMessages");
        }
    }
}
