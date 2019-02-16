using System.ComponentModel.DataAnnotations;

namespace BKFitness.ViewModels.Account.User {
    public class RegisterViewModel {
        
        [Required]
        [Display (Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display (Name = "Surname")]
        public string LastName { get; set; }

        [Required, EmailAddress, MaxLength (256), Display (Name = "Email Address")]
        public string Email { get; set; }

        [Required, MinLength (8), MaxLength (15), DataType (DataType.Password), Display (Name = "Password")]
        public string Password { get; set; }

        [Required, MinLength (8), MaxLength (15), DataType (DataType.Password), Display (Name = "Confirm Password")]
        [Compare ("Password", ErrorMessage = "The password does not match the confirmation password")]
        public string ConfirmPassword { get; set; }
    }
}