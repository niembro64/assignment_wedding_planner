using Microsoft.EntityFrameworkCore;
namespace assignment_wedding_planner.Models
{
  public class MyContext : DbContext
  {
    public MyContext(DbContextOptions options) : base(options) { }
    public DbSet<User> Users { get; set; }
    public DbSet<Wedding> Weddings { get; set; }
    public DbSet<Reservation> Reservation { get; set; }
  }
}