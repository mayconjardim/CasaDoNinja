﻿// <auto-generated />
using CasaDoNinja.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CasaDoNinja.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CasaDoNinja.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Espadas",
                            Url = "espadas"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kunais",
                            Url = "kunais"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Bandanas",
                            Url = "Bandanas"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Acessórios",
                            Url = "acessorios "
                        });
                });

            modelBuilder.Entity("CasaDoNinja.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            Description = "Kit Naruto - Ideal para presente Produtos com acabamento impecável. Acompanha: 2 Kunais, 2 Mini Kunais + Papéis Ninja.",
                            ImageUrl = "https://m.media-amazon.com/images/I/41qDrvk-x9S._AC_.jpg",
                            Price = 42.00m,
                            Title = "Kit Kunais Naruto e Boruto"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            Description = "Bandana Naruto Aldeia da Folha - Ideal para presente. - Acabamento Premium. - Material de alta qualidade. - Medidas reais do anime.",
                            ImageUrl = "https://m.media-amazon.com/images/I/61Cp0y6w+ML._AC_SL1500_.jpg",
                            Price = 29.90m,
                            Title = "Bandana do Itachi"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Fabricado com lâmina de aço 440 polido, sem fio corte.Detalhes em ferro fundido e empunhadeira em tecido e madeira!",
                            ImageUrl = "https://m.media-amazon.com/images/I/31rstniHY0S._AC_.jpg",
                            Price = 346.99m,
                            Title = "Espada Ichigo Tensa Zangetsu Samurai"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "A lâmina da espada matadora de demônios de madeira é feita de madeira de bambu, ambientalmente segura e resistente",
                            ImageUrl = "https://m.media-amazon.com/images/I/41MH+y74JCL._AC_.jpg",
                            Price = 29.99m,
                            Title = "Espada Demon Slayer Katana"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            Description = "Bandana de metal maleável Comprimento Total 96 cm Tecido ajustável de poliéster e algodão Tamanho da Placa 10 cm x 4 cm",
                            ImageUrl = "https://m.media-amazon.com/images/I/31rstniHY0S._AC_.jpg",
                            Price = 346.99m,
                            Title = "Bandana Aldeia da Areia (Ninja Renegado)"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 4,
                            Description = "Material do pingente: polimetilmetacrilato. Tamanho do pingente: 6,8 cm x 2,4 cm. Estes brincos de Hanafuda do caçador de demônios",
                            ImageUrl = "https://m.media-amazon.com/images/I/31x9ejbKLOS._AC_.jpg",
                            Price = 346.99m,
                            Title = "Brincos Tanjiro Hanafuda HappyShip"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 4,
                            Description = " Brincos de acrílico Brincos para mulheres e Homens",
                            ImageUrl = "https://m.media-amazon.com/images/I/51fz2BdE4TL._AC_SL1500_.jpg",
                            Price = 346.99m,
                            Title = "Brincos Tokyo Revengers"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Description = "As Kunais são feitas em plástico emborrachado de alta qualidade, com pontas maleáveis e flexíveis.",
                            ImageUrl = "https://m.media-amazon.com/images/I/31ZNd5yHKrS._AC_.jpg",
                            Price = 46.99m,
                            Title = "Kit Kunais  - Kunai Minato + Kunai Ponta Dupla"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            Description = "Skyward Blade é uma espada de 5 estrelas na série Genshin Impact Mondstadt",
                            ImageUrl = "https://m.media-amazon.com/images/I/51p4L0DdNHL._AC_SL1500_.jpg",
                            Price = 540.99m,
                            Title = "Espada Hengqiyuan Genshin Impact Foam"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Description = "O kunai de plástico tem cerca de 25 cm de comprimento e é feito de plástico ABS, que é durável para usar",
                            ImageUrl = "https://m.media-amazon.com/images/I/51Stsw0MneL._AC_SL1080_.jpg",
                            Price = 6.99m,
                            Title = "Kunai Japonês Big Kunai"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 1,
                            Description = "Aparência, lâmina de madeira e cabo são todos feitos de acordo com a animação original, com alta precisão e detalhes",
                            ImageUrl = "https://m.media-amazon.com/images/I/61ScbA0VN0L._AC_SL1500_.jpg",
                            Price = 460.00m,
                            Title = "Espada Demon Slayer Katana com Bainha de Couro "
                        });
                });

            modelBuilder.Entity("CasaDoNinja.Shared.Product", b =>
                {
                    b.HasOne("CasaDoNinja.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
