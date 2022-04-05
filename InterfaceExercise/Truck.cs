using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }
        public bool HasTruckBed { get; set; }//SPECIFIC TO TRUCK
        public bool HasTowHook { get; set; }
        public bool HasSteering { get; set; }//SPECIFIC TO VEHICLE
        public int HowManyWheels { get; set; }
        public bool HasStereo { get; set; }
        public bool HasSunroof { get; set; }
        public string Name { get; set; }
        public string CorpName { get; set; }//SPECIFIC TO COMPANY
        public string Motto { get; set; }
    }
}
