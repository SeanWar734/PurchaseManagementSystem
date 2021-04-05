using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagement.Api.Migrations
{
    public partial class AddTotalToPurchase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f91b809-ed57-467c-b97c-85b19cdd2866"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2bbd97c4-dd18-4ee9-b8b4-d91531b32c6b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e97f5e2-0de4-454f-b84e-273fa8972dc3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35b3256c-959c-4e27-9683-9169ab24afda"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bd411d3d-e53e-4fc3-8f8d-2e62abc499df"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e9dbd8f8-3769-43c8-884c-ad17d1fed827"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("ab9624f3-65eb-4d88-a565-66ba27089c2d"), "Kroger", "One Gallon of Milk", "Milk", new Guid("7e42a3b7-f02f-442d-97ef-2b13bb423414") },
                    { new Guid("66f8d272-68f9-4e69-a2aa-af66ee21977c"), "Kroger", "One Carton of a Dozen Eggs", "Eggs", new Guid("5a077aa8-c217-4209-a70c-dd92c2d10b09") },
                    { new Guid("91172686-07a1-4eaa-b7a3-41d84f11e105"), "Dole", "One Honeycrisp Apple", "Honecrisp Apple", new Guid("209bc539-de7d-4a75-9590-eabb17e2cf8d") },
                    { new Guid("4cacff9c-c5ba-4d07-87af-476ef6d4fc79"), "Dole", "One Yellow Banana", "Banana", new Guid("209bc539-de7d-4a75-9590-eabb17e2cf8d") },
                    { new Guid("79c4df5f-bf1c-46f6-94e0-9e118d7c8a86"), "Dole", "One Green Plump Cucumber", "Cucumber", new Guid("ba24f865-0af3-4ce1-b123-0f1dcd1e3020") },
                    { new Guid("90725252-8a2b-46de-99d7-a01241745550"), "King Arthur", "One Bag of Flour", "Flour", new Guid("52411182-ff92-46ec-9233-a76ffb190339") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4cacff9c-c5ba-4d07-87af-476ef6d4fc79"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66f8d272-68f9-4e69-a2aa-af66ee21977c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("79c4df5f-bf1c-46f6-94e0-9e118d7c8a86"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("90725252-8a2b-46de-99d7-a01241745550"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91172686-07a1-4eaa-b7a3-41d84f11e105"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab9624f3-65eb-4d88-a565-66ba27089c2d"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("2bbd97c4-dd18-4ee9-b8b4-d91531b32c6b"), "Kroger", "One Gallon of Milk", "Milk", new Guid("7e42a3b7-f02f-442d-97ef-2b13bb423414") },
                    { new Guid("e9dbd8f8-3769-43c8-884c-ad17d1fed827"), "Kroger", "One Carton of a Dozen Eggs", "Eggs", new Guid("5a077aa8-c217-4209-a70c-dd92c2d10b09") },
                    { new Guid("0f91b809-ed57-467c-b97c-85b19cdd2866"), "Dole", "One Honeycrisp Apple", "Honecrisp Apple", new Guid("209bc539-de7d-4a75-9590-eabb17e2cf8d") },
                    { new Guid("bd411d3d-e53e-4fc3-8f8d-2e62abc499df"), "Dole", "One Yellow Banana", "Banana", new Guid("209bc539-de7d-4a75-9590-eabb17e2cf8d") },
                    { new Guid("2e97f5e2-0de4-454f-b84e-273fa8972dc3"), "Dole", "One Green Plump Cucumber", "Cucumber", new Guid("ba24f865-0af3-4ce1-b123-0f1dcd1e3020") },
                    { new Guid("35b3256c-959c-4e27-9683-9169ab24afda"), "King Arthur", "One Bag of Flour", "Flour", new Guid("52411182-ff92-46ec-9233-a76ffb190339") }
                });
        }
    }
}
