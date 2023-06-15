using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SavingFileApi.Interfaces;
using SavingFileApi.Models;

namespace SavingFileApi.Controllers
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
