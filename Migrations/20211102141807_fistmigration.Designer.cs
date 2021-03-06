// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebScrapper;

namespace WebScrapper.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211102141807_fistmigration")]
    partial class fistmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("e_commerce.Models.Camisa", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("linkImagem")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("preco")
                        .HasColumnType("TEXT");

                    b.Property<int>("quantidade")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Camisas");
                });

            modelBuilder.Entity("e_commerce.Models.Celular", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("linkImagem")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("preco")
                        .HasColumnType("TEXT");

                    b.Property<int>("quantidade")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Celulares");
                });

            modelBuilder.Entity("e_commerce.Models.Item_Cozinha", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("linkImagem")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("preco")
                        .HasColumnType("TEXT");

                    b.Property<int>("quantidade")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Itens_Cozinha");
                });

            modelBuilder.Entity("e_commerce.Models.Livro", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("linkImagem")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("preco")
                        .HasColumnType("TEXT");

                    b.Property<int>("quantidade")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("e_commerce.Models.Notebook", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("linkImagem")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("preco")
                        .HasColumnType("TEXT");

                    b.Property<int>("quantidade")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Notebooks");
                });

            modelBuilder.Entity("e_commerce.Models.Roupa_Praia", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("linkImagem")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("preco")
                        .HasColumnType("TEXT");

                    b.Property<int>("quantidade")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Roupas_Praia");
                });
#pragma warning restore 612, 618
        }
    }
}
