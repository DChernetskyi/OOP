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
        public void Info()
        {
            Console.WriteLine($"модель: {name}  цвет: {colour}  количество стартов: {start}");
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
            Audi.Info();

            Console.ReadLine();

            
        }
        
    }
}
