using System.ComponentModel.DataAnnotations;

namespace Aureum.Pass.DTOs
{
    public record PutAuthDTO
    {
        [Required]
        public string UserName { get; init; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; init; }

        [Required]
        [Compare("password")]
        public string RePassword { get; init; }
    }
}
