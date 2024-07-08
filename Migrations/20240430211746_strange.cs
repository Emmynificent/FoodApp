using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodApp.Migrations
{
    /// <inheritdoc />
    public partial class strange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PizzaName",
                table: "order");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PizzaName",
                table: "order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
