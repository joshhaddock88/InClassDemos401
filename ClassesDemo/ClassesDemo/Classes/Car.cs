using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo.Classes
{
    public class Car
    {
        private string color;
        //{ get; set; }
        //Getter function
        //Setter function
        public string Make { get; set; }
        public bool IsDriving { get; set; }
        public int Speed { get; set; }

        public Engine DriveTrain { get; set; }

        // This the logic of getter and setter methods.
        //{ get; set; } gives you all this logic magically.
        public string Color
        {
            get { return color; }
            set
            {
                if ( value == "brown" )
                {
                    color = "Red";
                }
                else
                {
                    color = value;
                }
            }
        }

        //Constructor
        public Car()
        {

        }

        public Car(string make, string color, int cyl)
        {
            Console.WriteLine("I am in the overloaded constructor");
            Make = make;
            Color = color;
            DriveTrain = new Engine(cyl);
        }

        public void Drive()
        {
            IsDriving = true;
        }

        public void Stop()
        {
            IsDriving = false;
        }
    }
}
