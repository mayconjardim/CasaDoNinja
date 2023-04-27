using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CasaDoNinja.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductsAndCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 4, "Acessórios", "acessorios " });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 1, "A lâmina da espada matadora de demônios de madeira é feita de madeira de bambu, ambientalmente segura e resistente", "https://m.media-amazon.com/images/I/41MH+y74JCL._AC_.jpg", 29.99m, "Espada Demon Slayer Katana" },
                    { 5, 3, "Bandana de metal maleável Comprimento Total 96 cm Tecido ajustável de poliéster e algodão Tamanho da Placa 10 cm x 4 cm", "https://m.media-amazon.com/images/I/31rstniHY0S._AC_.jpg", 346.99m, "Bandana Aldeia da Areia (Ninja Renegado)" },
                    { 8, 2, "As Kunais são feitas em plástico emborrachado de alta qualidade, com pontas maleáveis e flexíveis.", "https://m.media-amazon.com/images/I/31ZNd5yHKrS._AC_.jpg", 46.99m, "Kit Kunais  - Kunai Minato + Kunai Ponta Dupla" },
                    { 9, 1, "Skyward Blade é uma espada de 5 estrelas na série Genshin Impact Mondstadt", "https://m.media-amazon.com/images/I/51p4L0DdNHL._AC_SL1500_.jpg", 540.99m, "Espada Hengqiyuan Genshin Impact Foam" },
                    { 10, 2, "O kunai de plástico tem cerca de 25 cm de comprimento e é feito de plástico ABS, que é durável para usar", "https://m.media-amazon.com/images/I/51Stsw0MneL._AC_SL1080_.jpg", 6.99m, "Kunai Japonês Big Kunai" },
                    { 11, 1, "Aparência, lâmina de madeira e cabo são todos feitos de acordo com a animação original, com alta precisão e detalhes", "https://m.media-amazon.com/images/I/61ScbA0VN0L._AC_SL1500_.jpg", 460.00m, "Espada Demon Slayer Katana com Bainha de Couro " },
                    { 6, 4, "Material do pingente: polimetilmetacrilato. Tamanho do pingente: 6,8 cm x 2,4 cm. Estes brincos de Hanafuda do caçador de demônios", "https://m.media-amazon.com/images/I/31x9ejbKLOS._AC_.jpg", 346.99m, "Brincos Tanjiro Hanafuda HappyShip" },
                    { 7, 4, " Brincos de acrílico Brincos para mulheres e Homens", "https://m.media-amazon.com/images/I/51fz2BdE4TL._AC_SL1500_.jpg", 346.99m, "Brincos Tokyo Revengers" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 2);
        }
    }
}
