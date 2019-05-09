using System.ComponentModel.DataAnnotations;

namespace RRF.API.ViewModels.Identity
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}