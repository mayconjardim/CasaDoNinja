using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CasaDoNinja.Server.Migrations
{
    /// <inheritdoc />
    public partial class Categories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Espadas", "espadas" },
                    { 2, "Kunais", "kunais" },
                    { 3, "Bandanas", "Bandanas" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 2, "Kit Naruto - Ideal para presente Produtos com acabamento impecável. Acompanha: 2 Kunais, 2 Mini Kunais + Papéis Ninja.", "https://m.media-amazon.com/images/I/41qDrvk-x9S._AC_.jpg", 42.00m, "Kit Kunais Naruto e Boruto" },
                    { 2, 3, "Bandana Naruto Aldeia da Folha - Ideal para presente. - Acabamento Premium. - Material de alta qualidade. - Medidas reais do anime.", "https://m.media-amazon.com/images/I/61Cp0y6w+ML._AC_SL1500_.jpg", 29.90m, "Bandana do Itachi" },
                    { 3, 2, "Fabricado com lâmina de aço 440 polido, sem fio corte.Detalhes em ferro fundido e empunhadeira em tecido e madeira!", "https://m.media-amazon.com/images/I/31rstniHY0S._AC_.jpg", 346.99m, "Espada Ichigo Tensa Zangetsu Samurai" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
