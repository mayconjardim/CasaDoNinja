namespace CasaDoNinja.Server.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CartItem>()
             .HasKey(ci => new { ci.UserId, ci.ProductId, ci.ProductTypeId });

            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.ProductTypeId });


            modelBuilder.Entity<ProductType>().HasData(
                    new ProductType { Id = 1, Name = "Default" },
                    new ProductType { Id = 2, Name = "Metal" },
                    new ProductType { Id = 3, Name = "Ferro" },
                    new ProductType { Id = 4, Name = "Ouro" },
                    new ProductType { Id = 5, Name = "Plastico" },
                    new ProductType { Id = 6, Name = "Magico" },
                    new ProductType { Id = 7, Name = "Demoniaco" },
                    new ProductType { Id = 8, Name = "Vampirico" },
                    new ProductType { Id = 9, Name = "Bambu" },
                    new ProductType { Id = 10, Name = "3D" }
                );

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
                    Url = "bandanas"
                },
                  new Category
                  {
                      Id = 4,
                      Name = "Acessórios",
                      Url = "acessorios"
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
                      Featured = true,
                      CategoryId = 2
                  },
                 new Product
                 {
                     Id = 2,
                     Title = "Bandana do Itachi",
                     Description = "Bandana Naruto Aldeia da Folha - Ideal para presente. - Acabamento Premium. - Material de alta qualidade. " +
                     "- Medidas reais do anime.",
                     ImageUrl = "https://m.media-amazon.com/images/I/61Cp0y6w+ML._AC_SL1500_.jpg",
                     Featured = true,
                     CategoryId = 3
                 },
                 new Product
                 {
                     Id = 3,
                     Title = "Espada Ichigo Tensa Zangetsu Samurai",
                     Description = "Fabricado com lâmina de aço 440 polido, sem fio corte." +
                        "Detalhes em ferro fundido e empunhadeira em tecido e madeira!",
                     ImageUrl = "https://m.media-amazon.com/images/I/31rstniHY0S._AC_.jpg",
                     Featured = true,
                     CategoryId = 1
                 },




                   new Product
                   {
                       Id = 4,
                       Title = "Espada Demon Slayer Katana",
                       Description = "A lâmina da espada matadora de demônios de madeira é feita de madeira de bambu, " +
                       "ambientalmente segura e resistente",
                       ImageUrl = "https://m.media-amazon.com/images/I/41E68ZGUdcL._AC_SX569_.jpg",
                       CategoryId = 1
                   },



                new Product
                {
                    Id = 5,
                    Title = "Bandana Aldeia da Areia (Ninja Renegado)",
                    Description = "Bandana de metal maleável Comprimento Total 96 cm Tecido ajustável de poliéster e algodão " +
                    "Tamanho da Placa 10 cm x 4 cm",
                    ImageUrl = "https://m.media-amazon.com/images/I/41MH+y74JCL._AC_.jpg",
                    CategoryId = 3
                },
                new Product
                {
                    Id = 6,
                    Title = "Brincos Tanjiro Hanafuda HappyShip",
                    Description = "Material do pingente: polimetilmetacrilato. Tamanho do pingente: 6,8 cm x 2,4 cm. Estes brincos de Hanafuda do caçador " +
                    "de demônios",
                    ImageUrl = "https://m.media-amazon.com/images/I/31x9ejbKLOS._AC_.jpg",
                    CategoryId = 4
                },
                new Product
                {
                    Id = 7,
                    Title = "Brincos Tokyo Revengers",
                    Description = " Brincos de acrílico Brincos para mulheres e Homens",
                    ImageUrl = "https://m.media-amazon.com/images/I/51fz2BdE4TL._AC_SL1500_.jpg",
                    CategoryId = 4
                },

                new Product
                {
                    Id = 8,
                    Title = "Kit Kunais  - Kunai Minato + Kunai Ponta Dupla",
                    Description = "As Kunais são feitas em plástico emborrachado de alta qualidade, com pontas maleáveis e flexíveis.",
                    ImageUrl = "https://m.media-amazon.com/images/I/31ZNd5yHKrS._AC_.jpg",
                    CategoryId = 2
                },

                new Product
                {
                    Id = 9,
                    Title = "Espada Hengqiyuan Genshin Impact Foam",
                    Description = "Skyward Blade é uma espada de 5 estrelas na série Genshin Impact Mondstadt",
                    ImageUrl = "https://m.media-amazon.com/images/I/51p4L0DdNHL._AC_SL1500_.jpg",
                    CategoryId = 1
                },
                  new Product
                  {
                      Id = 10,
                      Title = "Kunai Japonês Big Kunai",
                      Description = "O kunai de plástico tem cerca de 25 cm de comprimento e é feito de plástico ABS, que é durável para usar",
                      ImageUrl = "https://m.media-amazon.com/images/I/51Stsw0MneL._AC_SL1080_.jpg",
                      CategoryId = 2
                  },
                    new Product
                    {
                        Id = 11,
                        Title = "Espada Demon Slayer Katana com Bainha de Couro ",
                        Description = "Aparência, lâmina de madeira e cabo são todos feitos de acordo com a animação original, com alta precisão e detalhes",
                        ImageUrl = "https://m.media-amazon.com/images/I/61ScbA0VN0L._AC_SL1500_.jpg",
                        CategoryId = 1
                    }
              );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 2,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 3,
                    Price = 7.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 4,
                    Price = 19.99m,
                    OriginalPrice = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 2,
                    Price = 7.99m,
                    OriginalPrice = 14.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 2,
                    Price = 6.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 5,
                    Price = 3.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 6,
                    Price = 9.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 7,
                    Price = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 5,
                    Price = 3.99m,
                },
                new ProductVariant
                {
                    ProductId = 6,
                    ProductTypeId = 5,
                    Price = 2.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 8,
                    Price = 19.99m,
                    OriginalPrice = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 9,
                    Price = 69.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 10,
                    Price = 49.99m,
                    OriginalPrice = 59.99m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    ProductTypeId = 8,
                    Price = 9.99m,
                    OriginalPrice = 24.99m,
                },
                new ProductVariant
                {
                    ProductId = 9,
                    ProductTypeId = 8,
                    Price = 14.99m
                },
                new ProductVariant
                {
                    ProductId = 10,
                    ProductTypeId = 1,
                    Price = 159.99m,
                    OriginalPrice = 299m
                },
                new ProductVariant
                {
                    ProductId = 11,
                    ProductTypeId = 1,
                    Price = 79.99m,
                    OriginalPrice = 399m
                }
            );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CartItem> CartItems { get; set; }


    }
}

