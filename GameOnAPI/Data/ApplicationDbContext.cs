using GameOnAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static GameOnAPI.Models.User;

namespace GameOnAPI.Data
{
	public class ApplicationDbContext : IdentityDbContext<User>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		public DbSet<Match> Match { get; set; }
		public DbSet<User> User { get; set; }
		public DbSet<Field> Field { get; set; }
		public DbSet<MatchParticipation> MatchParticipation { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Match>()
		   .HasMany(match => match.Participations)
		   .WithOne(participation => participation.Match)
		   .OnDelete(DeleteBehavior.Cascade);


			modelBuilder.Entity<User>().ToTable("User");
			modelBuilder.Entity<IdentityRole<string>>().ToTable("Roles");
			modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");


			modelBuilder.Entity<User>().HasData(
				new User
				{
					Id = "324u3943583404",
					UserName = "Samer",
					Name = "Samer Shalabi",
					Email = "user1@example.com",
					position = Position.General_Midfielder,
					preferredFoot = PreferredFoot.Right,
					experienceLevel = ExperienceLevel.Professional,
					FavoriteTeam = "Liverpool",
					Height = 175.5,
					Weight = 70.3,
					Location = "Bchamoun",
					ProfileImageUrl = "profile1.jpg"
				},
				new User
				{
					Id = "32ewdewd83404",
					UserName = "Ali",
					Name = "Ali Hussein",
					Email = "user2@example.com",
					position = Position.Right_Back,
					preferredFoot = PreferredFoot.Left,
					experienceLevel = ExperienceLevel.Amateur,
					FavoriteTeam = "Barcelona",
					Height = 180.0,
					Weight = 75.2,
					Location = "Saida",
					ProfileImageUrl = "profile2.jpg"
				},
				new User
				{

					Id = "32322432nvfvfwdewd83404",
					UserName = "Omar",
					Name = "Omar Shalabi",
					Email = "user3@example.com",
					position = Position.Striker,
					preferredFoot = PreferredFoot.Right,
					experienceLevel = ExperienceLevel.Professional,
					FavoriteTeam = "Real Madrid",
					Height = 172.0,
					Weight = 68.5,
					Location = "Beirut",
					ProfileImageUrl = "profile3.jpg"
				}
				,
				new User
				{

					Id = "3232onffenmessi8marvfwdewd83404",
					UserName = "Hussein",
					Name = "Hussein Ali",
					Email = "user3@example.com",
					position = Position.Center_Back,
					preferredFoot = PreferredFoot.Right,
					experienceLevel = ExperienceLevel.Professional,
					FavoriteTeam = "Napoli",
					Height = 172.0,
					Weight = 68.5,
					Location = "Aramoun",
					ProfileImageUrl = "profile4.jpg"
				});
			modelBuilder.Entity<Match>().HasData(
				new Match
				{
					Id = 3,
					StartDateTime = DateTime.Now.AddDays(2),
					EndDateTime = DateTime.Now.AddDays(2).AddHours(3),
					DeadlineRequestsDateTime = DateTime.Now.AddHours(300),
					UserId = 1,
					FieldId = 3,
					PlayerCount = 8,
					Featured = true

				},
				new Match
				{
					Id = 2,
					StartDateTime = DateTime.Now.AddDays(3),
					EndDateTime = DateTime.Now.AddDays(3).AddHours(2),
					DeadlineRequestsDateTime = DateTime.Now.AddHours(200),
					FieldId = 2,
					UserId = 1,
					PlayerCount = 12,
					Featured = true,
				},
				new Match
				{
					Id = 1,
					StartDateTime = DateTime.Now.AddDays(4),
					EndDateTime = DateTime.Now.AddDays(4).AddHours(2),
					DeadlineRequestsDateTime = DateTime.Now.AddHours(120),
					FieldId = 1,
					UserId = 1,
					PlayerCount = 16,
					Featured = true
				}

			);

			modelBuilder.Entity<Field>().HasData(
				new Field
				{
					Id = 1,
					FieldName = "AllSports",
					FieldImage = "https://assets.rappler.com/6677C2B68AF94FD1BD758C065AC43A07/img/43648E3295544C6A8EF16B42BDF2F6D6/6.jpg",
					Location = "Bchamoun"
				},

				new Field
				{
					Id = 2,
					FieldName = "GreenField",
					FieldImage = "https://th.bing.com/th/id/R.59f002d1a5d3dae68612a521fb245ffe?rik=2Z9vdMR9H5Ni9g&riu=http%3a%2f%2fwww.artificialturf-grass.com%2fphoto%2fpl11353642-durable_false_turf_playground_soccer_synthetic_grass_environment_friendly.jpg&ehk=z4WhEwLG8xnj49JE3nraLCVHEmerkxdcLha7MK9qDjY%3d&risl=&pid=ImgRaw&r=0",
					Location = "Aley"
				},

				new Field
				{
					Id = 3,
					FieldName = "KasKas",
					FieldImage = "https://th.bing.com/th/id/OIP.WNQW57IvkqWmB7lcL08MMgHaE7?pid=ImgDet&w=207&h=138&c=7",
					Location = "Beirut"
				}
				);

			modelBuilder.Entity<MatchParticipation>().HasData(
				new MatchParticipation
				{
					Id = 1,
					UserId = "3232onffenmessi8marvfwdewd83404",
					MatchId=1,
					position=Position.Left_Back,
					TeamPlayingFor=Team.Team1,

				},
				new MatchParticipation
				{
					Id = 2,
					UserId = "32ewdewd83404",
					MatchId = 1,
					position = Position.Striker,
					TeamPlayingFor = Team.Team2,

				}
				);

			ConfigureUserRolesKey(modelBuilder);
		}

		private void ConfigureUserRolesKey(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<IdentityUserRole<string>>()
				.HasKey(ur => new { ur.UserId, ur.RoleId });
		}

	} 
}
