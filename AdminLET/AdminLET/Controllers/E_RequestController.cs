using Microsoft.AspNetCore.Mvc;

namespace AdminLET.Controllers
{
    public class E_RequestController : Controller
    {
        private readonly ILogger<E_RequestController> _logger;

        public E_RequestController(ILogger<E_RequestController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult User_Request()
        {
            return View();
        }
    }
}
