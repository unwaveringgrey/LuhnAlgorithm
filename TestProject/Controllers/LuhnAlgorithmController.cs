using Microsoft.AspNetCore.Mvc;

namespace ProgrammingPractice.Controllers
{
    public class LuhnAlgorithmController : Controller
    {
        [Route("LuhnAlgorithm")]
        public IActionResult Index()
        {
            return View("../LuhnAlgorithmView");
        }
    }
}
