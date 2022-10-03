using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ccsystems.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        [HttpGet]
        [Route("/login")]
        public IActionResult GetLoginScreen()
        {
            return View("Login");
        }

        [HttpPost]
        [Route("/login")]
        public async Task<IActionResult> LoginUser(
            string username, string password, string returnUrl)
        {
            var loginValid = ValidateLogin(username, password);

            if (!loginValid)
            {
                TempData["LoginFailed"] = $"The username or password is incorrect.";

                return Redirect("/login");
            }
            else
            {
                await SignInUser(username);

                if (string.IsNullOrWhiteSpace(returnUrl) || !returnUrl.StartsWith("/"))
                {
                    returnUrl = "/";
                }

                return this.Redirect(returnUrl);
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            // Check the user/pass here!
            // For example's sake, the credentials are always valid.
            return true;
        }

        private async Task SignInUser(string username)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, username),
                new Claim("MyCustomClaim", "my claim value")
            };

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity));
        }
    }
}