using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using SavingFileRazorFrontend.Models;
using SavingFileRazorFrontend.Services;

namespace SavingFileRazorFrontend.Controllers
{
    public class LoginController : Controller
    {
        public CrudService _crudService;

        public LoginController()
        {
            _crudService = new();
        }

        public IActionResult Index()
        {
            var response = new LoginModel
            {
                Message = ""
            };
            ViewBag.Admin = 1;
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Index([Bind("Email, Password")] LoginModel model)
        {
            if (model.Email == null && model.Password == null || model.Email == null || model.Password == null)
            {
                Response.Cookies.Delete("jwt");
                Response.Cookies.Delete("role");
                Response.Cookies.Delete("email");
                return RedirectToAction("Index", "Home");
            }

            string loginUrl = "https://localhost:44391/login";
            string content = JsonConvert.SerializeObject(model);
            var response = await _crudService.Logging(loginUrl, content);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var result = await response.Content.ReadAsStringAsync();
                var authResult = JsonConvert.DeserializeObject<AuthResult>(result);

                var cookieOptions = new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddMinutes(20),
                    Domain = loginUrl,
                    Path = "/"
                };

                HttpContext.Response.Cookies.Append("jwt", authResult.Token);
                HttpContext.Response.Cookies.Append("email", authResult.User.Email);
                HttpContext.Response.Cookies.Append("role", authResult.User.Role);

                Response.Cookies.Append("jwt", authResult.Token, cookieOptions);
                Response.Cookies.Append("email", authResult.Token, cookieOptions);
                Response.Cookies.Append("role", authResult.Token, cookieOptions);

                return RedirectToAction("Index", "Home");
            }

            else
            {
                var result = await response.Content.ReadAsStringAsync();
                ViewData["Message"] = $"{result}";
                Response.Cookies.Delete("jwt");
                Response.Cookies.Delete("role");
                Response.Cookies.Delete("email");
                ViewBag.Admin = 1;

                return View();
            }
        }
    }
}
