using Microsoft.EntityFrameworkCore;

public class TradeContext : DbContext
{
    public DbSet<Company> Companies { get; set; }
    public DbSet<Manager> Managers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Sale> Sales { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=TradesOperations;User Id=SA;Password=Password123!;TrustServerCertificate=True;");
    }
}
