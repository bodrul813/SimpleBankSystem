namespace SimpleBankSystem.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal? DepositeBalance { get; set; }
        public decimal? WithdrawBalance { get; set; }
        public decimal CurrentBalance { get; set; }
        public DateTime TransactionDate { get; set; }

        public int CustomerId { get; set; }
        //Navigation Property
        public Customer Customer { get; set; }

         
    }
}
