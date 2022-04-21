using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using assignment_wedding_planner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

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

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public IActionResult Index()
    {

      return Redirect("/login");
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    [HttpGet("/logout")]
    public IActionResult LogOut()
    {
      // need to clear session
      HttpContext.Session.Clear();

      return Redirect("/login");
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    [HttpGet("/login")]
    public IActionResult Login()
    {
      ViewBag.AllUsers = _context.Users.OrderBy(a => a.FirstName).ToList();
      ViewBag.AllWeddings = _context.Weddings.OrderBy(a => a.WedderOne).ToList();
      ViewBag.Session_UserId = HttpContext.Session.GetInt32("Session_UserId");
      ViewBag.Session_FirstName = HttpContext.Session.GetString("Session_FirstName");
      ViewBag.Session_LastName = HttpContext.Session.GetString("Session_LastName");
      return View();
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    [HttpGet("/dashboard")]
    public IActionResult Dashboard()
    {
            Console.WriteLine("--------------------------IN Dashboard");

      if (HttpContext.Session.GetInt32("Session_UserId") == null)
      {
            Console.WriteLine("--------------------------Null UseId");

        return RedirectToAction("Logout");
      }
            Console.WriteLine("--------------------------Rendering Dashboard");

      ViewBag.AllUsers = _context.Users.OrderBy(a => a.FirstName).ToList();
      ViewBag.AllWeddings = _context.Weddings.OrderBy(a => a.WedderOne).ToList();
      ViewBag.Session_UserId = HttpContext.Session.GetInt32("Session_UserId");
      ViewBag.Session_FirstName = HttpContext.Session.GetString("Session_FirstName");
      ViewBag.Session_LastName = HttpContext.Session.GetString("Session_LastName");
      return View();
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    [HttpGet("/new")]
    public IActionResult NewWedding()
    {
      ViewBag.AllUsers = _context.Users.OrderBy(a => a.FirstName).ToList();
      ViewBag.AllWeddings = _context.Weddings.OrderBy(a => a.WedderOne).ToList();
      ViewBag.Session_UserId = HttpContext.Session.GetInt32("Session_UserId");
      ViewBag.Session_FirstName = HttpContext.Session.GetString("Session_FirstName");
      ViewBag.Session_LastName = HttpContext.Session.GetString("Session_LastName");
      return View();
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    [HttpPost("users/add")]
    public IActionResult AddUser(User newUser)
    {
      if (ModelState.IsValid)
      {

        // Duplicate Emails
        if (_context.Users.Any(s => s.Email == newUser.Email))
        {
          ModelState.AddModelError("Email", "This email already in use.");
          return View("Login");
        }

        // Hash Pass
        PasswordHasher<User> Hasher = new PasswordHasher<User>();
        newUser.Password = Hasher.HashPassword(newUser, newUser.Password);

        _context.Users.Add(newUser);
        _context.SaveChanges();

        HttpContext.Session.SetString("Session_FirstName", newUser.FirstName);
        HttpContext.Session.SetString("Session_LastName", newUser.LastName);
        HttpContext.Session.SetInt32("Session_UserId", newUser.UserId);
        return RedirectToAction("Dashboard");
      }
      else
      {
        return View("Login");
      }
    }
    [HttpPost("users/login")]
    public IActionResult LogUser(LoginUser loggedIn)
    {
      Console.WriteLine("--------------------------LogUser");
      if (ModelState.IsValid)
      {
        Console.WriteLine("--------------------------ModelStateIsValid");
        User userInDb = _context.Users.FirstOrDefault(a => a.Email == loggedIn.LoginEmail);
        if (userInDb == null)
        {
          Console.WriteLine("--------------------------== null");
          ModelState.AddModelError("LoginEmail", "Invalid login attempt");
          return View("Login");
        }
        Console.WriteLine("--------------------------Hashing Passwords");
        var hasher = new PasswordHasher<LoginUser>();
        var result = hasher.VerifyHashedPassword(loggedIn, userInDb.Password, loggedIn.LoginPassword);
        if (result == 0)
        {
          Console.WriteLine("--------------------------result == 0");
          ModelState.AddModelError("LoginEmail", "Invalid login attempt");
          return View("Login");
        }
        Console.WriteLine("--------------------------Redirecting to Dashboard");

        HttpContext.Session.SetString("Session_FirstName", userInDb.FirstName);
        HttpContext.Session.SetString("Session_LastName", userInDb.LastName);
        HttpContext.Session.SetInt32("Session_UserId", userInDb.UserId);
        return RedirectToAction("Dashboard");
      }
      Console.WriteLine("--------------------------ModelState Invalid");

      return View("Login");

    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
