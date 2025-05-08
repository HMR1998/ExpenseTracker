using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<RegistrationModel> RegistrationModels { get; set; }
        public DbSet<LoginModel> LoginModels { get; set; }
        public DbSet<ExpenseModel> ExpenseModels { get; set; }
    }
}
