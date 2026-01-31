using System.ComponentModel.DataAnnotations;

namespace Aureum.Pass.DTOs
{
    public record CreateUserDTO
    {
        [Required]
        public string UserName { get; init; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; init; }

        [Required]
        [Compare("Password")]
        public string RePassword { get; init; }


    }
}
