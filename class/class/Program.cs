using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Motor
    {
        public string type;
        public int kW;
        public void Drive()
        {
            Console.WriteLine($"тип: {type}  кВт: {kW}");
        }
    }
    class Car
    {
        public string name;
        public string colour;
        public int start;
        
        public string wheel;
        public int door;
        public void Info()
        {
            Console.WriteLine($"модель: {name}  цвет: {colour}  количество стартов: {start} \n колесо: {wheel}  дверей: {door}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car Audi = new Car();
            Motor motor = new Motor();
            Audi.start = 5;
            Audi.colour = "black";
            Audi.name = "A8";
            Audi.wheel = "R19";
            Audi.door = 4;
            motor.type = "diesel";
            motor.kW = 175;
            motor.Drive();
            Audi.Info();

            Console.ReadLine();

            
        }
        
    }
}
