using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ggram.Web.Data.Migrations
{
    public partial class userSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApplicationUserId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "WallId" },
                values: new object[] { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, null, "312a33c4-e1c7-401e-88b4-65f419da235f", "guest@mail.com", false, "Georgi", "Petrov", false, null, "guest@mail.com", "guest@mail.com", null, null, false, "d66fa168-5528-42a3-9032-837fe60024e8", false, "guest@mail.com", "d8a02cd4-dc0b-40c4-8b1a-99069438ce00" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApplicationUserId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "WallId" },
                values: new object[] { "cb410aef-6919-41a7-8bfc-5159f1ff10b7", 0, null, "0895aef8-bc92-411b-8f44-821bc3600439", "test@mail.com", false, "Dimitar", "Geshev", false, null, "test@mail.com", "test@mail.com", null, null, false, "f9a19016-df19-4095-8420-d420a02c8ad2", false, "test@mail.com", "e3bf6ecf-16a5-4f20-86c1-2247168cdc55" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApplicationUserId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "WallId" },
                values: new object[] { "dea12856-c198-4129-b3f3-b893d8395082", 0, null, "1d25448f-bb1c-4aa4-a75d-c28d954bc28f", "agent@mail.com", false, "Petar", "Petrov", false, null, "agent@mail.com", "agent@mail.com", "AQAAAAEAACcQAAAAEKMWLZH47UWY49LNobEv8U+HE8z659d3K4+1va5YlFv2kBPEUC406ab6fWnDnIfCaQ==", null, false, "6e6a7736-4c45-4058-8a1e-87ec889b5a03", false, "agent@mail.com", "ba1eaa72-c7e6-4be9-a76f-cf7a12cc4c26" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb410aef-6919-41a7-8bfc-5159f1ff10b7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082");
        }
    }
}
