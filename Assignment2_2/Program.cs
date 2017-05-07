using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2_2.Interfaces;
using Assignment2_2.Class;

namespace Assignment2_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car("car");
            Bus bus = new Bus("bus");
            Motorbike bike = new Motorbike("motorbike");
            bike.FullTank();
            car.FullTank();
            bus.FullTank();

            car.StartEngine();
            car.Gas();
            car.Break();
            bus.StartEngine();
            bus.Gas();
            bus.Break();
           
            bike.StartEngine();
            bike.Gas();
            bus.TurnLeft();
            car.TurnRight();

            Console.ReadKey();


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Bus[] arr = new Bus[] { new Bus("buss1"), new Car("car1"),
                                  new Motorbike("motorbike1")};
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].FullTank();
            }
            for(int j=1; j<20; j++)  
            {
                for(int i=0; i<arr.Length; i++)
                {                    
                    arr[i].StartEngine();
                    arr[i].Gas();
                    arr[i].TurnLeft();
                    arr[i].TurnRight();
                    arr[i].Break();
                    arr[i].StartEngine();
                    Console.WriteLine();
                }
                
            }
            Console.ReadKey();






        }
    }
}
