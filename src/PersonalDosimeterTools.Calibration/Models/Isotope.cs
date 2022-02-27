﻿namespace PersonalDosimeterTools.Calibration.Models;

public class Isotope
{
	public long Id { get; set; }
	public int AtomicNumber { get; set; }
	public string Symbol { get; set; }
	public int NeutronNumber { get; set; }
	public double HalfLife { get; set; }
}
