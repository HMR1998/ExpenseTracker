using ExpenseTracker.Models;

namespace ExpenseTracker.Services
{
    public interface ILoginService
    {
        Task<RegistrationModel?> GetByEmail(string email, string password);
    }
}
