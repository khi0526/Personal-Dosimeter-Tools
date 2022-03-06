using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PersonalDosimeterTools.Calibration.Models;

public class ReferenceDosimeter
{
	public long Id { get; set; }
	public string IdentificationCode { get; set; } = null!;
	public DosimeterType Type { get; set; }
	public string? Nickname { get; set; }
	public double CalibrationValue { get; set; }

	public ICollection<MeasurementEnvironment> MeasurementEnvironments { get; } = new Collection<MeasurementEnvironment>();
}
