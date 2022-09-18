using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParksAPI.Models;

namespace ParksAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly ParksAPIContext _db;

    public ParksController(ParksAPIContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get(string name, int year, string type)
    {
      IQueryable<Park> query = _db.Parks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      if (year > 0)
      {
        query = query.Where(entry => entry.Year == year);
      }
      if (type != null)
      {
        query = query.Where(entry => entry.Type == type);
      }
      return await query.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
      var park = await _db.Parks.FindAsync(id);
      if (park == null)
      {
        return NotFound();
      }
      return park;
    }

    // public IActionResult Index()
    // {
    //   var allParks = Park.GetParks();
    //   return View(allParks);
    // }

    // [HttpPost]
    // public IActionResult Index(Park park)
    // {
    //   Park.Post(park);
    //   return RedirectToAction("Index");
    // }

    // public IActionResult Details(int id)
    // {
    //   var park = Park.GetDetails(id);
    //   return View(park);
    // }

    // public IActionResult Edit(int id)
    // {
    //   var park = Park.GetDetails(id);
    //   return View(park);
    // }

    // [HttpPost]
    // public IActionResult Details(int id, Park park)
    // {
    //   park.ParkId = id;
    //   Park.Put(park);
    //   return RedirectToAction("Details", id);
    // }

    // public IActionResult Delete(int id)
    // {
    //   Park.Delete(id);
    //   return RedirectToAction("Index");
    // }
  }
}