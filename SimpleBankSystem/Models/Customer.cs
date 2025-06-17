namespace SimpleBankSystem.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public AcType AccountType { get; set; }
        public decimal InitialBalance { get; set; }
        public decimal CurrentBalance { get; set; }
        public AcStatus AccountStatus { get; set; }

    }
    public enum AcType
    {
        Current,
        Saving,
        Student,
        Vip,
        Loan
    }

    public enum AcStatus
    {
        Active,
        Inactived,
        Bolcked,
        Deleted
    }
}
