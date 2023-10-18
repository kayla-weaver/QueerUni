using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using QueerUni.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace QueerUni.Controllers;

public class HomeController : Controller
{
    private readonly QueerUniContext _db;
    public HomeController(QueerUniContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public IActionResult Index()
    {
        return View();
    }
}
