using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PersonalDosimeterTools.Calibration.Models;

public class MeasurementEnvironment
{
	public long Id { get; set; }
	public RadioactiveSource RadioactiveSource { get; set; } = null!;
	public ReferenceDosimeter ReferenceDosimeter { get; set; } = null!;
	public DateTimeOffset BeginDate { get; set; }
	public int Period { get; set; }
	public double Distance { get; set; }

	public ICollection<MeasurementResult> MeasurementResults { get; } = new Collection<MeasurementResult>();
}
