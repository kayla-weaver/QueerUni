using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using QueerUni.Models;

namespace QueerUni.Controllers;

public class EducationController : Controller
{
    [HttpGet("/")]

    public IActionResult Index()
    {
        return View();
    }

}
