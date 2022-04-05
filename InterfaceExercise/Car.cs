using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        { 
        }
        public bool HasTrunk { get; set; }//SPECIFIC TO CAR
        public bool HasLeatherSeats { get; set; }
        public bool HasSteering { get; set; } //HAVE TO ADD INTERFACE VEHICLE'S PROPERTIES
        public int HowManyWheels { get; set; }
        public bool HasStereo { get; set; }
        public bool HasSunroof { get; set; }
        public string Name { get; set; }
        public string CorpName { get; set; }//HAVE TO ADD INTERFACE COMPANY'S PROPERTIES
        public string Motto { get; set; }
    }
}
