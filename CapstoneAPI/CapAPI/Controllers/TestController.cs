using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ccsystems.Controllers
{
    public class TestController : Controller
    {
        [HttpGet]
        [Route("/read-claims")]
        public IActionResult TestClaimReading()
        {
            var username = HttpContext.User.Identity.Name;
            var customClaim = HttpContext.User.FindFirst("MyCustomClaim");

            return Content($"User {username} has custom claim value: {customClaim.Value}");
        }
    }
}