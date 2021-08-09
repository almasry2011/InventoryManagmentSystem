using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Domain.Auth
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
