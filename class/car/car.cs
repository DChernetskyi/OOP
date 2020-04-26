using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    public class car
    {
        public string name;
        public string motor;
        public int door;
        public int power;
        public void ToDrive()
        {
            Console.WriteLine($"model: {name} motor:{motor} dveri: {door} kW: {power}");
        }
        

    }
}
