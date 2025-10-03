using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P2_SistemaDeGestion.Migrations.Producto
{
    /// <inheritdoc />
    public partial class _03102025Productos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
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
                table: "Producto",
                columns: new[] { "Id", "Descripcion", "Existencia", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, "Portátil 15''", 10, "Laptop", 12000m },
                    { 2, "Mouse óptico", 50, "Mouse", 250m },
                    { 3, "Teclado mecánico", 30, "Teclado", 800m },
                    { 4, "Monitor 24''", 15, "Monitor", 3500m },
                    { 5, "Impresora láser", 8, "Impresora", 2200m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producto");
        }
    }
}
