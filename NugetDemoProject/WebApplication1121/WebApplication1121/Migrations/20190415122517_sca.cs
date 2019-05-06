using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1121.Migrations
{
    public partial class sca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserJa",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserJa",
                table: "Users");
        }
    }
}
