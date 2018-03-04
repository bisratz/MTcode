using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Address
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@contoso.edu")]
        public string Email { get; set; }
    }
}