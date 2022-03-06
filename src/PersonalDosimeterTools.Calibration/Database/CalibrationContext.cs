using Microsoft.EntityFrameworkCore;
using PersonalDosimeterTools.Calibration.Database.Configurations;
using PersonalDosimeterTools.Calibration.Models;

namespace PersonalDosimeterTools.Calibration.Database;

public class CalibrationContext : DbContext
{
	private readonly string _path;

	public DbSet<Isotope> Isotopes => Set<Isotope>();
	public DbSet<RadioactiveSource> RadioactiveSources => Set<RadioactiveSource>();
	public DbSet<MeasurementEnvironment> MeasurementEnvironments => Set<MeasurementEnvironment>();
	public DbSet<MeasurementResult> MeasurementResults => Set<MeasurementResult>();
	public DbSet<ReferenceDosimeter> ReferenceDosimeters => Set<ReferenceDosimeter>();

	public CalibrationContext(string path)
	{
		_path = path;
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		=> optionsBuilder.UseSqlite($"Data Source={_path}");

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
