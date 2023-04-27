using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE Create 2 Interfaces called IVehicle & ICompany

            //DONE Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* DONE Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*DONE Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*DONE Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * DONE Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;

            var lexus = new Car();

            lexus.CarColor = "Black";
            lexus.CarMileage = 9399.9;
            lexus.PassengerSeats = 2;
            lexus.Logo = "Circled L";
            lexus.NeedsGas = true;
            lexus.HasDropTop = true;
            lexus.HeatSeats = true;
            lexus.Drive();
            lexus.Park();
            lexus.Reverse();
            lexus.CompanyCulture = "Luxury like";

            Console.WriteLine("--------------------------------------------");

            var truck = new Truck();
            truck.HasBed = true;
            truck.TypeofCargo = "Dog food";
            truck.PassengerSeats = 2;
            truck.NeedsGas = false;
            truck.Logo = "Ford";
            truck.CarColor = "Red";
            truck.CarMileage = 150045791.5;
            truck.Drive();
            truck.Park();
            truck.Reverse();
            truck.CompanyCulture = "The standard.";

            Console.WriteLine("------------------------------------------");

            var infiniti = new SUV();
            infiniti.CarColor = "Silver";
            infiniti.CarMileage = 15000.5;
            infiniti.Logo = "The infinity sign";
            infiniti.PassengerSeats = 7;
            infiniti.NeedsGas = true;
            infiniti.NumberofTvs = 4;
            infiniti.TrunkSpace = 16.6;
            infiniti.Drive();
            infiniti.Park();
            infiniti.Reverse();
            infiniti.CompanyCulture = "Top of the line.";

            Console.WriteLine("---------------------------------------");

            var vehicles = new List<IVehicle>() { infiniti, truck, lexus };

            foreach(var vehicle in vehicles)
            {
                Console.WriteLine();
            }

            //Creatively display and organize their values
        }
    }
}
