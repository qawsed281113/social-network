namespace UsersService.Configuration
{
    public class AuthOptions
    {
        public string? TokenSecret { get; set; }
        public string? RefreshTokenSecret { get; set; }
        public string? TokenExpire { get; set; }
        public string? RefreshTokenExpire { get; set; }
        public string? Issuer { get; set; }
        public string? Audience { get; set; }

        public AuthOptions(IConfiguration configuration)
        {
            configuration.GetSection("JWT").Bind(this);
        }
    }
}