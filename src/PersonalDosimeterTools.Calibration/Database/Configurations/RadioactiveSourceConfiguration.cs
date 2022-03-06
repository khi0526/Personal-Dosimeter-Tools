﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalDosimeterTools.Calibration.Models;

namespace PersonalDosimeterTools.Calibration.Database.Configurations;

internal class RadioactiveSourceConfiguration : IEntityTypeConfiguration<RadioactiveSource>
{
	public void Configure(EntityTypeBuilder<RadioactiveSource> builder)
	{
		builder.Property(s => s.ReferenceDate)
			.HasConversion(dto => dto.ToUnixTimeSeconds(), sec => DateTimeOffset.FromUnixTimeSeconds(sec));
	}
}
