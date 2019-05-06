using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1121.Migrations
{
    public partial class idsn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                 nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
         
        }
    }
}
