using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalDosimeterTools.Calibration.Models;

namespace PersonalDosimeterTools.Calibration.Database.Configurations;

internal class MeasurementEnvironmentConfiguration : IEntityTypeConfiguration<MeasurementEnvironment>
{
	public void Configure(EntityTypeBuilder<MeasurementEnvironment> builder)
	{
		builder.Property(e => e.BeginDate)
			.HasConversion(dto => dto.ToUnixTimeSeconds(), sec => DateTimeOffset.FromUnixTimeSeconds(sec));

	}
}
