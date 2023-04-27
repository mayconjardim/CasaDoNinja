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
                          CategoryId = 2
                   }
                );
        }

    }
}
