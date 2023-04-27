using System;
namespace InterfaceExercise
{
	public class Car : IVehicle , ICompany
	{
		public Car()
		{
		}

        public bool HasDropTop { get; set; }

		public bool HeatSeats { get; set; }


        public bool NeedsGas {get; set; }
        public int PassengerSeats { get; set; }
        public string CarColor { get; set; }
        public double CarMileage { get; set; }
        public string Logo { get; set; }
        public string CompanyCulture { get; set; }

        public void Drive()
        {
            Console.WriteLine("This car drives very nicely!");
        }

        public void Park()
        {
            Console.WriteLine("You would want to park with no one will hit it.");
        }

        public void Reverse()
        {
            Console.WriteLine("The reverse camera is the best will backing up.");
        }
    }
}

