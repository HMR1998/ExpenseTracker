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

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]string email, [FromQuery]string password)
        {
            var account = await _loginService.GetByEmail(email, password);

            if (account == null)
            {
                return NotFound();
            }
            return Ok();

        }


    }
}
