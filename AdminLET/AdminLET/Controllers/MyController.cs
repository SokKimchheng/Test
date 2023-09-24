using Microsoft.AspNetCore.Mvc;

namespace AdminLET.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
