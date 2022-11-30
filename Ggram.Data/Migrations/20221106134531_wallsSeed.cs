using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ggram.Web.Data.Migrations
{
    public partial class wallsSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1182a75f-5e88-4052-9e3b-30c5132d0a5f", "f84709bc-393d-436f-9792-f8266b2141b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb410aef-6919-41a7-8bfc-5159f1ff10b7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f8d35d9a-73f4-4122-bdce-03feccf9bd06", "f40b8b57-abe9-41a9-835d-231ad2682ab1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a89bf276-0f9e-4369-9068-85998532556d", "AQAAAAEAACcQAAAAEDxVIOqqN2CnapzC5b0GMEgYks8p2U//hvx0IkL2/ehStDvMTDcoPgfUXLNgExrSmA==", "db978934-89ac-4162-b99e-b97ae8d32ea8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "312a33c4-e1c7-401e-88b4-65f419da235f", "d66fa168-5528-42a3-9032-837fe60024e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb410aef-6919-41a7-8bfc-5159f1ff10b7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0895aef8-bc92-411b-8f44-821bc3600439", "f9a19016-df19-4095-8420-d420a02c8ad2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d25448f-bb1c-4aa4-a75d-c28d954bc28f", "AQAAAAEAACcQAAAAEKMWLZH47UWY49LNobEv8U+HE8z659d3K4+1va5YlFv2kBPEUC406ab6fWnDnIfCaQ==", "6e6a7736-4c45-4058-8a1e-87ec889b5a03" });
        }
    }
}
