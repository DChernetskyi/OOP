using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    class Program
    {
        static void Main(string[] args)
        {
            car car = new car();
            car.name = "allroad";
            car.motor = "diesel";
            car.door = 4;
            car.power = 130;
            car.ToDrive();
            Console.ReadLine();
        }

    }
}
