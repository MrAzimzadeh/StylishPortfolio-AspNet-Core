using Microsoft.EntityFrameworkCore;
using WebApp.Models;


namespace WebApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<About> Abouts { get; set; }
    public DbSet<CallAction> CallActions { get; set; }

    public DbSet<Callout> Callouts { get; set; }
    public DbSet<Header> Headers { get; set; }
    public DbSet<Portfolio> Portfolios { get; set; }
    public DbSet<Services> Services { get; set; }
}