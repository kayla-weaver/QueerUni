using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using QueerUni.Models;

namespace QueerUni.Controllers;

public class HomeController : Controller
{
    [HttpGet("/")]

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

}
