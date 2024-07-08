using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodApp.Migrations
{
    /// <inheritdoc />
    public partial class pizziniia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_pizza_PizzaIdId",
                table: "order");

            migrationBuilder.RenameColumn(
                name: "PizzaIdId",
                table: "order",
                newName: "PizzaId");

            migrationBuilder.RenameIndex(
                name: "IX_order_PizzaIdId",
                table: "order",
                newName: "IX_order_PizzaId");

            migrationBuilder.AddForeignKey(
                name: "FK_order_pizza_PizzaId",
                table: "order",
                column: "PizzaId",
                principalTable: "pizza",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_pizza_PizzaId",
                table: "order");

            migrationBuilder.RenameColumn(
                name: "PizzaId",
                table: "order",
                newName: "PizzaIdId");

            migrationBuilder.RenameIndex(
                name: "IX_order_PizzaId",
                table: "order",
                newName: "IX_order_PizzaIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_order_pizza_PizzaIdId",
                table: "order",
                column: "PizzaIdId",
                principalTable: "pizza",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
