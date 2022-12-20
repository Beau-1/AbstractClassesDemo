using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
		
		public int Year { get; set; } = 1;
		public string Make { get; set; } = "";
		public string Model { get; set; } = "";

		public abstract void DriveAbstract();

		public virtual void DriveVirtual()
		{
			Console.WriteLine($"This {GetType().Name} is virtually in drive");
		}
	}
}

