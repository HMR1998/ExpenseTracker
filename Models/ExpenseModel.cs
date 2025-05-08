namespace ExpenseTracker.Models
{
    public class ExpenseModel
    {
        public int Id { get; set; }
        public string ExpenseTitle { get; set; } = string.Empty;
        public string ExpenseDescription { get; set; } = string.Empty;
        public ExpenseCategories Categories { get; set; }
        public DateTime ExpenseDate { get; set; } = DateTime.Now;
        public decimal ExpenseCost { get; set; }

    }
}
