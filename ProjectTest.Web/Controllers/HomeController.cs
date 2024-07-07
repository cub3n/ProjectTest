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

    [HttpPost]
    public JsonResult GetEmployees()
    {
        var employees = new List<Employee>
            {
                new Employee { FullName = "John Doe", EmployeeID = "E001", SIN = 123456789, PhoneNumber = 2222341234, City = "Mississauga", Salary = 50000.542m, Country = "Canada" },
                new Employee { FullName = "Jane Smith", EmployeeID = "E002", SIN = 987654321, PhoneNumber = 3333452345, City = "Toronto", Salary = 60000.739m, Country = "USA" },
                new Employee { FullName = "Emily Johnson", EmployeeID = "E003", SIN = 234567891, PhoneNumber = 4445567890, City = "Mississauga", Salary = 51000.266m, Country = "Canada" },
                new Employee { FullName = "Michael Thompson", EmployeeID = "E004", SIN = 345678912, PhoneNumber = 5556678901, City = "Mississauga", Salary = 52000.697m, Country = "Canada" },
                new Employee { FullName = "Sarah Williams", EmployeeID = "E005", SIN = 456789123, PhoneNumber = 6667789012, City = "Mississauga", Salary = 53000.827m, Country = "Canada" },
                new Employee { FullName = "David Brown", EmployeeID = "E006", SIN = 567891234, PhoneNumber = 7778890123, City = "Mississauga", Salary = 54000.952m, Country = "Canada" },
                new Employee { FullName = "Alex Daniel", EmployeeID = "E007", SIN = 678912345, PhoneNumber = 8889901234, City = "Matanzas", Salary = 56000.411m, Country = "Cuba" }
            };
        return Json(employees);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
