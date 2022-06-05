using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Car : Vehicle
    {
        public Car(int wheels)
        {
            Wheels = wheels;
        }

        //Base is the class inherited from.
        public void Drive()
        {
            Console.WriteLine("Step on the gas pedal");
            base.Drive();
        }
    }
}
