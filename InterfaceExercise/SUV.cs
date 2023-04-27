using System;
namespace InterfaceExercise
{
	public class SUV : IVehicle, ICompany
	{
		public SUV()
		{
		}

		public int NumberofTvs { get; set; }
		public double TrunkSpace { get; set; }

        public bool NeedsGas { get; set; }
        public int PassengerSeats { get; set; }
        public string CarColor { get; set; }
        public double CarMileage { get; set; }
        public string Logo { get; set; }
        public string CompanyCulture { get; set; }

        public void Drive()
        {
            Console.WriteLine("It takes up a lot of gas.");
            
        }

        public void Park()
        {
            Console.WriteLine("It's cheaper than driving.");
            
        }

        public void Reverse()
        {
            Console.WriteLine("It beeps loud when it thinks about to hit someone.");
        }
    }
}

