using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace QueerUni.Models
{
  public class QueerUniContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Track> Track { get; set; }
    public DbSet<Student> Student { get; set; }

    public QueerUniContext(DbContextOptions options) : base(options) { }
  }
}