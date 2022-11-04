using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ggram.Web.Data.Migrations
{
    public partial class addWallId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WallId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WallId",
                table: "AspNetUsers");
        }
    }
}
