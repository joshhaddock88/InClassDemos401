using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Classes
{
    internal class KidBirthday : Birthday
    {
        public override string[] Presents { get; set; }
        public override string Venue { get; set; }

        public override void OpenPresents(string[] presents)
        {
            Console.WriteLine("Opening presents");
        }

        public override void PlayGames()
        {
            Console.WriteLine("Playing the games");
        }

        public override void Setup()
        {
            Console.WriteLine("Setting things up");
        }

        public override void Teardown()
        {
            Console.WriteLine("Clenaing it up");
        }
    }
}
