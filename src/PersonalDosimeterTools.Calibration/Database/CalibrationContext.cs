using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using PersonalDosimeterTools.Calibration.Database.Configurations;
using PersonalDosimeterTools.Calibration.Models;

namespace PersonalDosimeterTools.Calibration.Database;

public class CalibrationContext : DbContext
{
	public DbSet<Isotope> Isotopes => Set<Isotope>();
	public DbSet<RadioactiveSource> RadioactiveSources => Set<RadioactiveSource>();
	public DbSet<MeasurementEnvironment> MeasurementEnvironments => Set<MeasurementEnvironment>();
	public DbSet<MeasurementResult> MeasurementResults => Set<MeasurementResult>();
	public DbSet<ReferenceDosimeter> ReferenceDosimeters => Set<ReferenceDosimeter>();

	public CalibrationContext(DbContextOptions<CalibrationContext> options)
		: base(options)
	{
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder
			.ApplyConfiguration(new IsotopeConfiguration())
			.ApplyConfiguration(new RadioactiveSourceConfiguration())
			.ApplyConfiguration(new ReferenceDosimeterConfiguration())
			.ApplyConfiguration(new MeasurementEnvironmentConfiguration())
			.ApplyConfiguration(new MeasurementResultConfiguration());
	}
}
