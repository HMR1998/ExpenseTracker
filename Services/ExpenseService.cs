using ExpenseTracker.Data;
using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Services
{
    public class ExpenseService: IExpenseService
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

        public async Task<bool> UpdateExpense(int id, ExpenseModel expenseModel)
        {
            var existingExpense = await _dataContext.ExpenseModels.FindAsync(id);

            if (existingExpense == null) return false;

            existingExpense.ExpenseDescription = expenseModel.ExpenseDescription;
            existingExpense.ExpenseTitle = expenseModel.ExpenseTitle;
            existingExpense.ExpenseCost = expenseModel.ExpenseCost;
            existingExpense.Categories = expenseModel.Categories;

            await _dataContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteExpense(int id)
        {
            var existingExpense = await _dataContext.ExpenseModels.FindAsync(id);

            if ( existingExpense == null) return false;

            _dataContext.ExpenseModels.Remove(existingExpense);
            await _dataContext.SaveChangesAsync();
            return true;
        }
    }
}
