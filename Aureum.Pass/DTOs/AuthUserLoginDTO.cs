using System.ComponentModel.DataAnnotations;

namespace Aureum.Pass.DTOs
{
    public record AuthUserLoginDTO
    {
        [Required]
        public string UserName {  get; init; }
        [Required]
        public string Password { get; init; }
    }
}
