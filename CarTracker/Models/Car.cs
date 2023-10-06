using System;
namespace CarTracker.Models
{
	public class Car
	{
		public int Id { get; set; }
		public string VIN { get; set; }
		public string RegistrationNumber { get; set; }
		public string Brand { get; set; }
		public string Model { get; set; }
		public string ProductionYear { get; set; }
		public string Fuel { get; set; }
	}
}

