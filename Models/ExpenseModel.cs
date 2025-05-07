namespace ExpenseTracker.Models
{
    public class ExpenseModel
    {
        public int Id { get; set; }
        public string ExpenseTitle { get; set; } = string.Empty;
        public string ExpenseDescription { get; set; } = string.Empty;
        public string ExpenseType { get; set; } = string.Empty;
        public DateTime ExpenseDate { get; set; } = DateTime.Now;
        public int ExpenseCost { get; set; }

    }
}
