using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PersonalDosimeterTools.Calibration.Models;

public class MeasurementEnvironment
{
	public long Id { get; set; }
	public long RadioactiveSourceId { get; set; }
	public long? ReferenceDosimeterId { get; set; }
	public DateTimeOffset BeginDate { get; set; }
	public int Period { get; set; }
	public double Distance { get; set; }

	public RadioactiveSource RadioactiveSource { get; set; }
	public ReferenceDosimeter ReferenceDosimeter { get; set; }
	public ICollection<MeasurementResult> MeasurementResults { get; } = new ObservableCollection<MeasurementResult>();
}
