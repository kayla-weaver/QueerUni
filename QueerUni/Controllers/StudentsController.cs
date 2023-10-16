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
    public ActionResult Index()
    {
      List<Student> model = _db.Student
                            .Include(student => student.Tracks)
                            .ToList();
      return View(model);
    }
  }
}