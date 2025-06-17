using System.ComponentModel.DataAnnotations;

namespace SimpleBankSystem.Models
{
    public class Loan
    {
        public int Id { get; set; }
        [Required] 
        public string LoanNumber { get; set; }
        public int LoanTypeId { get; set; }
        public decimal LoanAmount { get; set; }
        public int TotalMonth { get; set; } 
        public float Interest {  get; set; }
        public DateTime ApplyTime { get; set; }
        public DateTime ApproveTime { get; set; }
        public DateTime EndTime { get; set; }


        //Nabigation property
        public LoanType LoanType { get; set; }

    }

}
