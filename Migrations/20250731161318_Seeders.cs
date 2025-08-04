using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class Seeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Electronic devices and gadgets", "Electronics" },
                    { 2, "Various genres of books", "Books" },
                    { 3, "Apparel and accessories", "Clothing" },
                    { 4, "Home appliances and furniture", "Home" },
                    { 5, "Sporting goods and equipment", "Sports" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "LastName", "Password" },
                values: new object[,]
                {
                    { 1, "alice.smith@example.com", "Alice", "Smith", "Password123" },
                    { 2, "bob.johnson@example.com", "Bob", "Johnson", "Password456" },
                    { 3, "charlie.brown@example.com", "Charlie", "Brown", "Password789" },
                    { 4, "david.williams@example.com", "David", "Williams", "Password321" },
                    { 5, "eve.davis@example.com", "Eve", "Davis", "Password654" },
                    { 6, "frank.miller@example.com", "Frank", "Miller", "Password987" },
                    { 7, "grace.wilson@example.com", "Grace", "Wilson", "Password111" },
                    { 8, "hank.moore@example.com", "Hank", "Moore", "Password222" },
                    { 9, "ivy.taylor@example.com", "Ivy", "Taylor", "Password333" },
                    { 10, "jack.anderson@example.com", "Jack", "Anderson", "Password444" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImagePath", "Price", "Quantity", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Latest model smartphone", "images/smartphone.jpg", 499.99m, 10, "Smartphone" },
                    { 2, 1, "High performance laptop", "images/laptop.jpg", 899.99m, 15, "Laptop" },
                    { 3, 1, "Noise cancelling headphones", "images/headphones.jpg", 59.99m, 30, "Headphones" },
                    { 4, 2, "Bestselling novel", "images/novel.jpg", 19.99m, 50, "Novel" },
                    { 5, 2, "Delicious recipes", "images/cookbook.jpg", 29.99m, 20, "Cookbook" },
                    { 6, 2, "Educational textbook", "images/textbook.jpg", 79.99m, 25, "Textbook" },
                    { 7, 3, "Cotton t-shirt", "images/tshirt.jpg", 25.00m, 100, "T-Shirt" },
                    { 8, 3, "Denim jeans", "images/jeans.jpg", 49.99m, 60, "Jeans" },
                    { 9, 3, "Winter jacket", "images/jacket.jpg", 89.99m, 40, "Jacket" },
                    { 10, 4, "Comfortable sofa", "images/sofa.jpg", 399.99m, 5, "Sofa" },
                    { 11, 4, "Desk lamp", "images/lamp.jpg", 39.99m, 20, "Lamp" },
                    { 12, 4, "Kitchen blender", "images/blender.jpg", 59.99m, 15, "Blender" },
                    { 13, 5, "Official size football", "images/football.jpg", 29.99m, 35, "Football" },
                    { 14, 5, "Professional tennis racket", "images/racket.jpg", 79.99m, 10, "Tennis Racket" },
                    { 15, 5, "Non-slip yoga mat", "images/yogamat.jpg", 24.99m, 50, "Yoga Mat" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);
        }
    }
}
