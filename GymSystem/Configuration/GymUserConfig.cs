using System.ComponentModel.DataAnnotations;
using GymSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSystem.Configuration
{
	public class GymUserConfig<T> : IEntityTypeConfiguration<T> where T : GymUser
	{
		public void Configure(EntityTypeBuilder<T> builder)
		{
			builder.Property(g => g.Name).HasMaxLength(50).HasColumnType("varchar");
			builder.Property(g => g.Phone).HasMaxLength(11).HasColumnType("varchar");
			builder.HasIndex(g => g.Phone).IsUnique();
			builder.Property(g => g.Email).HasMaxLength(100);
			builder.HasIndex(g => g.Email).IsUnique();
			builder.ToTable(t =>
			{
				t.HasCheckConstraint("EmailCheck", " Email Like '_%._%_'");
				t.HasCheckConstraint("PhoneCkeck", "Phon Like '010%' OR Phon Like '011%' OR Phon Like  '012%' OR Phon Like '015%'");

			});
		}
	}
}
