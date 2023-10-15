using Microsoft.EntityFrameworkCore;

namespace QueerUni.Models
{
  public class QueerUniContext : DbContext
  {
    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<CurrentTerm> CurrentTerm {get; set; }

    public QueerUniContext(DbContextOptions options) : base(options) { }
  }
}