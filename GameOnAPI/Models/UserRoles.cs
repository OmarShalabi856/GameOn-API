using GameOnAPI.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using static GameOnAPI.Services.AuthService;

public class UserRoles: IdentityUserRole<string>
{
	[NotMapped]
	public User User { get; set; }
	public IdentityRole Role { get; set; }
}
