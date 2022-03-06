using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PersonalDosimeterTools.Calibration.Models;

public class Isotope
{
	public long Id { get; set; }
	public int AtomicNumber { get; set; }
	public string Symbol { get; set; } = null!;
	public int NeutronNumber { get; set; }
	public double HalfLife { get; set; }

	public ICollection<RadioactiveSource> RadioactiveSources { get; } = new Collection<RadioactiveSource>();
}
