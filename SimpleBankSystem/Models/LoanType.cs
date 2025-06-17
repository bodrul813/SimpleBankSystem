using System.ComponentModel.DataAnnotations;

namespace SimpleBankSystem.Models
{
    public class LoanType
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
