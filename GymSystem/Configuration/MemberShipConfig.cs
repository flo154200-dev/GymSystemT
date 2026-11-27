using GymSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSystem.Configuration
{
	public class MemberShipConfig : IEntityTypeConfiguration<MemberShip>
	{
		public void Configure(EntityTypeBuilder<MemberShip> builder)
		{
			builder.HasKey(m => m.Id);
			builder.Property(p => p.CreatAt).HasDefaultValueSql("GetDate()");
			builder.HasOne(m => m.Member).WithMany(m => m.MemberShip).HasForeignKey(m => m.MemberId).OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(m => m.Plans).WithMany(m => m.MemberShip).HasForeignKey(m => m.PlaneId).OnDelete(DeleteBehavior.Restrict);

		}
	}
}
