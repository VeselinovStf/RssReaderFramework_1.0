using System.ComponentModel.DataAnnotations;

namespace RRF.Web.ViewModels.Identity
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}