using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Data.Migrations
{
    public partial class SecondNewData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "d6054bef-2f66-4ed6-942a-1621768f4f41");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "22293714-66e8-4933-b047-56a331fb7337", "AQAAAAEAACcQAAAAEJVYV73S6//bvbr734Wwh9/Unz0mTnfeZKU1STYcvCZxC082cQE3A+xLQXb+gXenIQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 6, 1, 22, 1, 36, 510, DateTimeKind.Local).AddTicks(3265));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
