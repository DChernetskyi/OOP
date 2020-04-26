using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Motor
    {
        public string name;
        public string colour;
        public int start;
        public string motor;
        public string type;
        public int kW;
        public void GetMotor()
        {
            Console.WriteLine($"тип: {type}  кВт: {kW}");
        }
        public string wheel;
        public int door;
        public void Info()
        {
            Console.WriteLine($"модель: {name}  цвет: {colour}  количество стартов: {start} \n двигатель: {motor}  колесо: {wheel}  дверей: {door}");
            Console.WriteLine($"модель: {name}  цвет: {colour}  количество стартов: {start} \n колесо: {wheel}  дверей: {door}");
        }
    }
    class Program
    { 
static void Main(string[] args)
       { 
            Audi.start = 5;
            Audi.colour = "black";
            Audi.name = "A8";
            Audi.motor = "diesel";
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
