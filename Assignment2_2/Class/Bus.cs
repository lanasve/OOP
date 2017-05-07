using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2_2.Interfaces;

namespace Assignment2_2.Class
{
    class Bus : EngineVehicle, IDriveable
    {        
        public string Name;
        public Bus()
        {
            fuel = Fuel;
            speed = Speed;
        }
        public Bus (string name)
        {
            Name = name; 
        }

        public override double FullTank()
        {
            fuel += 150;
            Console.WriteLine($"We fill tank. Now you have  {fuel}");
            return fuel;            
        }

        public void Break()
        {
            speed -= 30;
            fuel -= 2;
            CheckSpeed();
            CheckFuel();
            Console.WriteLine($"Your {Name} breaked. Your speed now is {speed}. Fuel now is  {fuel} ");
            
        }

        public void Gas()
        {
            speed += 30;
            fuel -= 3;
            CheckSpeed();
            CheckFuel();
            Console.WriteLine($"Your {Name} added gas. Your speed now is {speed}. Fuel now is  {fuel} ");
           
        }

        public void StartEngine()
        {
            speed += 10;
            fuel -= 2;
            CheckSpeed();
            CheckFuel();
            Console.WriteLine($"Your {Name}s engine started. Your speed now is {speed}. Fuel now is  {fuel} ");
           
        }

        public void StopEngine()
        {
            speed = 0;
            fuel -= 1;
            CheckSpeed();
            CheckFuel();
            Console.WriteLine($"Your {Name}s engine stopped. Your speed now is {speed}. Fuel now is  {fuel} ");
           
        }

        public void TurnLeft()
        {
            Console.WriteLine($"Your {Name} turned left. ");
            
        }

        public void TurnRight()
        {
            Console.WriteLine($"Your {Name} turned right. ");
            
        }
        public override void CheckSpeed()
        {
            if (speed >= 115 & speed >= 0)
            {
                Console.WriteLine("Press break! Immediately!!! Your speed is very high!");
                speed -= 50;
                Console.WriteLine($"We used automatically break. Your speed now is {speed}. ");
            }
            else if (speed < 0)
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


    }
}
