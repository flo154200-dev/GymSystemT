using GymSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSystem.Configuration
{
	public class SessionConfig : IEntityTypeConfiguration<Session>
	{
		public void Configure(EntityTypeBuilder<Session> builder)
		{
			builder.Property(m => m.CreatAt).HasColumnName("HireDate").HasDefaultValueSql("GetDate()");

			builder.ToTable(t =>
			{
				t.HasCheckConstraint("CheckCapacity", "Capacity between 1 and 25");
				t.HasCheckConstraint("CheckEndDate", "EndDate > StartDate ");

			});
			builder.HasOne(s => s.Trainer).WithMany(s => s.Sessions).HasForeignKey(s => s.TrainerId).OnDelete(DeleteBehavior.Restrict);
		}
	}
}
