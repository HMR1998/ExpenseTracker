using ExpenseTracker.Data;
using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Services
{
    public class ExpenseService
    {
        private readonly DataContext _dataContext;

        public ExpenseService(DataContext dataContext) =>
            _dataContext = dataContext;

        public async Task<IEnumerable<ExpenseModel?>> GetAllExpenses()
        {
            return await _dataContext.ExpenseModels.ToListAsync();
        }

        public async Task<ExpenseModel> AddExpense(ExpenseModel expenseModel)
        {
            var expense = await _dataContext.AddAsync(expenseModel);
            await _dataContext.SaveChangesAsync();
            return expense.Entity;
        }
    }
}
