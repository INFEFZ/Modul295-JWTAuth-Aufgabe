using JWTAuthentication.Models;
using JWTAuthentication.Services;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuthentication.Controllers
{
	// TODO:
	public class AccountController : ControllerBase
	{
		private readonly ITokenService _tokenService;
		public AccountController(ITokenService tokenService)
		{
			_tokenService = tokenService;
		}

		[HttpPost("login")]
		public IActionResult Login(/*TODO:*/ AuthenticateUser model)
		{
			if (model.Username != "admin" /*TODO:*/)
				return Unauthorized("Invalid Credentials");
			else
				return new JsonResult(new { userName = model.Username, token = _tokenService.CreateToken(model.Username) });
		}
	}
}
