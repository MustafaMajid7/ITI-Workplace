using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Day1.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountController : ControllerBase
	{
		[HttpPost]
		public ActionResult Login(string username,string password)
		{
            if (username != "admin" || password!="123")
				return Unauthorized();

			Claim user = new Claim(ClaimTypes.Name, username);
			Claim pass = new Claim(ClaimTypes.Name, password);
			Claim[] data = new Claim[]{user,pass};

			string secretKey = "hello my friend my name is mostafa";

			var SKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secretKey));
			
			var singcred = new SigningCredentials(SKey,SecurityAlgorithms.HmacSha256);

			var token = new JwtSecurityToken(
				claims: data,
				signingCredentials: singcred,
				expires:DateTime.Now.AddDays(1));
			var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

			return Ok(tokenString);

		}
	}
}
