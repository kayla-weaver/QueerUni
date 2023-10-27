using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using QueerUni.Models;
using System.Collections.Generic;
using System.Linq;


namespace QueerUni.Controllers
{
  public class TracksController : Controller
  {
    private readonly QueerUniContext _db;

    public TracksController(QueerUniContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {


    return View();
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Track track)
    {
      _db.Tracks.Add(track);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
public IActionResult Track1Info()
    {
        return View();
    }

public IActionResult Track2Info()
    {
        return View();
    }

public IActionResult Track3Info()
    {
        return View();
    }

public IActionResult About()
    {
        return View();
    }

public IActionResult Contact()
    {
        return View();
    }


  }
}