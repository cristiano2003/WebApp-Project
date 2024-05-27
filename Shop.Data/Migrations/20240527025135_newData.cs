using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Data.Migrations
{
    public partial class newData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "5b706761-0eb5-4962-aede-b9657ab39390");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "30bee02e-0b1e-409f-9d9d-b55588384ff9", "AQAAAAEAACcQAAAAEF+Gvel5bfm/w2AZK7jNJWHA5p4GT65SU9xUWFNSAzF9gqoVXCUwxcNYLVmCVJvLcw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 5, 27, 9, 51, 35, 132, DateTimeKind.Local).AddTicks(9145));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "1dbbe5d1-d82f-49f3-8b8c-2bcd4cc838cb");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8e5fd055-8888-4874-bcb7-1183f2504f1a", "AQAAAAEAACcQAAAAEB/Sj8YO8b1j5Kl1jdoblqtVTlQV9XjEOHU/cVTxsYwV9TJ5jGo9/3twGHmwqHa3Nw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 5, 26, 17, 40, 17, 340, DateTimeKind.Local).AddTicks(1802));
        }
    }
}
