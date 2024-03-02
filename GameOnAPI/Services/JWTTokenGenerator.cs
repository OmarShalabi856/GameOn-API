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
	public class jwtTokenGenerator : IjwtTokenGenerator
	{
		private readonly JWTOptions _options;

		public jwtTokenGenerator(IOptions<JWTOptions> options)
		{
			_options = options.Value;

		}
		public string GenerateToken(User user, List<string> roles)
		{
			try
			{
				var tokenHadler = new JwtSecurityTokenHandler();

				var key = Encoding.ASCII.GetBytes(_options.secret);
				var claims = new List<Claim>()
			{
				new Claim(ClaimTypes.Email,user?.Email),
			};


				var tokenDescriptor = new SecurityTokenDescriptor
				{
					Audience = _options.audience,
					Issuer = _options.issuer,
					Subject = new ClaimsIdentity(claims),
					Expires = DateTime.UtcNow.AddMinutes(10),
					SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
				};

				var token = tokenHadler.CreateToken(tokenDescriptor);
				return tokenHadler.WriteToken(token).ToString();
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
				return string.Empty;	
			}
		}
	}
}
