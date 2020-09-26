using Microsoft.EntityFrameworkCore.Migrations;

namespace SEDC.WebApp.ModelDemo.DataAccess.Migrations
{
    public partial class PopulatedPizzasTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "Id", "Image", "Name", "Price", "Size" },
                values: new object[,]
                {
                    { 1, "Kapri.png", "Kapri", 7.0, 2 },
                    { 2, "Kapri.png", "Kapri", 7.0, 3 },
                    { 3, "Kapri.png", "Kapri", 7.0, 4 },
                    { 4, "Peperoni.png", "Peperoni", 9.0, 2 },
                    { 5, "Peperoni.png", "Peperoni", 8.0, 3 },
                    { 6, "Peperoni.png", "Peperoni", 8.0, 4 },
                    { 7, "Margarita.png", "Margarita", 10.5, 2 },
                    { 8, "Margarita.png", "Margarita", 10.5, 4 },
                    { 9, "Margarita.png", "Margarita", 10.5, 4 },
                    { 10, "Siciliana.png", "Siciliana", 6.5, 2 },
                    { 11, "Siciliana.png", "Siciliana", 9.5, 3 },
                    { 12, "Siciliana.png", "Siciliana", 9.5, 4 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Phone" },
                values: new object[] { 1, "Bob Street", "Bob", "Bobsky", 80012312345L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
