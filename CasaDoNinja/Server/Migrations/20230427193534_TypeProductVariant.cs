using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CasaDoNinja.Server.Migrations
{
    /// <inheritdoc />
    public partial class TypeProductVariant : Migration
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
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => new { x.ProductId, x.ProductTypeId });
                    table.ForeignKey(
                        name: "FK_ProductVariants_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
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
                    { 3, "Bandanas", "bandanas" },
                    { 4, "Acessórios", "acessorios" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Default" },
                    { 2, "Metal" },
                    { 3, "Ferro" },
                    { 4, "Ouro" },
                    { 5, "Plastico" },
                    { 6, "Magico" },
                    { 7, "Demoniaco" },
                    { 8, "Vampirico" },
                    { 9, "Bambu" },
                    { 10, "3D" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 1, 2, "Kit Naruto - Ideal para presente Produtos com acabamento impecável. Acompanha: 2 Kunais, 2 Mini Kunais + Papéis Ninja.", "https://m.media-amazon.com/images/I/41qDrvk-x9S._AC_.jpg", "Kit Kunais Naruto e Boruto" },
                    { 2, 3, "Bandana Naruto Aldeia da Folha - Ideal para presente. - Acabamento Premium. - Material de alta qualidade. - Medidas reais do anime.", "https://m.media-amazon.com/images/I/61Cp0y6w+ML._AC_SL1500_.jpg", "Bandana do Itachi" },
                    { 3, 1, "Fabricado com lâmina de aço 440 polido, sem fio corte.Detalhes em ferro fundido e empunhadeira em tecido e madeira!", "https://m.media-amazon.com/images/I/31rstniHY0S._AC_.jpg", "Espada Ichigo Tensa Zangetsu Samurai" },
                    { 4, 1, "A lâmina da espada matadora de demônios de madeira é feita de madeira de bambu, ambientalmente segura e resistente", "https://m.media-amazon.com/images/I/41MH+y74JCL._AC_.jpg", "Espada Demon Slayer Katana" },
                    { 5, 3, "Bandana de metal maleável Comprimento Total 96 cm Tecido ajustável de poliéster e algodão Tamanho da Placa 10 cm x 4 cm", "https://m.media-amazon.com/images/I/31rstniHY0S._AC_.jpg", "Bandana Aldeia da Areia (Ninja Renegado)" },
                    { 6, 4, "Material do pingente: polimetilmetacrilato. Tamanho do pingente: 6,8 cm x 2,4 cm. Estes brincos de Hanafuda do caçador de demônios", "https://m.media-amazon.com/images/I/31x9ejbKLOS._AC_.jpg", "Brincos Tanjiro Hanafuda HappyShip" },
                    { 7, 4, " Brincos de acrílico Brincos para mulheres e Homens", "https://m.media-amazon.com/images/I/51fz2BdE4TL._AC_SL1500_.jpg", "Brincos Tokyo Revengers" },
                    { 8, 2, "As Kunais são feitas em plástico emborrachado de alta qualidade, com pontas maleáveis e flexíveis.", "https://m.media-amazon.com/images/I/31ZNd5yHKrS._AC_.jpg", "Kit Kunais  - Kunai Minato + Kunai Ponta Dupla" },
                    { 9, 1, "Skyward Blade é uma espada de 5 estrelas na série Genshin Impact Mondstadt", "https://m.media-amazon.com/images/I/51p4L0DdNHL._AC_SL1500_.jpg", "Espada Hengqiyuan Genshin Impact Foam" },
                    { 10, 2, "O kunai de plástico tem cerca de 25 cm de comprimento e é feito de plástico ABS, que é durável para usar", "https://m.media-amazon.com/images/I/51Stsw0MneL._AC_SL1080_.jpg", "Kunai Japonês Big Kunai" },
                    { 11, 1, "Aparência, lâmina de madeira e cabo são todos feitos de acordo com a animação original, com alta precisão e detalhes", "https://m.media-amazon.com/images/I/61ScbA0VN0L._AC_SL1500_.jpg", "Espada Demon Slayer Katana com Bainha de Couro " }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 1, 2, 19.99m, 9.99m },
                    { 1, 3, 0m, 7.99m },
                    { 1, 4, 29.99m, 19.99m },
                    { 2, 2, 14.99m, 7.99m },
                    { 3, 2, 0m, 6.99m },
                    { 4, 5, 0m, 3.99m },
                    { 4, 6, 0m, 9.99m },
                    { 4, 7, 0m, 19.99m },
                    { 5, 5, 0m, 3.99m },
                    { 6, 5, 0m, 2.99m },
                    { 7, 8, 29.99m, 19.99m },
                    { 7, 9, 0m, 69.99m },
                    { 7, 10, 59.99m, 49.99m },
                    { 8, 8, 24.99m, 9.99m },
                    { 9, 8, 0m, 14.99m },
                    { 10, 1, 299m, 159.99m },
                    { 11, 1, 399m, 79.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ProductTypeId",
                table: "ProductVariants",
                column: "ProductTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
