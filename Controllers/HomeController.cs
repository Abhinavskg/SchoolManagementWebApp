using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementApp.MVC.Models;

namespace SchoolManagementApp.MVC.Controllers;

[AllowAnonymous]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }
    public IActionResult Vision()
    {
        return View();
    }

    public IActionResult Introduction()
    {
        return View();
    }
    public IActionResult Fees()
    {
        return View();
    }

    public IActionResult AdmissionProcess()
    {
        return View();
    }

    public IActionResult Facilities()
    {
        return View();
    }

    public IActionResult Rules()
    {
        return View();
    }

    public IActionResult Galary()
    {
        return View();
    }
    public IActionResult Contect()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
