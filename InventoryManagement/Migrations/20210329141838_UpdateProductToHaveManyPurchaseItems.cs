using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagement.Api.Migrations
{
    public partial class UpdateProductToHaveManyPurchaseItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PurchaseItems_ProductId",
                table: "PurchaseItems");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08fac562-0829-49d2-a654-914f556e4acf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("122c4fd7-6369-46a0-afbf-8fb6ad54eb28"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("334996a9-3db1-43c0-9744-1df1bba32db2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7bb11bf6-3cbc-4485-a51d-316e3e5218ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a5a9f774-765c-4eea-a868-6f5fc0852433"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aac2f687-7089-43ee-9db9-96bbe1bf68f0"));

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

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseItems_ProductId",
                table: "PurchaseItems",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PurchaseItems_ProductId",
                table: "PurchaseItems");

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
                    { new Guid("334996a9-3db1-43c0-9744-1df1bba32db2"), "Kroger", "One Gallon of Milk", "Milk", new Guid("7e42a3b7-f02f-442d-97ef-2b13bb423414") },
                    { new Guid("122c4fd7-6369-46a0-afbf-8fb6ad54eb28"), "Kroger", "One Carton of a Dozen Eggs", "Eggs", new Guid("5a077aa8-c217-4209-a70c-dd92c2d10b09") },
                    { new Guid("7bb11bf6-3cbc-4485-a51d-316e3e5218ea"), "Dole", "One Honeycrisp Apple", "Honecrisp Apple", new Guid("209bc539-de7d-4a75-9590-eabb17e2cf8d") },
                    { new Guid("aac2f687-7089-43ee-9db9-96bbe1bf68f0"), "Dole", "One Yellow Banana", "Banana", new Guid("209bc539-de7d-4a75-9590-eabb17e2cf8d") },
                    { new Guid("a5a9f774-765c-4eea-a868-6f5fc0852433"), "Dole", "One Green Plump Cucumber", "Cucumber", new Guid("ba24f865-0af3-4ce1-b123-0f1dcd1e3020") },
                    { new Guid("08fac562-0829-49d2-a654-914f556e4acf"), "King Arthur", "One Bag of Flour", "Flour", new Guid("52411182-ff92-46ec-9233-a76ffb190339") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseItems_ProductId",
                table: "PurchaseItems",
                column: "ProductId",
                unique: true);
        }
    }
}
