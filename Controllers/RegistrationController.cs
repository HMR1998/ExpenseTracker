using ExpenseTracker.Models;
using ExpenseTracker.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    [ApiController]
    [Route("api/Registration")]
    public class RegistrationController : Controller
    {
        private readonly IRegistrationService _registrationService;

        public RegistrationController(IRegistrationService registrationService) => 
            _registrationService = registrationService;

        [HttpPost]
        public async Task<IActionResult> Post(RegistrationModel newUser)
        {
            await _registrationService.AddNewUser(newUser);
            return Ok(newUser);
        }
    }
}
