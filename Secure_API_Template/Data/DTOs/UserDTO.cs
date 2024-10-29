using System.ComponentModel.DataAnnotations;

namespace Secure_API_Template.Data.DTOs
{
    public class UserDTO
    {
        [Required]
        //[MaxLength(100)]
        public required string UserName { get; set; }

        [Required]
        public required string Password { get; set; }

    }
}
