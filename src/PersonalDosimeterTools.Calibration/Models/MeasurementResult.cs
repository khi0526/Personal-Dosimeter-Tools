using System.Collections.Generic;

namespace PersonalDosimeterTools.Calibration.Models;

public class MeasurementResult
{
	public long Id { get; set; }
	public MeasurementEnvironment Environment { get; set; }
	public string DosimeterName { get; set; }
	public double Average { get; set; }
	public double StandardDeviation { get; set; }
	public byte[] CpsesBinary { get; set; }
}
