namespace Aureum.Pass.DTOs
{
    public record ReadAuthDTO
    {
        public long Id { get; init; }
        public string UserName { get; init; }
    }
}
