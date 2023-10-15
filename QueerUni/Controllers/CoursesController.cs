using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using QueerUni.Models;
using System.Collections.Generic;
using System.Linq;

namespace QueerUni.Controllers
{
  public class CoursesController : Controller
  {
    private readonly QueerUniContext _db;

    public CoursesController(QueerUniContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View();
    }  }
}