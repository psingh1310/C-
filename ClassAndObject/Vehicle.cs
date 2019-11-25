using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
    class Vehicle
    {
        private string vehicleName;
        private int engine;
        private string model;
        private double speed;

        public Vehicle(string vehicleName,string model)
        {
            this.vehicleName = vehicleName;
            this.engine = 4;
            this.model = model;
            this.speed = 40;
        }

        public string VehicleName { get => vehicleName;}
        public int Engine { get => engine;}
        public string Model { get => model;}
        public double Speed { get => speed; }

        public void direction()
        {
            Console.WriteLine(vehicleName + "is moving with the speed of "+speed);
        }
      }

   

}
