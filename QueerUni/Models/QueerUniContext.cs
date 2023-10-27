using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace QueerUni.Models
{
  public class QueerUniContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Track> Tracks { get; set; }
    public DbSet<Student> Students { get; set; }

    public DbSet<StudentTrack> StudentTracks { get; set; }
    public QueerUniContext(DbContextOptions options) : base(options) { }
  }
}