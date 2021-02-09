using System;
using System.Collections.Generic;

namespace CarSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Car using the default constructor.  Can I see any private members?
            // TODO: Later, use a "better" constructor
<<<<<<< HEAD
            Car dejansCar = new Car(2021, "Kia", "Stinger");

            Car secondCar = new Car(2018, "Chevrolet", "Silverado"); // cant leave without parameters if you have a constructor otherwise it defaults.


            //I cannot do this, there is no SET on the property, ONLY A GET
            //dejansCar.Age = 4;


            Console.WriteLine($"Dejan's car is {dejansCar.Color} and it is {dejansCar.Age} years old.");
=======
            List<string> myList = new List<string>();
            Car mikesCar = new Car();
            mikesCar.Color = "Blue";   //use the setter
            Console.WriteLine($"Mike's car is {mikesCar.Color} and it is {mikesCar.Age} years old");
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4

            // Set the cars properties: Make, model, year. Try to set its Age.
            
            mikesCar.Make = "Toyota";
            mikesCar.Model = "Corolla";

            dejansCar.Color = "White"; // "sets" the color ALSO has get so it can be recalled
            //dejansCar.Year = 2017;
            //dejansCar.Make = "Kia";
            //dejansCar.Model = "Optima";


            // Create a new Car object (Create a new object of type Car) using a different constructor
            Car bensCar = new Car(2021, "Jeep", "Wrangler");

            // Display the car property values, including Age


            // Try to put the car into gear
<<<<<<< HEAD
            dejansCar.Gear = "R";

            Console.WriteLine($"Dejan's car is now in {dejansCar.Gear} gear");
=======
            mikesCar.Gear = "R";  //the setter code is being executed
            Console.WriteLine($"Mike's car is in {mikesCar.Gear}");

            mikesCar.Gear = "D";
            Console.WriteLine($"Now Mike's car is in {mikesCar.Gear}");
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4

            dejansCar.Gear = "D";

            Console.WriteLine($"Dejan's car is now in {dejansCar.Gear} gear"); // code doesnt allow to go from reverse to drive
            //and we set the car to reverse already. Would have to be neutral or reverse

            // Speed up to 60mph
<<<<<<< HEAD
            while (dejansCar.Speed < 60)
            {
                dejansCar.Accelerate();
                Console.WriteLine($"Your speed is now {dejansCar.Speed} mph.");
            }
            //dejansCar.Speed = 60;     Not allowed to do because the speed is private
=======
            while (mikesCar.Speed < 60) {
                mikesCar.Accelerate();
                Console.WriteLine($"Mike's car is now traveling at {mikesCar.Speed}");
            }
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4

            // When the car hits 20mph, try to put it into Reverse


            // Now let's brake hard. (Call the overloaded Accellerate)
<<<<<<< HEAD
            while (dejansCar.Speed > 0)
            {
                dejansCar.Accelerate(-5);
                Console.WriteLine($"Your speed is now {dejansCar.Speed}.");
            }
=======
            while (mikesCar.Speed > 0) {
                mikesCar.Accelerate(-5);
            }
            Console.WriteLine($"Mike's car is now driving at {mikesCar.Speed} mph");
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
        }
    }
}
