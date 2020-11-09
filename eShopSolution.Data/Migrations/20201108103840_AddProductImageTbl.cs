using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 8, 12, 28, 53, 241, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 8, 12, 28, 53, 241, DateTimeKind.Local).AddTicks(1561),
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("bb97d77d-565e-4d10-82f6-3cb15f355002"),
                column: "ConcurrencyStamp",
                value: "292112bc-c997-4334-a7a7-d07d3fad7569");

            migrationBuilder.UpdateData(
                table: "AppUSers",
                keyColumn: "Id",
                keyValue: new Guid("aab36913-def1-4c72-93c8-b9995243356f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "97696d9d-bda7-4f20-afa2-77cab796e59e", "AQAAAAEAACcQAAAAELXZb+RBVq3jIeRIBzboZKCFMQBwA8NYCqiecRQuZAXqqfGeBU/UE90kC4PvsKcD+g==" });

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
    }
}
