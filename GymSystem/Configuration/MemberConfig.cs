using GymSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSystem.Configuration
{
	public class MemberConfig : GymUserConfig<Member>, IEntityTypeConfiguration<Member>
	{
		public new void Configure(EntityTypeBuilder<Member> builder)
		{
			builder.Property(m => m.CreatAt).HasColumnName("JoinDate").HasDefaultValueSql("GetDate()");
			base.Configure(builder);
		}
	}
}
