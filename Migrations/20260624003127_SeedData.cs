using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RetrotechEmporium.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "", "Retro Gaming" },
                    { 2, "", "Retro Computers" },
                    { 3, "", "Modern Tech" },
                    { 4, "", "Audio" },
                    { 5, "", "Retro Tech" },
                    { 6, "", "Modern Computers" },
                    { 7, "", "Accessories" },
                    { 8, "", "Modern Gaming" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "categoryId", "productDescription", "productImage", "productName", "productPrice", "quantityInStock", "yearReleased" },
                values: new object[,]
                {
                    { 1, 1, "Classic 8-bit gaming console", "/images/nes.jpg", "Nintendo Entertainment System", 99.99m, 5, 1985 },
                    { 2, 2, "Iconic home computer of the 80s", "/images/c64.jpg", "Commodore 64", 149.99m, 3, 1982 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
