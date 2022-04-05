using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }
        public bool HasCargo { get; set; }//SPECIFIC TO SUV
        public bool FourWheelDrive { get; set; }
        public bool HasSteering { get; set; }//SPECIFIC TO VEHICLE
        public int HowManyWheels { get; set; }
        public bool HasStereo { get; set; }
        public bool HasSunroof { get; set; }
        public string Name { get; set; }
        public string CorpName { get; set; }//SPECIFIC TO VEHICLE
        public string Motto { get; set; }

    }
}
