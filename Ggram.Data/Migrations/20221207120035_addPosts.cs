using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ggram.Data.Migrations
{
    public partial class addPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_ApplicationUserId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_ApplicationUserId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Posts");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Posts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Posts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97725a7c-7813-45f7-b112-1e1d0a781ed0", "AQAAAAEAACcQAAAAENKMB3MXwDqcbdbeDW5JjB2nZFPBAelLvcq6UWzhQ7zrCgkG7o2JptLu2QY9dyiCig==", "ae528775-4462-4f13-8dae-d4b440e0168c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb410aef-6919-41a7-8bfc-5159f1ff10b7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97f57c27-e932-44db-82d4-26347baf4974", "AQAAAAEAACcQAAAAEDGRaO0YEpGAqsNpVMIsBoFccDTKqDletz2+WTap0OFbLXdCsX1Z95gLfYTxMpcCqA==", "2b89169c-a943-4471-93ec-ffaa3f8b614d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8791a036-addb-4442-8eb3-e5db726d53ee", "AQAAAAEAACcQAAAAENxflM0SHDcTkVQPsE/y8usSIqePww5HfZAHuY6A+952LJMYalCWixlqGGaDXX1aIQ==", "c18f2669-dcfc-47cc-b9fc-16041b3d6c24" });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_UserId",
                table: "Posts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_UserId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_UserId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Posts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a43eff3-e5a9-469b-a790-2ae6b949eaf8", "AQAAAAEAACcQAAAAEHfnS4gvcVlnSF4hMIV5lj2i0wpxL5NXyxHh4CabnIaN1LWzN5e92EmCjNWYaIcRZA==", "e7fbcc16-67e9-4762-a917-e7ffab372ebf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb410aef-6919-41a7-8bfc-5159f1ff10b7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f64ec66f-e99d-4cda-b80e-e55e7e174245", "AQAAAAEAACcQAAAAEIuZcyutperec/zWCKcvCmOAzdejfbpEKCZM5lZBL9aiymZQbXNuOkbrm7JqrxHbbg==", "9b34f7a0-b0a6-4222-9790-e6b95c94aae1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81a74582-9482-4f37-8a11-8920b92de325", "AQAAAAEAACcQAAAAEPAS2y2ZcnfgUTqq1fHl6RvA1qkdxOQfdFS3Yfrdw4I/2NfwUzEQA5nj/JtRjYVj0Q==", "62609995-efd7-4fa0-8665-b76ac8ebf012" });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ApplicationUserId",
                table: "Posts",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_ApplicationUserId",
                table: "Posts",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
