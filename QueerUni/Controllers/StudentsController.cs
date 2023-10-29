using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using QueerUni.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;


namespace QueerUni.Controllers
{
  [Authorize]
  public class StudentsController : Controller
  {
    private readonly QueerUniContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public StudentsController(UserManager<ApplicationUser> userManager, QueerUniContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public IActionResult Register()
    {
      ViewBag.TrackList = new SelectList(_db.Tracks, "TrackId", "TrackName");
        return View();
    }

    [HttpPost]
    public IActionResult Register(Student student)
    {
      if (student.Track != null && student.Track.TrackName != default(TrackName))
            {
        _db.Students.Add(student);
        _db.SaveChanges();
            } 
    
    return RedirectToAction("Index", "Home");
    } 
    public async Task<ActionResult> Index()
    {
      string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);

      Student currentUserStudentData = _db.Students
                          .Include(student => student.JoinEntities)
                          .ThenInclude(join => join.Track)
                          .FirstOrDefault(student => student.User.Id == currentUser.Id);
                          

        return View(currentUserStudentData);
    }
    public async Task<IActionResult> Edit(int id)
{
    var student = await _db.Students.Include(student => student.JoinEntities).ThenInclude(join => join.Track).FirstOrDefaultAsync(student => student.StudentId == id);
    if (student == null)
    {
        return NotFound();
    }
    ViewBag.TrackList = new SelectList(_db.Tracks, "TrackId", "TrackName");
    return View(student);
}

[HttpPost]
public async Task<IActionResult> Edit(Student student)
{
    if (ModelState.IsValid)
    {
        _db.Entry(student).State = EntityState.Modified;
        await _db.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    return View(student);
}

public async Task<IActionResult> Details(int? id)
{
  if (id == null)
  {
    return NotFound();
  }
  var student = await _db.Students
                          .Include(s => s.JoinEntities)
                          .ThenInclude(JoinEntities =>JoinEntities.Track)
                          .FirstOrDefaultAsync(s => s.StudentId == id);
if (student == null)
{
  return NotFound();
}
return View(student);
}
  }
}



/*

    public async Task<ActionResult> Index()
    {
      string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);

      Student foundStudent = _db.Students
                            .Where(s.User.Id == currentUser.Id);
      foundStudent
      List<Track> tracks = _db.Tracks
                            .Where(t=>t.User.Id == currentUser.Id)
                            .ToList();
      
      return View(tracks);
    }

*/