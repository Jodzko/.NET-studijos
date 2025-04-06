namespace _11_paskaita_JWT.Services
{
    public interface IJwtService
    {
        string GetJwtToken(string username, string role);
    }
}
