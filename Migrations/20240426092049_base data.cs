using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodApp.Migrations
{
    /// <inheritdoc />
    public partial class basedata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "pizza",
                columns: new[] { "Id", "BasePrice", "Description", "Name", "Size" },
                values: new object[,]
                {
                    { -4, 6f, "This is a beeffed up Pizza made with love", "BeefedUp", 1 },
                    { -3, 8f, "This is made with dear love", "Deariazza", 2 },
                    { -2, 8f, "This is from Hawaii", "Hawaiin", 2 },
                    { -1, 8f, "Pizza for the peppered swaggs", "Pepperoni", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "pizza",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "pizza",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "pizza",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "pizza",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
