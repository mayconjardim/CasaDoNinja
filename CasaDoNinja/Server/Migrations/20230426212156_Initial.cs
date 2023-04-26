using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CasaDoNinja.Server.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Kit Naruto - Ideal para presente Produtos com acabamento impecável. Acompanha: 2 Kunais, 2 Mini Kunais + Papéis Ninja.", "https://m.media-amazon.com/images/I/41qDrvk-x9S._AC_.jpg", 42.00m, "Kit Kunais Naruto e Boruto" },
                    { 2, "Bandana Naruto Aldeia da Folha - Ideal para presente. - Acabamento Premium. - Material de alta qualidade. - Medidas reais do anime.", "https://m.media-amazon.com/images/I/61Cp0y6w+ML._AC_SL1500_.jpg", 29.90m, "Bandana do Itachi" },
                    { 3, "Fabricado com lâmina de aço 440 polido, sem fio corte.Detalhes em ferro fundido e empunhadeira em tecido e madeira!", "https://m.media-amazon.com/images/I/31rstniHY0S._AC_.jpg", 346.99m, "Espada Ichigo Tensa Zangetsu Samurai" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
