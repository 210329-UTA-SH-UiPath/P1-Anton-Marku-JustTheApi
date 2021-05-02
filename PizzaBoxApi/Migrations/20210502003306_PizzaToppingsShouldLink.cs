using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBoxApi.Migrations
{
    public partial class PizzaToppingsShouldLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PizzaToppings_PizzaId",
                table: "PizzaToppings",
                column: "PizzaId");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaToppings_ToppingId",
                table: "PizzaToppings",
                column: "ToppingId");

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaToppings_Pizzas_PizzaId",
                table: "PizzaToppings",
                column: "PizzaId",
                principalTable: "Pizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaToppings_Toppings_ToppingId",
                table: "PizzaToppings",
                column: "ToppingId",
                principalTable: "Toppings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PizzaToppings_Pizzas_PizzaId",
                table: "PizzaToppings");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaToppings_Toppings_ToppingId",
                table: "PizzaToppings");

            migrationBuilder.DropIndex(
                name: "IX_PizzaToppings_PizzaId",
                table: "PizzaToppings");

            migrationBuilder.DropIndex(
                name: "IX_PizzaToppings_ToppingId",
                table: "PizzaToppings");
        }
    }
}
