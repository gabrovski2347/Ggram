using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ggram.Data.Migrations
{
    public partial class addisDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Followeds",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Followeds");

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
        }
    }
}
