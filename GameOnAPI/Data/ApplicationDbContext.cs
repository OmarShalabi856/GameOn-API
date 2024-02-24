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

		public DbSet<Invitation> Invitation { get; set; }

		public DbSet<Notification> Notification { get; set; }

		public DbSet<NotificationUser> NotificationUser { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Match>()
		   .HasMany(match => match.Participations)
		   .WithOne(participation => participation.Match)
		   .OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<Invitation>()
			.HasOne(invitation => invitation.MatchCaptain)
			.WithMany()
			.HasForeignKey(invitation => invitation.MatchCaptainId);

			modelBuilder.Entity<Invitation>()
				.HasOne(invitation => invitation.InvitedPlayer)
				.WithMany()
				.HasForeignKey(invitation => invitation.InvitedPlayerId);

			modelBuilder.Entity<Match>()
			.HasOne(match => match.TeamOneCaptain)
			.WithMany()
			.HasForeignKey(match => match.TeamOneCaptainId)
			.OnDelete(DeleteBehavior.NoAction);

			modelBuilder.Entity<Match>()
			.HasOne(match => match.TeamTwoCaptain)
			.WithMany()
			.HasForeignKey(match => match.TeamTwoCaptainId)
			.OnDelete(DeleteBehavior.NoAction);


			modelBuilder.Entity<User>().ToTable("User");
			modelBuilder.Entity<IdentityRole<string>>().ToTable("Roles");
			modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");

			modelBuilder.Entity<User>()
			.HasMany(user => user.Invitations)
			.WithOne(invitation => invitation.MatchCaptain)
			.HasForeignKey(invitation => invitation.MatchCaptainId)
			.OnDelete(DeleteBehavior.Restrict);

			modelBuilder.Entity<Notification>()
				.HasOne(n => n.SendingUser)
				.WithMany()
				.HasForeignKey(n => n.SendingUserId)
				.OnDelete(DeleteBehavior.Restrict);  // Or use DeleteBehavior.Cascade if needed

			

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



			ConfigureUserRolesKey(modelBuilder);
		}

		private void ConfigureUserRolesKey(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<IdentityUserRole<string>>()
				.HasKey(ur => new { ur.UserId, ur.RoleId });
		}

	}
}
