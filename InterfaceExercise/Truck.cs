using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
	{
		public Truck()
		{
		}

		public bool HasBed { get; set; }
		public string TypeofCargo { get; set; }

        public bool NeedsGas { get; set; }
        public int PassengerSeats { get; set; }
        public string CarColor { get; set; }
        public double CarMileage { get; set; }
        public string Logo { get; set; }
        public string CompanyCulture { get; set; }

        public void Drive()
        {
            Console.WriteLine("Tends to make wide turns.");
        }

        public void Park()
        {
            Console.WriteLine("Can't just park anywhere.It takes up a lot of space.");
        }

        public void Reverse()
        {
            Console.WriteLine("Requires a lot of focus and patience.");
        }
    }
}

