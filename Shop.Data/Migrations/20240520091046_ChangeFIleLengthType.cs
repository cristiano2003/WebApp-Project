using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Data.Migrations
{
    public partial class ChangeFIleLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "e5489ccd-65a9-43d7-9a3e-4e41a7db9104");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8225dea7-eeb0-479f-bd00-0b141f50004a", "AQAAAAEAACcQAAAAEJvMGNfPFxgl+vijhsAARZzy2/86FL37AUJl5S5KepBzhAl9mXbjKTnDIVs1OSnl/A==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 5, 20, 16, 10, 45, 638, DateTimeKind.Local).AddTicks(8524));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
