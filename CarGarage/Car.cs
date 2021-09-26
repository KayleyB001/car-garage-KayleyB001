using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int FuelLevel { get; set; }
        public bool AutoBrakeActive { get; set; }


        public string SetMake(string make)
        {
            Make = "Honda";
            return make;
        }

        public string SetModel(string model)
        {
            Model = "Accord";
            return model;
        }

        public int GetSpeed()
        {
            Speed = 27;
            return Speed;

        }

        public bool IsSpeeding()
        {
            if (Speed >= 70)
            {
                return true;
            }
            else
                return false;


        }

        public int Accelerate()
        {

            if (Speed == 0)
            {
                Speed += 10;
            }
            if (Speed >= 100)
            {
                Speed = 100;
            }

            return Speed;



        }

        public int Brake()
        {
           

            Convert.ToBoolean(Speed);
            if (Speed == 10)
            {
                Speed -= 7;

            }
            if (AutoBrakeActive == true)
            {
                Speed -= 25;
            }
            if (Speed <= 1)
            {
                Speed = 0;
            }
            return Speed;
        }
            
            








    }
}
