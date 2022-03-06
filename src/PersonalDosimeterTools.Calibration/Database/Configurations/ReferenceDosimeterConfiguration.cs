using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalDosimeterTools.Calibration.Models;

namespace PersonalDosimeterTools.Calibration.Database.Configurations;

internal class ReferenceDosimeterConfiguration : IEntityTypeConfiguration<ReferenceDosimeter>
{
	public void Configure(EntityTypeBuilder<ReferenceDosimeter> builder)
	{
		builder.HasIndex(d => d.IdentificationCode).IsUnique();
		builder.HasIndex(d => new { d.Type, d.IdentificationCode });

		builder.Property(d => d.CalibrationValue).HasDefaultValue(1);
	}
}
