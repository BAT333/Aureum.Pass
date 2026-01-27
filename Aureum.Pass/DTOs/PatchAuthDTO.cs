using System.ComponentModel.DataAnnotations;

namespace Aureum.Pass.DTOs
{
    public class PatchAuthDTO
    {

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; init; }

        [Required]
        [Compare("password")]
        public string RePassword { get; init; }
    }
}
