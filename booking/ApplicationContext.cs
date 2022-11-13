using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;
    public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
    {
  // создаем базу данных при первом обращении
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasNoKey();
    }
}