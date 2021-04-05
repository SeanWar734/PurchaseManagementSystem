using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagement.Api.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e3a4e62-6408-4395-a425-1316adfd51cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ccc06cdd-e1d2-46c4-b687-d6a0d3c0e3a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f28dde68-9042-40ab-aae3-9c2fde58137a"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("c997673f-e403-4f91-bb7a-6dd15d76de6a"), "Kroger", "One Gallon of Milk", "Milk", new Guid("7e42a3b7-f02f-442d-97ef-2b13bb423414") },
                    { new Guid("fbb01de7-b1bb-4ff2-850f-637a77f8a8f3"), "Kroger", "One Carton of a Dozen Eggs", "Eggs", new Guid("5a077aa8-c217-4209-a70c-dd92c2d10b09") },
                    { new Guid("638d4da9-a377-43fe-bb22-d50d2dd320e4"), "Dole", "One Honeycrisp Apple", "Honecrisp Apple", new Guid("209bc539-de7d-4a75-9590-eabb17e2cf8d") },
                    { new Guid("6b5a6deb-23a3-4377-8d35-70d8d0bf5e74"), "Dole", "One Yellow Banana", "Banana", new Guid("209bc539-de7d-4a75-9590-eabb17e2cf8d") },
                    { new Guid("cb259b96-2b84-4e3f-ad4d-06e1e7274d8e"), "Dole", "One Green Plump Cucumber", "Cucumber", new Guid("ba24f865-0af3-4ce1-b123-0f1dcd1e3020") },
                    { new Guid("d190a2df-89e4-4374-bdf0-4715a81b2917"), "King Arthur", "One Bag of Flour", "Flour", new Guid("52411182-ff92-46ec-9233-a76ffb190339") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("638d4da9-a377-43fe-bb22-d50d2dd320e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b5a6deb-23a3-4377-8d35-70d8d0bf5e74"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c997673f-e403-4f91-bb7a-6dd15d76de6a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb259b96-2b84-4e3f-ad4d-06e1e7274d8e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d190a2df-89e4-4374-bdf0-4715a81b2917"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fbb01de7-b1bb-4ff2-850f-637a77f8a8f3"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "ProductCategoryId" },
                values: new object[] { new Guid("5e3a4e62-6408-4395-a425-1316adfd51cf"), "Kroger", "One Gallon of Milk", "Milk", new Guid("7e42a3b7-f02f-442d-97ef-2b13bb423414") });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "ProductCategoryId" },
                values: new object[] { new Guid("f28dde68-9042-40ab-aae3-9c2fde58137a"), "Kroger", "One Carton of a Dozen Eggs", "Eggs", new Guid("7e42a3b7-f02f-442d-97ef-2b13bb423414") });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "ProductCategoryId" },
                values: new object[] { new Guid("ccc06cdd-e1d2-46c4-b687-d6a0d3c0e3a8"), "Kroger", "One Carton of a Dozen Eggs", "Eggs", new Guid("209bc539-de7d-4a75-9590-eabb17e2cf8d") });
        }
    }
}
