using Microsoft.EntityFrameworkCore.Migrations;

namespace Mango.Services.ProductApi.Migrations
{
    public partial class SeedPic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Categoryname", "Description", "Name", "Price", "imageurl" },
                values: new object[,]
                {
                    { 1, "Appetizer", "Praesent scelerisque, mi sed ultrices condimentum", "Samosa", 15.0, "https://dotnetmistry75.blob.core.windows.net/mango/download%20(4).jpg" },
                    { 2, "Appetizer", "Praesent scelerisque, mi sed ultrices condimentum", "Paneer Tikka", 13.99, "https://dotnetmistry75.blob.core.windows.net/mango/download (5).jpg" },
                    { 3, "Appetizer", "Praesent scelerisque, mi sed ultrices condimentum", "Sweet Pie", 11.0, "https://dotnetmistry75.blob.core.windows.net/mango/download (6).jpg" },
                    { 4, "Appetizer", "Praesent scelerisque, mi sed ultrices condimentum", "Pav Bhaji", 15.0, "https://dotnetmistry75.blob.core.windows.net/mango/images (1).jpg" }
                });
        }

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
        }
    }
}
