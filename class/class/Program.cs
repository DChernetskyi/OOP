using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Car
    {
        public string name;
        public string colour;
        public int start;
        public string type;
        public int kW;
        public void Motor()
        {
            Console.WriteLine($"тип: {type}  кВт: {kW}");
        }
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
            Audi.start = 5;
            Audi.colour = "black";
            Audi.name = "A8";
            Audi.wheel = "R19";
            Audi.door = 4;
            Audi.type = "diesel";
            Audi.kW = 175;
            Audi.Motor();
            Audi.Info();

            Console.ReadLine();

            
        }
        
    }
}
