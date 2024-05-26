using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Data.Migrations
{
    public partial class HomeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "App Configs",
                keyColumn: "Key",
                keyValue: "HomeDescription",
                column: "Value",
                value: "This is description of eShopSolution");

            migrationBuilder.UpdateData(
                table: "App Configs",
                keyColumn: "Key",
                keyValue: "HomeKeyword",
                column: "Value",
                value: "This is keyword of eShopSolution");

            migrationBuilder.UpdateData(
                table: "App Configs",
                keyColumn: "Key",
                keyValue: "HomeTitle",
                column: "Value",
                value: "This is home page of eShopSolution");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "1dbbe5d1-d82f-49f3-8b8c-2bcd4cc838cb");

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("8d04dce2-969a-435d-bba4-df3f325983dc") });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "8e5fd055-8888-4874-bcb7-1183f2504f1a", "tedu.international@gmail.com", "Toan", "Bach", "tedu.international@gmail.com", "AQAAAAEAACcQAAAAEB/Sj8YO8b1j5Kl1jdoblqtVTlQV9XjEOHU/cVTxsYwV9TJ5jGo9/3twGHmwqHa3Nw==" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "en",
                column: "IsDefault",
                value: false);

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "vi",
                columns: new[] { "IsDefault", "Name" },
                values: new object[] { true, "Tiếng Việt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 5, 26, 17, 40, 17, 340, DateTimeKind.Local).AddTicks(1802));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("8d04dce2-969a-435d-bba4-df3f325983dc") });

            migrationBuilder.UpdateData(
                table: "App Configs",
                keyColumn: "Key",
                keyValue: "HomeDescription",
                column: "Value",
                value: "This is description of Shop");

            migrationBuilder.UpdateData(
                table: "App Configs",
                keyColumn: "Key",
                keyValue: "HomeKeyword",
                column: "Value",
                value: "This is keyword of Shop");

            migrationBuilder.UpdateData(
                table: "App Configs",
                keyColumn: "Key",
                keyValue: "HomeTitle",
                column: "Value",
                value: "This is home page of Shop");

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
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "8225dea7-eeb0-479f-bd00-0b141f50004a", "nguyentrungtrucl@gmail.com", "Truc", "Nguyen", "trungtruc.international@gmail.com", "AQAAAAEAACcQAAAAEJvMGNfPFxgl+vijhsAARZzy2/86FL37AUJl5S5KepBzhAl9mXbjKTnDIVs1OSnl/A==" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "en",
                column: "IsDefault",
                value: true);

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "vi",
                columns: new[] { "IsDefault", "Name" },
                values: new object[] { false, "Tieng Viet" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 5, 20, 16, 10, 45, 638, DateTimeKind.Local).AddTicks(8524));
        }
    }
}
