using ExpenseTracker.Models;

namespace ExpenseTracker.Services
{
    public interface IRegistrationService
    {
        Task AddNewUser(RegistrationModel newUser);
    }
}
