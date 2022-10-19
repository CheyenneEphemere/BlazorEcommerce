namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Banana",
                    Description = "Fruit Selected and stored fresh",
                    ImageUrl = "https://m.media-amazon.com/images/I/31zxVniGbKL.jpg",
                    Price = 0.59m
                },
                new Product
                {
                    Id = 2,
                    Title = "Medium Hass Avocado",
                    Description = "Vegetable Grown in Mexico or California",
                    ImageUrl = "https://m.media-amazon.com/images/I/81aqzdQPufL._SL1469_.jpg",
                    Price = 1.49m
                },
                new Product
                {
                    Id = 3,
                    Title = "Feta Crumbles",
                    Description = "365 by Whole Foods Market",
                    ImageUrl = "https://m.media-amazon.com/images/I/71WAUJ5chvL._SL1500_.jpg",
                    Price = 3.99m
                });
        }

        public DbSet<Product> Products { get; set; }
    }
}
