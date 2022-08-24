using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    internal class ThreeWheeler : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("You're going to have a lot of fun with your new Three Wheeler!");
        }
    }
}
