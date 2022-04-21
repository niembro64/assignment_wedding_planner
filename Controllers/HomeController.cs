using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using assignment_wedding_planner.Models;
using Microsoft.EntityFrameworkCore;

namespace assignment_wedding_planner.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;
    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
      _logger = logger;
      _context = context;
    }

    public IActionResult Index()
    {
      return Redirect("/login");
    }

    [HttpGet("/login")]
    public IActionResult Login()
    {
      return View();
    }
    [HttpGet("/logout")]
    public IActionResult LogOut()
    {
      // need to clear session

      return Redirect("/login");
    }
    [HttpGet("/dashboard")]
    public IActionResult Dashboard()
    {
      return View();
    }
    [HttpGet("/new")]
    public IActionResult NewWedding()
    {
      return View();
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    [HttpPost("users/add")]
    public IActionResult AddUser(User newUser)
    {
      if (ModelState.IsValid)
      {
        _context.Users.Add(newUser);
        _context.SaveChanges();

        ViewBag.AllUsers = _context.Users.OrderBy(a => a.FirstName).ToList();
        ViewBag.AllWeddings = _context.Weddings.OrderBy(a => a.WedderOne).ToList();

        return RedirectToAction("Dashboard");
      }
      else
      {
        ViewBag.AllUsers = _context.Users.OrderBy(a => a.FirstName).ToList();
        ViewBag.AllWeddings = _context.Weddings.OrderBy(a => a.WedderOne).ToList();

        return View("Login");
      }
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
