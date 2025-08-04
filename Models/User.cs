using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [MinLength(3, ErrorMessage = "First Name Min Length Is 3")]
        [MaxLength(15, ErrorMessage = "First Name Max Length Is 15")]
        [DisplayName("First Name")]
        public required string FirstName { get; set; }
        [MinLength(3, ErrorMessage = "Last Name Min Length Is 3")]
        [MaxLength(15, ErrorMessage = "Last Name Max Length Is 15")]
        [DisplayName("Last Name")]
        public required string LastName { get; set; }
        [EmailAddress(ErrorMessage = "Please Enter A Valid Email")]
        [StringLength(100, ErrorMessage = "Email Must Be Between 4 and 100", MinimumLength = 4)]
        public required string Email { get; set; }
        [MaxLength(30, ErrorMessage = "Password Max Length Is 30")]
        [MinLength(8, ErrorMessage = "Password Min Length Is 8")]
        [Required(ErrorMessage = "Password Is Required")]
        [DataType(DataType.Password)]
        public required string Password { get; set; }
        [NotMapped]
        [MaxLength(30, ErrorMessage = "Confirm Password Max Length Is 30")]
        [MinLength(8, ErrorMessage = "Confirm Password Min Length Is 8")]
        [Required(ErrorMessage = "Confirm Password Is Required")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password Not Match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}
