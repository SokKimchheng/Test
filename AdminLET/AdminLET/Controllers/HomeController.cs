using AdminLET.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static AdminLET.Models.ItemModel;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace AdminLET.Controllers
{
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult GetData()
        {
            // Get data from your model or database
            var myData = new { Name = "John Doe", Age = 30 };
            return Json(myData);
        }
        public IActionResult GetItems()
        {
            var items = new List<Item>
        {
            new Item { Id = 1, Name = "Item 1" },
            new Item { Id = 2, Name = "Item 2" },
            new Item { Id = 3, Name = "Item 3" },
        };

            return Json(items);
        }

        public IActionResult GetEmployees()
        {
            var employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "John Doe", Department = "Sales", Salary = 45000 },
            new Employee { Id = 2, Name = "Jane Smith", Department = "Marketing", Salary = 55000 },
            new Employee { Id = 3, Name = "Bob Johnson", Department = "IT", Salary = 65000 },
        };

            return Json(employees);
        }
        public IActionResult GetEmployeeModel(int id)
        {
            // Assume we have an employee record with matching id
            var employee = new EmployeeModel { Id = 1, Name = "John Doe", Department = "Sales", Salary = 45000 };

            return Json(employee);
        }
        public IActionResult GetFruits()
        {
            var fruits = new List<Fruit>
        {
            new Fruit { Id = 1, Name = "Apple" },
            new Fruit { Id = 2, Name = "Banana" },
            new Fruit { Id = 3, Name = "Orange" }
        };

            return Json(fruits);
        }

        public JsonResult GetSelectOptions()
        {
            var options = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Option 1" },
            new SelectListItem { Value = "2", Text = "Option 2" },
            new SelectListItem { Value = "3", Text = "Option 3" }
        };

            return Json(options);
        }

    }
}