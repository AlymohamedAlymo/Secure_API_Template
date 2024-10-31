using System.ComponentModel.DataAnnotations;

namespace Secure_API_Template.Data.DTOs
{
    public class UserDTO
    {
        [Required]
        [StringLength(10, MinimumLength = 5)]
        public required string UserName { get; set; } = string.Empty;

        [Required]
        [StringLength(10, MinimumLength = 5)]
        public required string Password { get; set; } = string.Empty;

    }
}
