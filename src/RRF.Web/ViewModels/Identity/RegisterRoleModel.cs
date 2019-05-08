using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RRF.Web.ViewModels.Identity
{
    public class RegisterRoleModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Confirm Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Role")]
        public string Role { get; set; }

        public List<SelectListItem> Roles { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "Owner", Text = "Owner/Renter" },
            new SelectListItem { Value = "Broker", Text = "Broker" },
            new SelectListItem { Value = "Personal", Text = "Personal"  },
        };
    }
}