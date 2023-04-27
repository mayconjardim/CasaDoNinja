namespace CasaDoNinja.Server.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options){ }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)
            .WithMany()
            .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Espadas",
                    Url = "espadas"
                },
                new Category
                  {
                      Id = 2,
                      Name = "Kunais",
                      Url = "kunais"
                },
                new Category
                {
                        Id = 3,
                        Name = "Bandanas",
                        Url = "Bandanas"
                },
                 new Category
                 {
                     Id = 4,
                     Name = "Acessórios",
                     Url = "acessorios "
                 }
                );


            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "Kit Kunais Naruto e Boruto",
                        Description = "Kit Naruto - Ideal para presente Produtos" +
                    " com acabamento impecável. Acompanha: 2 Kunais, 2 Mini Kunais + Papéis Ninja.",
                        ImageUrl = "https://m.media-amazon.com/images/I/41qDrvk-x9S._AC_.jpg",
                        Price = 42.00m,
                        CategoryId = 2
                    },
                   new Product
                   {
                       Id = 2,
                       Title = "Bandana do Itachi",
                       Description = "Bandana Naruto Aldeia da Folha - Ideal para presente. - Acabamento Premium. - Material de alta qualidade. " +
                       "- Medidas reais do anime.",
                       ImageUrl = "https://m.media-amazon.com/images/I/61Cp0y6w+ML._AC_SL1500_.jpg",
                       Price = 29.90m,
                       CategoryId = 3
                   },
                   new Product
                   {
                          Id = 3,
                          Title = "Espada Ichigo Tensa Zangetsu Samurai",
                          Description = "Fabricado com lâmina de aço 440 polido, sem fio corte." +
                          "Detalhes em ferro fundido e empunhadeira em tecido e madeira!",
                          ImageUrl = "https://m.media-amazon.com/images/I/31rstniHY0S._AC_.jpg",
                          Price = 346.99m,
                          CategoryId = 1
                   },




                     new Product
                     {
                         Id = 4,
                         Title = "Espada Demon Slayer Katana",
                         Description = "A lâmina da espada matadora de demônios de madeira é feita de madeira de bambu, " +
                         "ambientalmente segura e resistente",
                         ImageUrl = "https://m.media-amazon.com/images/I/41MH+y74JCL._AC_.jpg",
                         Price = 29.99m,
                         CategoryId = 1
                     },



                  new Product
                  {
                      Id = 5,
                      Title = "Bandana Aldeia da Areia (Ninja Renegado)",
                      Description = "Bandana de metal maleável Comprimento Total 96 cm Tecido ajustável de poliéster e algodão " +
                      "Tamanho da Placa 10 cm x 4 cm",
                      ImageUrl = "https://m.media-amazon.com/images/I/31rstniHY0S._AC_.jpg",
                      Price = 346.99m,
                      CategoryId = 3
                  },
                  new Product
                  {
                      Id = 6,
                      Title = "Brincos Tanjiro Hanafuda HappyShip",
                      Description = "Material do pingente: polimetilmetacrilato. Tamanho do pingente: 6,8 cm x 2,4 cm. Estes brincos de Hanafuda do caçador " +
                      "de demônios",
                      ImageUrl = "https://m.media-amazon.com/images/I/31x9ejbKLOS._AC_.jpg",
                      Price = 346.99m,
                      CategoryId = 4
                  },
                  new Product
                  {
                      Id = 7,
                      Title = "Brincos Tokyo Revengers",
                      Description = " Brincos de acrílico Brincos para mulheres e Homens",
                      ImageUrl = "https://m.media-amazon.com/images/I/51fz2BdE4TL._AC_SL1500_.jpg",
                      Price = 346.99m,
                      CategoryId = 4
                  },

                  new Product
                    {
                        Id = 8,
                        Title = "Kit Kunais  - Kunai Minato + Kunai Ponta Dupla",
                        Description = "As Kunais são feitas em plástico emborrachado de alta qualidade, com pontas maleáveis e flexíveis.",
                        ImageUrl = "https://m.media-amazon.com/images/I/31ZNd5yHKrS._AC_.jpg",
                        Price = 46.99m,
                        CategoryId = 2
                    },

                  new Product
                  {
                      Id = 9,
                      Title = "Espada Hengqiyuan Genshin Impact Foam",
                      Description = "Skyward Blade é uma espada de 5 estrelas na série Genshin Impact Mondstadt",
                      ImageUrl = "https://m.media-amazon.com/images/I/51p4L0DdNHL._AC_SL1500_.jpg",
                      Price = 540.99m,
                      CategoryId = 1
                  },
                    new Product
                    {
                        Id = 10,
                        Title = "Kunai Japonês Big Kunai",
                        Description = "O kunai de plástico tem cerca de 25 cm de comprimento e é feito de plástico ABS, que é durável para usar",
                        ImageUrl = "https://m.media-amazon.com/images/I/51Stsw0MneL._AC_SL1080_.jpg",
                        Price = 6.99m,
                        CategoryId = 2
                    },
                      new Product
                      {
                          Id = 11,
                          Title = "Espada Demon Slayer Katana com Bainha de Couro ",
                          Description = "Aparência, lâmina de madeira e cabo são todos feitos de acordo com a animação original, com alta precisão e detalhes",
                          ImageUrl = "https://m.media-amazon.com/images/I/61ScbA0VN0L._AC_SL1500_.jpg",
                          Price = 460.00m,
                          CategoryId = 1
                      }
                );
        }

    }
}
