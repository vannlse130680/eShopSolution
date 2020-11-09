using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLenghtType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("bb97d77d-565e-4d10-82f6-3cb15f355002"),
                column: "ConcurrencyStamp",
                value: "4724942d-f289-4d43-8006-c6539938c477");

            migrationBuilder.UpdateData(
                table: "AppUSers",
                keyColumn: "Id",
                keyValue: new Guid("aab36913-def1-4c72-93c8-b9995243356f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7d14659f-76af-4c1a-9803-d017f61f7548", "AQAAAAEAACcQAAAAEA3bmIBB2AIEiZsPc2YSUXLKfUNSFo2ojH+b6+QLvaIU07lOHmxelfZJALBpPUOPzA==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 11, 8, 18, 42, 54, 858, DateTimeKind.Local).AddTicks(7348));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("bb97d77d-565e-4d10-82f6-3cb15f355002"),
                column: "ConcurrencyStamp",
                value: "a2fc0ff0-e891-4698-b957-8c214f63e91b");

            migrationBuilder.UpdateData(
                table: "AppUSers",
                keyColumn: "Id",
                keyValue: new Guid("aab36913-def1-4c72-93c8-b9995243356f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ade5ecc8-a1dd-46b3-98cd-18126f1ca8da", "AQAAAAEAACcQAAAAEOU6x6NbfBSn0ydArUI3UKBVeaRkuMj1HQ9IoKfuCtxf5PAxJuyl8CzuDMv5bmmkUg==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 11, 8, 17, 38, 39, 429, DateTimeKind.Local).AddTicks(3181));
        }
    }
}
