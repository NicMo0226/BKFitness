using System.ComponentModel.DataAnnotations;

namespace BKFitness.ViewModels.Account.User
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType (DataType.Password)]
        public string Password { get; set; }

        [Display (Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}