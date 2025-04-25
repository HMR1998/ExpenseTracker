using ExpenseTracker.Data;
using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore.Internal;

namespace ExpenseTracker.Services
{
    public class RegistrationService : IRegistrationService
    {
        private readonly DataContext _dataContext;

        public RegistrationService(DataContext dataContext) =>
            _dataContext = dataContext;

        public async Task AddNewUser(RegistrationModel newUser)
        {
            _dataContext.Add(newUser);
            await _dataContext.SaveChangesAsync();
        }
    }
}
