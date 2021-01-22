using System;

namespace CarSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Car using the default constructor.  Can I see any private members?
            // TODO: Later, use a "better" constructor
            Car dejansCar = new Car(2021, "Kia", "Stinger");

            Car secondCar = new Car(2018, "Chevrolet", "Silverado"); // cant leave without parameters if you have a constructor otherwise it defaults.


            //I cannot do this, there is no SET on the property, ONLY A GET
            //dejansCar.Age = 4;


            Console.WriteLine($"Dejan's car is {dejansCar.Color} and it is {dejansCar.Age} years old.");

            // Set the cars properties: Make, model, year. Try to set its Age.

            dejansCar.Color = "White"; // "sets" the color ALSO has get so it can be recalled
            //dejansCar.Year = 2017;
            //dejansCar.Make = "Kia";
            //dejansCar.Model = "Optima";


            // Create a new Car object (Create a new object of type Car)


            // Display the car property values, including Age


            // Try to put the car into gear
            dejansCar.Gear = "R";

            Console.WriteLine($"Dejan's car is now in {dejansCar.Gear} gear");

            dejansCar.Gear = "D";

            Console.WriteLine($"Dejan's car is now in {dejansCar.Gear} gear"); // code doesnt allow to go from reverse to drive
            //and we set the car to reverse already. Would have to be neutral or reverse

            // Speed up to 60mph
            while (dejansCar.Speed < 60)
            {
                dejansCar.Accelerate();
                Console.WriteLine($"Your speed is now {dejansCar.Speed} mph.");
            }
            //dejansCar.Speed = 60;     Not allowed to do because the speed is private

            // When the car hits 20mph, try to put it into Reverse


            // Now let's brake hard. (Call the overloaded Accellerate)
            while (dejansCar.Speed > 0)
            {
                dejansCar.Accelerate(-5);
                Console.WriteLine($"Your speed is now {dejansCar.Speed}.");
            }
        }
    }
}
