using Microsoft.AspNetCore.Mvc;

namespace ProgrammingPractice.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home")]
        public IActionResult Index()
        {
            return View("../HomeView");
        }
    }
}
