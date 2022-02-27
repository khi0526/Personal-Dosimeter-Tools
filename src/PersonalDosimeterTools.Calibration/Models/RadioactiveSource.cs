using System;

namespace PersonalDosimeterTools.Calibration.Models;

public class RadioactiveSource
{
	public long Id { get; set; }
	public long IsotopeId { get; set; }
	public DateTimeOffset ReferenceDate { get; set; }
	public double Activity { get; set; }

	public Isotope Isotope { get; set; }
}
