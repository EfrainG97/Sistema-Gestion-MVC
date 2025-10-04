using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P2_SistemaDeGestion.Migrations
{
    /// <inheritdoc />
    public partial class MigracionBD1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    ApellidoPaterno = table.Column<string>(type: "TEXT", nullable: true),
                    ApellidoMaterno = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdMarca = table.Column<int>(type: "INTEGER", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Precio = table.Column<decimal>(type: "TEXT", nullable: false),
                    Existencia = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "ApellidoMaterno", "ApellidoPaterno", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Gómez", "Pérez", "Juan", "555-1234" },
                    { 2, "Martínez", "López", "Ana", "555-5678" },
                    { 3, "Santos", "Ramírez", "Luis", "555-8765" },
                    { 4, "Vega", "Torres", "María", "555-4321" },
                    { 5, "Ruiz", "Hernández", "Carlos", "555-2468" }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { 1, "HP" },
                    { 2, "Lenovo" },
                    { 3, "Logitech" },
                    { 4, "DELL" },
                    { 5, "Nike" }
                });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "Id", "Descripcion", "Existencia", "IdMarca", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, "Portátil 15''", 10, 1, "Laptop", 12000m },
                    { 2, "Mouse óptico", 50, 2, "Mouse", 250m },
                    { 3, "Teclado mecánico", 30, 3, "Teclado", 800m },
                    { 4, "Monitor 24''", 15, 4, "Monitor", 3500m },
                    { 5, "Impresora láser", 8, 4, "Impresora", 2200m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.DropTable(
                name: "Producto");
        }
    }
}
