using Microsoft.EntityFrameworkCore.Migrations;

namespace CarMarket.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarListings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateAdded = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ProductionYear = table.Column<int>(nullable: false),
                    Mileage = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Descrition = table.Column<string>(type: "nvarchar(1000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarListings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DirectMessages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserIdFrom = table.Column<int>(nullable: false),
                    UserIdTo = table.Column<int>(nullable: false),
                    MessageContent = table.Column<string>(type: "nvarchar(500)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectMessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(12)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarListings");

            migrationBuilder.DropTable(
                name: "DirectMessages");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
