using Microsoft.EntityFrameworkCore;
using TeddyBearAPI.Models;

namespace TeddyBearAPI.Utilities
{
    public class DBContext : DbContext
    {
        public DBContext() { }
        public DBContext(DbContextOptions<DBContext> options): base(options) { }
        public DBContext(string connectionString) : base(GetOptions(connectionString)) { }

        private static DbContextOptions GetOptions(string connectionString)
        {
            throw new NotImplementedException();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-BBVNKGM;Initial Catalog=Teddy_bear;Persist Security Info=True;User ID=sa;Password=123;TrustServerCertificate=True;");
        }
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Hashtag> Hashtags { get; set; } = null!;
        public DbSet<Size> Sizes { get; set; } = null!;
        public DbSet<Product_Hashtag> Product_Hashtags { get; set; } = null!;
        public DbSet<Product_Size> Product_Sizes { get; set; } = null!;


    }
}
