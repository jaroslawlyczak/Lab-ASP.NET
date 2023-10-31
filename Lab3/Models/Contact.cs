using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(maximumLength: 50, ErrorMessage = "Name must be less than 50 characters")]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birth { get; set; }
       
    }
}
