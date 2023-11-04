using GameOnAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameOnAPI.Data
{
	public class ApplicationDbContext: IdentityDbContext<User>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		public DbSet<Match> Match { get; set; }
		public DbSet<User> User { get; set; }
		public DbSet<MatchParticipation> MatchParticipation { get; set; }
	}
}
