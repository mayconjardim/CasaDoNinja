using Microsoft.AspNetCore.Mvc;

namespace CasaDoNinja.Server.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private static List<Product> Products = new List<Product>
        {

            new Product
            {
                Id = 1,
                Title = "Kit Kunais Naruto e Boruto",
                Description = "Kit Naruto - Ideal para presente Produtos" +
                " com acabamento impecável. Acompanha: 2 Kunais, 2 Mini Kunais + Papéis Ninja.",
                ImageUrl = "https://m.media-amazon.com/images/I/41qDrvk-x9S._AC_.jpg",
                Price = 42.00m
            },
               new Product
            {
                Id = 2,
                Title = "Bandana do Itachi",
                Description = "Bandana Naruto Aldeia da Folha - Ideal para presente. - Acabamento Premium. - Material de alta qualidade. " +
                   "- Medidas reais do anime.",
                ImageUrl = "https://m.media-amazon.com/images/I/61Cp0y6w+ML._AC_SL1500_.jpg",
                Price = 29.90m
            },
                  new Product
            {
                Id = 3,
                Title = "Espada Ichigo Tensa Zangetsu Samurai",
                Description = "Fabricado com lâmina de aço 440 polido, sem fio corte." +
                      "Detalhes em ferro fundido e empunhadeira em tecido e madeira!",
                ImageUrl = "https://m.media-amazon.com/images/I/31rstniHY0S._AC_.jpg",
                Price = 346.99m
            }

        };

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return Ok(Products);
        }

    }
}
