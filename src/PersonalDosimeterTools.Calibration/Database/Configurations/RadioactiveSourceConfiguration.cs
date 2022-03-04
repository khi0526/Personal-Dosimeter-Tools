using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalDosimeterTools.Calibration.Models;

namespace PersonalDosimeterTools.Calibration.Database.Configurations;

internal class RadioactiveSourceConfiguration : IEntityTypeConfiguration<RadioactiveSource>
{
	public void Configure(EntityTypeBuilder<RadioactiveSource> builder)
	{
		builder.Property(s => s.Id)
			.HasColumnOrder(0)
			.HasColumnType("INTEGER")
			.IsRequired();

		builder.Property<long>("IsotopeId")
			.HasColumnOrder(1)
			.HasColumnType("INTEGER")
			.IsRequired();
		builder
			.HasOne(s => s.Isotope)
			.WithMany(i => i.RadioactiveSources)
			.HasForeignKey("IsotopeId");

		builder.Property(s => s.ReferenceDate)
			.HasColumnOrder(2)
			.HasColumnType("INTEGER")
			.HasConversion(dto => dto.ToUnixTimeSeconds(), sec => DateTimeOffset.FromUnixTimeSeconds(sec))
			.IsRequired();

		builder.Property(s => s.Activity)
			.HasColumnOrder(3)
			.HasColumnType("REAL")
			.IsRequired();
	}
}
