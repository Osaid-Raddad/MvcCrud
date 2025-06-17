using introToMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace introToMvc.Data

{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-420PRC7;Database=Crud;Trusted_Connection=True;TrustServerCertificate=True");

        }
    }
}
