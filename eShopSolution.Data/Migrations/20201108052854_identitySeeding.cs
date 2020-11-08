using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class identitySeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 8, 12, 28, 53, 241, DateTimeKind.Local).AddTicks(1561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 8, 10, 50, 26, 120, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("bb97d77d-565e-4d10-82f6-3cb15f355002"), "292112bc-c997-4334-a7a7-d07d3fad7569", "Admin Role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUSers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("aab36913-def1-4c72-93c8-b9995243356f"), 0, "97696d9d-bda7-4f20-afa2-77cab796e59e", new DateTime(1999, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Van", "Nguyen", false, null, "admin@gmail.com", "admin", "AQAAAAEAACcQAAAAELXZb+RBVq3jIeRIBzboZKCFMQBwA8NYCqiecRQuZAXqqfGeBU/UE90kC4PvsKcD+g==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("aab36913-def1-4c72-93c8-b9995243356f"), new Guid("bb97d77d-565e-4d10-82f6-3cb15f355002") });

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
                value: new DateTime(2020, 11, 8, 12, 28, 53, 264, DateTimeKind.Local).AddTicks(8733));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("bb97d77d-565e-4d10-82f6-3cb15f355002"));

            migrationBuilder.DeleteData(
                table: "AppUSers",
                keyColumn: "Id",
                keyValue: new Guid("aab36913-def1-4c72-93c8-b9995243356f"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("aab36913-def1-4c72-93c8-b9995243356f"), new Guid("bb97d77d-565e-4d10-82f6-3cb15f355002") });

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 8, 10, 50, 26, 120, DateTimeKind.Local).AddTicks(4607),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 8, 12, 28, 53, 241, DateTimeKind.Local).AddTicks(1561));

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
                value: new DateTime(2020, 11, 8, 10, 50, 26, 148, DateTimeKind.Local).AddTicks(6048));
        }
    }
}
