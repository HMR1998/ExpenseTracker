namespace ExpenseTracker.Models
{
    public static class ExpenseSubCategories
    {
        public static readonly Dictionary<ExpenseCategories, List<string>> Subcategories = new()
        {
            {ExpenseCategories.HouseholdBills, new() {"Rent/Mortgage", "Utilities", "Internet", "Council Tax", "Furniture/Appliances"} },
            {ExpenseCategories.Transportation, new() {"Fuel", "Car Insurance", "Public Transport", "Road Tax", "Parking Fees", "Repair/Maintenance" } },
            {ExpenseCategories.FoodAndGroceries, new() {"Coffee/Snacks", "Groceries", "Dining Out", "Take away"} },
            {ExpenseCategories.HealthAndMedical, new() {"Dental Care", "Gym", "Optometrist", "Medicine"} },
            {ExpenseCategories.LeisureAndHobbies, new() {"Streaming Services", "Holiday", "Subscriptions", "Hobbies"} },
            {ExpenseCategories.PersonalCare, new() {"Clothes", "Shoes", "Bags", "Haircuts/Salons", "Skincare/toiletries", "Cosmetics"} },
            {ExpenseCategories.Miscellaneous, new() {"Zakat", "Gifts", "Miscellaneous" } },
            {ExpenseCategories.Financial, new() {"Loan Payments", "Credit Card Payments" } },
            {ExpenseCategories.Savings, new() {"Savings", "Emergency Funds"} }
        };
    }
}
