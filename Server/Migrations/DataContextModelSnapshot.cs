// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Fruit Selected and stored fresh",
                            ImageUrl = "https://m.media-amazon.com/images/I/31zxVniGbKL.jpg",
                            Price = 0.59m,
                            Title = "Banana"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Vegetable Grown in Mexico or California",
                            ImageUrl = "https://m.media-amazon.com/images/I/81aqzdQPufL._SL1469_.jpg",
                            Price = 1.49m,
                            Title = "Medium Hass Avocado"
                        },
                        new
                        {
                            Id = 3,
                            Description = "365 by Whole Foods Market",
                            ImageUrl = "https://m.media-amazon.com/images/I/71WAUJ5chvL._SL1500_.jpg",
                            Price = 3.99m,
                            Title = "Feta Crumbles"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
