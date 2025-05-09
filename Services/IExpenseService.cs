using ExpenseTracker.Models;

namespace ExpenseTracker.Services
{
    public interface IExpenseService
    {
        Task<IEnumerable<ExpenseModel?>> GetAllExpenses();
        Task<ExpenseModel> AddExpense(ExpenseModel expenseModel);
        Task<bool> UpdateExpense(int id, ExpenseModel expenseModel);
        Task<bool> DeleteExpense(int id);
    }
}