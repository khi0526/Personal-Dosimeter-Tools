using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalDosimeterTools.Calibration.Models;

namespace PersonalDosimeterTools.Calibration.Database.Configurations;

internal class IsotopeConfiguration : IEntityTypeConfiguration<Isotope>
{
	public void Configure(EntityTypeBuilder<Isotope> builder)
	{
		builder.HasIndex(i => new { i.AtomicNumber, i.NeutronNumber }).IsUnique();
	}
}
