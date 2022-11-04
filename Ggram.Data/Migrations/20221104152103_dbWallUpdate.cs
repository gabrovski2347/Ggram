using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ggram.Web.Data.Migrations
{
    public partial class dbWallUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_UserId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Wall_WallId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_AspNetUsers_SenderId",
                table: "Request");

            migrationBuilder.DropForeignKey(
                name: "FK_Wall_AspNetUsers_OwnerId",
                table: "Wall");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wall",
                table: "Wall");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Request",
                table: "Request");

            migrationBuilder.RenameTable(
                name: "Wall",
                newName: "Walls");

            migrationBuilder.RenameTable(
                name: "Request",
                newName: "Requests");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "AspNetUsers",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_UserId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Wall_OwnerId",
                table: "Walls",
                newName: "IX_Walls_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Request_SenderId",
                table: "Requests",
                newName: "IX_Requests_SenderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Walls",
                table: "Walls",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Requests",
                table: "Requests",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_ApplicationUserId",
                table: "AspNetUsers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Walls_WallId",
                table: "Posts",
                column: "WallId",
                principalTable: "Walls",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_AspNetUsers_SenderId",
                table: "Requests",
                column: "SenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Walls_AspNetUsers_OwnerId",
                table: "Walls",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_ApplicationUserId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Walls_WallId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_AspNetUsers_SenderId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Walls_AspNetUsers_OwnerId",
                table: "Walls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Walls",
                table: "Walls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Requests",
                table: "Requests");

            migrationBuilder.RenameTable(
                name: "Walls",
                newName: "Wall");

            migrationBuilder.RenameTable(
                name: "Requests",
                newName: "Request");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "AspNetUsers",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_ApplicationUserId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Walls_OwnerId",
                table: "Wall",
                newName: "IX_Wall_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Requests_SenderId",
                table: "Request",
                newName: "IX_Request_SenderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wall",
                table: "Wall",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Request",
                table: "Request",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_UserId",
                table: "AspNetUsers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Wall_WallId",
                table: "Posts",
                column: "WallId",
                principalTable: "Wall",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Request_AspNetUsers_SenderId",
                table: "Request",
                column: "SenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wall_AspNetUsers_OwnerId",
                table: "Wall",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
