using GameOnAPI.Models;
using System.Text;
using System.Security.Claims;
using Microsoft.IdentityModel.JsonWebTokens;
using GameOnAPI.DTOs;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;
using Microsoft.Extensions.Options;

namespace GameOnAPI.Services
{
	public class JWTTokenGenerator : IJWTTokenGenerator
	{
		private readonly JWTOptions _options;
		public JWTTokenGenerator(IOptions<JWTOptions> options)
		{
			_options = options.Value;

		}
		public string GenerateToken(LoginUser user)
		{
			var tokenHadler = new JwtSecurityTokenHandler();

			var key = Encoding.ASCII.GetBytes(_options.secret);
			var claimList = new List<Claim>()
			{
				new Claim(JwtRegisteredClaimNames.Email,user.Email),
			};

			var tokenDescriptor = new SecurityTokenDescriptor
			{
				Audience = _options.audience,
				Issuer = _options.issuer,
				Subject = new ClaimsIdentity(claimList),
				Expires = DateTime.UtcNow.AddDays(3),
				SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
			};

			var token = tokenHadler.CreateToken(tokenDescriptor);
			return tokenHadler.WriteToken(token).ToString();
		}

	}
}
