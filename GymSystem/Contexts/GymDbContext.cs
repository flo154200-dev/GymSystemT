using System.Reflection;
using GymSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace GymSystem.Contexts
{
	public class GymDbContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server =. ;Database = GymDataBase;Trusted_Connection = true;TrustServerCertificate=True");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetEntryAssembly());
		}
		public  DbSet<Trainer> Trainers { get; set; }
		public  DbSet<Member> Members { get; set; }
		public  DbSet<Plans> Plans { get; set; }
		public  DbSet<Session> Sessions { get; set; }
		public DbSet<MemberShip> MemberShips { get; set; }
	}
}
