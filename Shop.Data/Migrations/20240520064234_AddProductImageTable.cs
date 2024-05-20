using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "d1bc410b-f542-47d0-b542-842eda52b733");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "718d4d33-cd83-49c3-ab14-c8762d27936d", "AQAAAAEAACcQAAAAEGBXnwS35M2WGeoivME4FiDmYysHwfb8RDPojjaGNHW+2GaBrymq35l+F/0YScDQ9A==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 5, 20, 13, 42, 33, 800, DateTimeKind.Local).AddTicks(903));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "7f8c9f41-00de-4a45-a99d-1a1703c169f9");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9735e53a-4497-4b5f-82f0-8e868c5a9124", "AQAAAAEAACcQAAAAEDSC5RQrTygzSY0QBb/aFmdbHEWjlB+luZ4EShyu8u8UUlbZSKlwlfAx7LW+qYD4nA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 5, 19, 23, 31, 52, 317, DateTimeKind.Local).AddTicks(1747));
        }
    }
}
