using GymSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSystem.Configuration
{
	public class TrainerConfig: GymUserConfig<Trainer>,IEntityTypeConfiguration<Trainer>
	{
		public new void Configure(EntityTypeBuilder<Trainer> builder)
		{
			builder.Property(m => m.CreatAt).HasColumnName("HireDate").HasDefaultValueSql("GetDate()");

			base.Configure(builder);
		}
	}
}
