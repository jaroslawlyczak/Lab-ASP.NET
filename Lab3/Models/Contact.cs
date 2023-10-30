using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required] (ErrorMessage = "Please enter your name")]
            [StringLenght(maximumLenght: 50, ErrorMessage = "Name must be less than 50 characters")]
        public string Name { get; set; }
        [EmailAdress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public int ID { get; internal set; }
    }
}
