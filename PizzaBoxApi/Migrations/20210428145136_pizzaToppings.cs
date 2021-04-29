using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBoxApi.Migrations
{
    public partial class pizzaToppings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Topping1Id",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "Topping2Id",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "Topping3Id",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "Topping4Id",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "Topping5Id",
                table: "Pizzas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Topping1Id",
                table: "Pizzas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Topping2Id",
                table: "Pizzas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Topping3Id",
                table: "Pizzas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Topping4Id",
                table: "Pizzas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Topping5Id",
                table: "Pizzas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
