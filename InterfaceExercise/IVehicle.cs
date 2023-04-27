using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
		public bool NeedsGas { get; set; }
		public int PassengerSeats { get; set; }
		public string CarColor { get; set; }
		public double CarMileage { get; set; }

		public void Drive();
		public void Reverse();
		public void Park();
	}
}

