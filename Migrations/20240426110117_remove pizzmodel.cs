using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodApp.Migrations
{
    /// <inheritdoc />
    public partial class removepizzmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_pizza_PizzaId",
                table: "order");

            migrationBuilder.DropIndex(
                name: "IX_order_PizzaId",
                table: "order");

            migrationBuilder.DropColumn(
                name: "PizzaId",
                table: "order");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PizzaId",
                table: "order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_order_PizzaId",
                table: "order",
                column: "PizzaId");

            migrationBuilder.AddForeignKey(
                name: "FK_order_pizza_PizzaId",
                table: "order",
                column: "PizzaId",
                principalTable: "pizza",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
