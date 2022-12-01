using Microsoft.AspNetCore.Mvc;

namespace Mvc_Github.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
