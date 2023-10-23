using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using QueerUni.Models;
using System.Collections.Generic;
using System.Linq;

namespace QueerUni.Controllers
{
  public class StudentsController : Controller
  {
    private readonly QueerUniContext _db;
    public StudentsController(QueerUniContext db)
    {
      _db = db;
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(Student students)
    {
      if (students.Track1 == true || students.Track2 == true || students.Track3 == true)
            {
        _db.Student.Add(students);
        _db.SaveChanges();
            } 
      // _db.Student.Add(students);
      // _db.SaveChanges();
    
    return RedirectToAction("Index");
    } 
    public IActionResult Index()
    {
        return View();
    }
  }
}