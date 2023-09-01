namespace SpendingAnalyticsSystem.API.Models
{
    public class AccountItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public string Account { get; set; }
        public decimal Amount { get; set; }
        public Subcategory Subcategory { get; set; }
        public string Memo { get; set; }
        public decimal Balance { get; set; }

    }
}
