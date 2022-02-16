using System.ComponentModel.DataAnnotations;

namespace Furever.Identity.Models.ViewModels
{
    public class ForgotPasswordModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
