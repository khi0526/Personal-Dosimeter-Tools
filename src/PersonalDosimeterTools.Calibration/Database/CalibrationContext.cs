using Microsoft.EntityFrameworkCore;
using PersonalDosimeterTools.Calibration.Models;

namespace PersonalDosimeterTools.Calibration.Database;

public class CalibrationContext : DbContext
{
	private readonly string _path;
	public DbSet<Isotope> Isotopes { get; set; }
	public DbSet<RadioactiveSource> RadioactiveSources { get; set; }
	public DbSet<MeasurementEnvironment> MeasurementEnvironments { get; set; }
	public DbSet<MeasurementResult> MeasurementResults { get; set; }
	public DbSet<ReferenceDosimeter> ReferenceDosimeters { get; set; }

	public CalibrationContext(string path)
	{
		_path = path;
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		=> optionsBuilder.UseSqlite($"Data Source={_path}");

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		
	}
}
