using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P2_SistemaDeGestion.Migrations
{
    /// <inheritdoc />
    public partial class _03102025Clientes : Migration
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
