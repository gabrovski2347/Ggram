using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ggram.Data.Migrations
{
    public partial class FollowersFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friends_AspNetUsers_FollowerId",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFollowed_AspNetUsers_FollowedId",
                table: "UserFollowed");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserFollowed",
                table: "UserFollowed");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Friends",
                table: "Friends");

            migrationBuilder.RenameTable(
                name: "UserFollowed",
                newName: "Followeds");

            migrationBuilder.RenameTable(
                name: "Friends",
                newName: "Followers");

            migrationBuilder.RenameIndex(
                name: "IX_UserFollowed_FollowedId",
                table: "Followeds",
                newName: "IX_Followeds_FollowedId");

            migrationBuilder.RenameIndex(
                name: "IX_Friends_FollowerId",
                table: "Followers",
                newName: "IX_Followers_FollowerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Followeds",
                table: "Followeds",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Followers",
                table: "Followers",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b55971d2-91c9-43e5-a223-02d058a89089", "AQAAAAEAACcQAAAAEBnOP6sOzf8VSehRrsGuBaiZEo4hjB4FcczkV79OZRJs8qTAQOYarFUl6/HFrkX/iw==", "c04b35da-c6ee-4c75-8bf9-afd99048d3ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb410aef-6919-41a7-8bfc-5159f1ff10b7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc7f7cdf-13a7-4c9c-832d-f5e41e4d9f78", "AQAAAAEAACcQAAAAEDTIl8FielNYH125zWF1KeI6ATVFDIILzLus/j4qOYxTuqnBoOu7uAX6/PoK4NzbTw==", "3f5646c1-76a3-41af-9ca5-5df86d721561" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "311f82bf-381a-4632-810f-dc6a8a79f86f", "AQAAAAEAACcQAAAAEAd4Bod3qhAGr/7NU9+3vZ9ofj3Wolu2DOqF9NdXkiYmU8y7BRR0AEhwd8ZSkB1HaQ==", "30ad4b46-f900-4f67-b3a0-2d1e275fea79" });

            migrationBuilder.AddForeignKey(
                name: "FK_Followeds_AspNetUsers_FollowedId",
                table: "Followeds",
                column: "FollowedId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Followers_AspNetUsers_FollowerId",
                table: "Followers",
                column: "FollowerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Followeds_AspNetUsers_FollowedId",
                table: "Followeds");

            migrationBuilder.DropForeignKey(
                name: "FK_Followers_AspNetUsers_FollowerId",
                table: "Followers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Followers",
                table: "Followers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Followeds",
                table: "Followeds");

            migrationBuilder.RenameTable(
                name: "Followers",
                newName: "Friends");

            migrationBuilder.RenameTable(
                name: "Followeds",
                newName: "UserFollowed");

            migrationBuilder.RenameIndex(
                name: "IX_Followers_FollowerId",
                table: "Friends",
                newName: "IX_Friends_FollowerId");

            migrationBuilder.RenameIndex(
                name: "IX_Followeds_FollowedId",
                table: "UserFollowed",
                newName: "IX_UserFollowed_FollowedId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Friends",
                table: "Friends",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserFollowed",
                table: "UserFollowed",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d55d1f7-fae3-4897-877f-61ad49ac5862", "AQAAAAEAACcQAAAAEOxLNgeP9A0jo+p/N9662S0yZrXb+P3Tebfi2AIJX2Co9FXOnkRwz1guJ7ulFk4zlQ==", "5f36a598-7560-4d5f-993e-f5751590f6c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb410aef-6919-41a7-8bfc-5159f1ff10b7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8273fc3-80c9-4916-9341-097fa1191f32", "AQAAAAEAACcQAAAAEFTcDfNUgZGs6xXUKbO/M7mbe4qMZi0aQXD9T8/euaSDTtCqQ+iryn+39UuXy/j4qw==", "917506ab-96e8-4920-b19f-5d9a5e7b9bba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "388545fa-2cfe-4635-b95a-506326f2ac3c", "AQAAAAEAACcQAAAAEIk/AWCl0D9r0K4d3+OK6aVAHhKEG75OB26RpptYP9BjnTMwRxlK4Bb9oN9wQtGxxQ==", "9ff45f12-30eb-47ea-91c7-fc44b4cb25d4" });

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_AspNetUsers_FollowerId",
                table: "Friends",
                column: "FollowerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFollowed_AspNetUsers_FollowedId",
                table: "UserFollowed",
                column: "FollowedId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
