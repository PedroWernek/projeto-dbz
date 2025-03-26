using Microsoft.EntityFrameworkCore;
using ProjetoDBZ.Controllers;

namespace ProjetoDBZ.Models
{
    public class AppDbContext : DbContext
    {
      public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
      {}
      public DbSet<Personagem> dbzDB { get; set; }
    }
}