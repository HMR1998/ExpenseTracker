using ExpenseTracker.Models;
using ExpenseTracker.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    [ApiController]
    [Route("api/login")]
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService) =>
            _loginService = loginService;

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginModel login)
        {
            if (login == null || string.IsNullOrEmpty(login.Email) || string.IsNullOrEmpty(login.Password))
            {
                return BadRequest("Email or Password is required");
            }

            var account = await _loginService.GetByEmail(login.Email, login.Password);

            if (account == null)
            {
                return Unauthorized("Invalid Username or Password");
            }
            return Ok(new { Message = "Login Successful", Account = account });

        }


    }
}
