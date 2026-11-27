using GymSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSystem.Configuration
{
	public class PlanConfig :  IEntityTypeConfiguration<Plans>
	{
		public void Configure(EntityTypeBuilder<Plans> builder)
		{
			builder.Property(p => p.CreatAt).HasDefaultValueSql("GetDate()");
			builder.ToTable(t =>
			{
				t.HasCheckConstraint("CheckDurationDays", "DurationDays between 1 and 365");
				

			}

			);
		}
	}
}
