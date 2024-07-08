using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodApp.Migrations
{
    /// <inheritdoc />
    public partial class check : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_pizza_PizzaId",
                table: "order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pizza",
                table: "pizza");

            migrationBuilder.DropPrimaryKey(
                name: "PK_order",
                table: "order");

            migrationBuilder.RenameTable(
                name: "pizza",
                newName: "Pizza");

            migrationBuilder.RenameTable(
                name: "order",
                newName: "Order");

            migrationBuilder.RenameIndex(
                name: "IX_order_PizzaId",
                table: "Order",
                newName: "IX_Order_PizzaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pizza",
                table: "Pizza",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Pizza_PizzaId",
                table: "Order",
                column: "PizzaId",
                principalTable: "Pizza",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Pizza_PizzaId",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pizza",
                table: "Pizza");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.RenameTable(
                name: "Pizza",
                newName: "pizza");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "order");

            migrationBuilder.RenameIndex(
                name: "IX_Order_PizzaId",
                table: "order",
                newName: "IX_order_PizzaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pizza",
                table: "pizza",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_order",
                table: "order",
                column: "Id");

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
