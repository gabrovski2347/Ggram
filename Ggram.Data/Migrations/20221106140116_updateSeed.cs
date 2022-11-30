using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ggram.Web.Data.Migrations
{
    public partial class updateSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61ff3522-f024-4da2-8afb-3899ac9b455e", "AQAAAAEAACcQAAAAEGwJcW3BKeVSK2TW2CstMEsrTa08PFK9BicI3zSf/3oISESuxWD+iaG18Wax6e/NWQ==", "d0df57c6-b504-4b22-9d42-0e9eaa7763ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb410aef-6919-41a7-8bfc-5159f1ff10b7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c17e8e7-71d4-48b9-ba9a-e853d120f174", "AQAAAAEAACcQAAAAEG+yRCp3vjw/xvId48ZOQIykXjK9MGfqZpowBzDzyQpuZd++diDufIGReJMlosH93w==", "a216d7a2-bda5-4c78-9fef-abc288bf3ef0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b5901f2-f206-40d6-83f5-10e39c15ad40", "AQAAAAEAACcQAAAAEGSlEBC+O8j5+ZAH1f02pTTCLR42QIgBXqZSysLyx7UDN4U7DO2iDxtUYp7Z4UcVsQ==", "6fa1b6b7-fd41-4c50-8472-aca42e502c2d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1182a75f-5e88-4052-9e3b-30c5132d0a5f", null, "f84709bc-393d-436f-9792-f8266b2141b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb410aef-6919-41a7-8bfc-5159f1ff10b7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8d35d9a-73f4-4122-bdce-03feccf9bd06", null, "f40b8b57-abe9-41a9-835d-231ad2682ab1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a89bf276-0f9e-4369-9068-85998532556d", "AQAAAAEAACcQAAAAEDxVIOqqN2CnapzC5b0GMEgYks8p2U//hvx0IkL2/ehStDvMTDcoPgfUXLNgExrSmA==", "db978934-89ac-4162-b99e-b97ae8d32ea8" });
        }
    }
}
