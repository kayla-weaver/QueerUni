using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using QueerUni.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

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
      List<Track> model = _db.Track
                          .Include(model => model.TrackName)
                          .ToList();

      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Track track)
    {
      _db.Tracks.Add(Track);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

  }
}