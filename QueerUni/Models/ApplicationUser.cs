using Microsoft.AspNetCore.Identity;

namespace QueerUni.Models
{
  public class ApplicationUser : IdentityUser
  {
    public string UserName{ get; set; }
    
  }
}