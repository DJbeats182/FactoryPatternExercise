using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    internal class Motorcycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("You choose to make a new Motorcycle!");
        }
    }
}
