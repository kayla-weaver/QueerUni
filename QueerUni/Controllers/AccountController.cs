using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using QueerUni.Models;
using System.Threading.Tasks;
using QueerUni.ViewModels;
using System.Linq;
using System.Security.Claims;


namespace QueerUni.Controllers
{
 public class AccountController : Controller
 {
   private readonly QueerUniContext _db;
   private readonly UserManager<ApplicationUser> _userManager;
   private readonly SignInManager<ApplicationUser> _signInManager;

   public AccountController (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, QueerUniContext db)
   {
     _userManager = userManager;
     _signInManager = signInManager;
     _db = db;
   }

   public ActionResult Index()
   {
     return View();
   }

   public IActionResult Register()
   {
     return View();
   }

   [HttpPost]
   public async Task<ActionResult> Register (RegisterViewModel model)
   {
     if (!ModelState.IsValid)
     {
      var user = new ApplicationUser {UserName = model.Name, Email = model.Email};
      var result = await _userManager.CreateAsync(user, model.Password);

      if (result.Succeeded)
      {
        var student = new Student
        {
          Name = model.Name,
          Email = model.Email,
          User = user
        };

        _db.Students.Add(student);
        await _db.SaveChangesAsync(); //adds student to database
      }
       return View(model); // returns Register view with RegisterViewModel
     }
     else
     {
       ApplicationUser user = new ApplicationUser { UserName = model.Email };
       IdentityResult result = await _userManager.CreateAsync(user, model.Password);
       if (result.Succeeded)
       {
         return RedirectToAction("Index");
       }
       else
       {
         foreach (IdentityError error in result.Errors)
         {
           ModelState.AddModelError("", error.Description);
         }
         return View(model);
       }
     }
   }
    public ActionResult Login()
   {
     return View();
   }

   [HttpPost]
   public async Task<ActionResult> Login(LoginViewModel model)
   {
     if (!ModelState.IsValid)
     {
       return View(model);
     }

     Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);

      if (result.Succeeded)
    {
        // Get the logged-in user
        var user = await _userManager.FindByEmailAsync(model.Email);

        // Retrieve the associated student based on the user ID
        var student = _db.Students.FirstOrDefault(s => s.User.Id == user.Id);

        if (student != null)
        {
            // Add StudentId as a claim
            var studentIdClaim = new Claim("StudentId", student.StudentId.ToString());
            await _userManager.AddClaimAsync(user, studentIdClaim);
        }

        return RedirectToAction("Index");
    }
    else
    {
        ModelState.AddModelError("", "There is something wrong with your email or username. Please try again.");
        return View(model);
    }

     }
   
   [HttpPost]
   public async Task<ActionResult> LogOff()
   {
    await _signInManager.SignOutAsync();
    return RedirectToAction("Index");
   }
   
}
}



   //  Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
      //  if (result.Succeeded)
      //  {
      //    return RedirectToAction("Index");
      //  }
      //  else
      //  {
      //    ModelState.AddModelError("", "There is something wrong with your email or username. Please try again.");
      //    return View(model);
      //  }
 




