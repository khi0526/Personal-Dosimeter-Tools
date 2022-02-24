using System;

namespace PersonalDosimeterTools;

internal class Program
{
	[STAThread]
	public static void Main()
	{
		var app = new App();
		app.InitializeComponent();
		app.Run();
	}
}
