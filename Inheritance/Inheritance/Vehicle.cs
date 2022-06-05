using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Vehicle
    {
        public int Wheels { get; set; }

        public void Drive()
        {
            Console.WriteLine($"My care with {Wheels} wheels is now driving");
        }
    }
}
