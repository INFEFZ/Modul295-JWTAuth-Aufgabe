namespace JWTAuthentication.Services
{
	public interface ITokenService
	{
		string CreateToken(string username);
	}
}
