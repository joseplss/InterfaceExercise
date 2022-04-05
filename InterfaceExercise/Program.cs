using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany-DONE

            //Create 3 classes called Car , Truck , & SUV-DONE


            //In your IVehicle-DONE

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany-DONE

            /*Create 2 members that are specific to each every company-DONE
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var sedan = new Car()
            {
                HasTrunk = true,
                HasLeatherSeats = true,
                HasSteering = true,
                HowManyWheels = 4,
                HasStereo = true,
                HasSunroof = false,
                Name = "Honda Accord",
                CorpName = "Toyota",
                Motto = "Best Brand Ever"

            };
            var truck = new Truck()
            {
                HasTruckBed = true,
                HasTowHook = true,
                HasSteering = true,
                HowManyWheels = 4,
                HasStereo = false,
                HasSunroof = false,
                Name = "Ford F-150",
                CorpName = "Landscapers Inc",
                Motto = "Trees"
            };
            var SUV = new SUV()
            {
                HasCargo = true,
                FourWheelDrive = true,
                HasSteering = true,
                HowManyWheels = 4,
                HasStereo = true,
                HasSunroof = true,
                Name = "Jeep",
                CorpName = "C00l J33p5",
                Motto = "Wrangler Unlimited"
            };
            var vehicleList = new List<IVehicle>() { sedan, truck, SUV };
            Console.WriteLine("Vehicle List added to list so far:");
            foreach (var vehicles in vehicleList)
            {
                Console.WriteLine($"Name: {vehicles.Name}\nNumber of wheels: {vehicles.HowManyWheels} \nSteering: {vehicles.HasSteering}\nHas Steros: {vehicles.HasStereo}\nHas sunroof: {vehicles.HasSunroof}");
                if (vehicles == truck)
                {
                    Console.WriteLine($"Truck Bed: {truck.HasTowHook}\nTow Hook: {truck.HasTowHook}");
                    Console.WriteLine($"Corporation name: {truck.CorpName}\nCorporate Motto: {truck.Motto}");
                }
                else if (vehicles == sedan)
                {
                    Console.WriteLine($"Trunk: {sedan.HasTrunk}\nLeather Seats: {sedan.HasLeatherSeats}");
                    Console.WriteLine($"Corporation name: {sedan.CorpName}\nCorporate Motto: {sedan.Motto}");
                }
                else if (vehicles == SUV)
                {
                    Console.WriteLine($"Cargo: {SUV.HasCargo}\nFour wheel drive: {SUV.FourWheelDrive}");
                    Console.WriteLine($"Corporation name: {SUV.CorpName}\nCorporate Motto: {SUV.Motto}");
                }
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
