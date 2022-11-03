using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuthentication.Controllers
{
	// TODO:
	public class TestController : Controller
	{
		// TODO:
		[HttpGet("first")]
		public string First()
		{
			return "Hello World from First";
		}

		// TODO:
		[HttpGet("second")]
		public string Second()
		{
			return "Hello World from Second";
		}

	}
}
