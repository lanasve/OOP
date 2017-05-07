using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_2.Class
{
    abstract class EngineVehicle
    {
        //public double Fuel;
        //public double Speed;
        public  EngineVehicle ( )
        {
            Fuel =0 ;
            Speed = 0;
            Console.WriteLine("Fuel=  " + Fuel + "  Speed=  " + Speed);
            Console.ReadKey();
        }

        public virtual double Speed { get; set; }
        public virtual double Fuel { get; set; }
        public double fuel;
        public double speed;

        public virtual double FullTank()
        {
            fuel += 150;
            Console.WriteLine($"We fill tank. Now you have  {fuel}");
            return fuel;
        }
        public virtual void CheckSpeed()
        {            
            if (speed >= 155 & speed >= 0)
            {
                Console.WriteLine("Press break! Immediately!!! Your speed is very high!");
                speed -= 50;
                Console.WriteLine($"We used automatically break. Your speed now is {speed}. ");
            }
            else if(speed <0)
            {
                Console.WriteLine("Press Gas!!! Fast!!!");
                speed += 5;
                Console.WriteLine($"We used automatically break. Your speed now is {speed}. ");
            }
            else
            {
                Console.WriteLine("All right! Continue your trip!");
            }
        }
        public void CheckFuel()
        {
            if (fuel <= 10)
            {
                Console.WriteLine("You need fuelstation!!! Your fuel will finish soon!");
                Console.WriteLine( " We send you mobile refueling!!!");
                FullTank();
                Console.WriteLine($"Your fuel now is {fuel}. ");
            }                    
        }



    }
}
