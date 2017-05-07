using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2_2.Interfaces;

namespace Assignment2_2.Class
{
    class Car : Bus, IDriveable
    {
        public Car(string name) : base(name)
        {
        }
        public override double FullTank()
        {
            fuel += 60;
            Console.WriteLine($"We fill tank. Now you have  {fuel}");
            return fuel;
        }

    }
}
