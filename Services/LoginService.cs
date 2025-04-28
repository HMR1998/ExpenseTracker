using ExpenseTracker.Data;
using ExpenseTracker.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ExpenseTracker.Services
{
    public class LoginService : ILoginService
    {
        private readonly DataContext _datacontext;

        public LoginService(DataContext dataContext) =>
            _datacontext = dataContext;

        public async Task<RegistrationModel?> GetByEmail(string email, string password)
        {
            var account = await _datacontext.RegistrationModels.FirstOrDefaultAsync(x => x.Email == email && x.Password == password);
            await _datacontext.SaveChangesAsync();
            return account;
        }

/*        public async Task<LoginModel> CheckIfLoginDetailsValid(LoginModel userLogin)
        {
            if (string.IsNullOrEmpty(userLogin.Email) || (string.IsNullOrEmpty(userLogin.Password))
            {
                await _datacontext.SaveChangesAsync();
                return ("Email and Password are Required");
            }
        }*/
    }
}
