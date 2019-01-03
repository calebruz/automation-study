using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationStudy.SandboxApp.Vehicles
{
    public class Vehicle 
    {
        public Vehicle(string make, string model, int year, int wheelCount )
        {
            if(string.IsNullOrWhiteSpace(make))
                throw new ArgumentException("There was no Make");
            Make = make;
            Model = model;
            Year = year;
            WheelCount = wheelCount;
        }

        public string Make { get; }
        public string Model { get; }
        public int Year { get; }
        public int WheelCount { get; }
        public DateTime LastMaintenanceDate { get; set; }
    }
}
