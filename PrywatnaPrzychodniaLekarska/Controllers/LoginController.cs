using Microsoft.AspNetCore.Mvc;
using SavingApiMenager.Contracts;
using SavingApiMenager.Models;

namespace SavingApiMenager.Controllers
{
    [ApiController]
    [Route("login")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        public ActionResult Login([FromBody] Credentials dto)
        {
            var token = _loginService.TokenGenerator(dto);
            return Ok(token);
        }
    }
}
