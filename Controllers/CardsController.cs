using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TimesUp.Controllers
{
    public static class State
    {
        public static IList<string> RemainingCards { get; set; } = new List<string>
        {
            "Test",
            "Test1",
            "Test2",
            "Test3",
            "Test4",
            "Test5",
            "Test6"
        };
    }
    
    public class CardsController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Json(State.RemainingCards);
        }

        [HttpPost]
        public IActionResult Post(IList<string> newState)
        {
            State.RemainingCards = newState;
            return Ok();
        }
    }
}
