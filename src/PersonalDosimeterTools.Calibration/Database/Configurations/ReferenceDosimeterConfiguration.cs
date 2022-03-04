using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalDosimeterTools.Calibration.Models;

namespace PersonalDosimeterTools.Calibration.Database.Configurations;

internal class ReferenceDosimeterConfiguration : IEntityTypeConfiguration<ReferenceDosimeter>
{
	public void Configure(EntityTypeBuilder<ReferenceDosimeter> builder)
	{
		builder.Property(d => d.Id)
			.HasColumnOrder(0)
			.HasColumnType("INTEGER")
			.IsRequired();

		builder.Property(d => d.Type)
			.HasColumnOrder(1)
			.HasColumnType("TEXT")
			.IsRequired();

		builder.Property(d => d.IdentificationCode)
			.HasColumnOrder(2)
			.HasColumnType("TEXT")
			.IsRequired();
		builder.HasIndex(d => d.IdentificationCode)
			.IsUnique();
		builder.HasIndex(d => new { d.Type, d.IdentificationCode });

		builder.Property(d => d.Nickname)
			.HasColumnOrder(3)
			.HasColumnType("TEXT");

		builder.Property(d => d.CalibrationValue)
			.HasColumnOrder(4)
			.HasColumnType("REAL")
			.HasDefaultValue(1)
			.IsRequired();
	}
}
