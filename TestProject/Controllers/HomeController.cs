using Microsoft.AspNetCore.Mvc;

namespace ProgrammingPractice.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult Index()
        {
            return View("../HomeView");
        }
    }
}
