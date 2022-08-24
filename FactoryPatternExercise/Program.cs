
using FactoryPatternExercise;

Console.WriteLine("Enter the amount of tires you would like your vehicle to have:");

bool input;
int wheelCount;
do
{
     input = int.TryParse(Console.ReadLine(), out wheelCount);

    if (!input)
    {
        Console.WriteLine("Sorry input not recognized, Please try again:");
    }
} while (!input);

var vehicle = VehicleFactory.GetVehicle(wheelCount);
vehicle.Drive();