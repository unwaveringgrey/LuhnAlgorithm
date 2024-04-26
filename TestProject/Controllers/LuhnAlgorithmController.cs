using Microsoft.AspNetCore.Mvc;
using ProgrammingPractice.DTOs;
using ProgrammingPractice.Models;

namespace ProgrammingPractice.Controllers
{
    public class LuhnAlgorithmController : Controller
    {
        [Route("LuhnAlgorithm")]
        [HttpGet]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult Index()
        {
            return View("../LuhnAlgorithmView");
        }

        [Route("LuhnAlgorithm")]
        [HttpPost]
        public IActionResult LuhnValidate(LuhnDTO LuhnStringToValidate)
        {
            //TODO: this needs validation to make sure that stringToValidate is actually a string.
            LuhnStringToValidate.luhnValid = LuhnAlgorithm.validate(LuhnStringToValidate.luhnString);


            return Ok(LuhnStringToValidate);
        }
    }
}
