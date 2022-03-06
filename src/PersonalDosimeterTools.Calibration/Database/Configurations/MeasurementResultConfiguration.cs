using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalDosimeterTools.Calibration.Models;

namespace PersonalDosimeterTools.Calibration.Database.Configurations;

internal class MeasurementResultConfiguration : IEntityTypeConfiguration<MeasurementResult>
{
	public void Configure(EntityTypeBuilder<MeasurementResult> builder)
	{
		builder.HasIndex(nameof(MeasurementResult.DosimeterName), "EnvironmentId");
		builder.HasIndex("EnvironmentId", nameof(MeasurementResult.DosimeterName));
	}
}
