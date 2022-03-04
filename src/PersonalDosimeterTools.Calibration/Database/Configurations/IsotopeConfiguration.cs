using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalDosimeterTools.Calibration.Models;

namespace PersonalDosimeterTools.Calibration.Database.Configurations;

internal class IsotopeConfiguration : IEntityTypeConfiguration<Isotope>
{
	public void Configure(EntityTypeBuilder<Isotope> builder)
	{
		builder.Property(i => i.Id)
			.HasColumnOrder(0)
			.HasColumnType("INTEGER")
			.IsRequired();

		builder.Property(i => i.AtomicNumber)
			.HasColumnOrder(1)
			.HasColumnType("INTEGER")
			.IsRequired();

		builder.Property(i => i.Symbol)
			.HasColumnOrder(2)
			.HasColumnType("TEXT")
			.IsRequired();

		builder.Property(i => i.NeutronNumber)
			.HasColumnOrder(3)
			.HasColumnType("INTEGER")
			.IsRequired();

		builder.Property(i => i.HalfLife)
			.HasColumnOrder(4)
			.HasColumnType("REAL")
			.IsRequired();

		builder.HasIndex(i => new { i.AtomicNumber, i.NeutronNumber })
			.IsUnique();
	}
}
