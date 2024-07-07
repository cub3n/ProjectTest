using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjectTest.Web.Models;

namespace ProjectTest.Web.Controllers;

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

    public IActionResult Kendo()
    {
        return View();
    }

    [HttpGet]
    [HttpPost]
    public JsonResult GetEmployees()
    {
        return Json(Constants.Employees);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
