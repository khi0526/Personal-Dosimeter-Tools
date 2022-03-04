using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PersonalDosimeterTools.Calibration.Models;

public class RadioactiveSource
{
	public long Id { get; set; }
	public Isotope Isotope { get; set; }
	public DateTimeOffset ReferenceDate { get; set; }
	public double Activity { get; set; }

	public ICollection<MeasurementEnvironment> MeasurementEnvironments { get; } = new ObservableCollection<MeasurementEnvironment>();
}
