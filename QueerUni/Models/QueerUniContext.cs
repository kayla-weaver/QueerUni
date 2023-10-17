using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace QueerUni.Models
{
  public class QueerUniContext : DbContext
  {
    public DbSet<Track> Track { get; set; }
    public DbSet<Student> Student { get; set; }

    public QueerUniContext(DbContextOptions options) : base(options) { }
  }
}