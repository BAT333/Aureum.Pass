namespace Aureum.Pass.DTOs
{
    public record DataTokenDTO
    {
        public string Token { get; init; }

        public DataTokenDTO(string token)
        {
            this.Token = token;
        }
    }
}
