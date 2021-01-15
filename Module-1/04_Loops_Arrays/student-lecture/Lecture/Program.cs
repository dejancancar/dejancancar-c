using System;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Use a for-loop to print "Hello World" 10 times
            for (int i = 1; i <= 10; i++)
            {
                // for ( "initilize a variable"; "while this is true run the loop; "do this after each iteration of loop"
                Console.WriteLine("Hello World!");
            }


            // 2. Create an array of quiz scores
            int[] scores = new int[] { 92, 87, 100, 66};



            // 3. Print all the scores to the screen
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"Score = {scores[i]}");
            }


            // 4. Grade on a curve...increase all scores by the curve amount
            int curveAmount = 7;
            for (int i = 0; i < scores.Length; i++) //i can be anything, does not have to be i.
            {
                scores[i] += curveAmount; // adds to database
                Console.WriteLine($"{i + 1} Scores = {scores[i]}");

               // Console.WriteLine($"Scores = {scores[i] + curveAmount}"); only prints +7, doesn't add to database.
            }


            // 5. Calculate and print the average score for the class after the curve.
            // in the loop, add each score to the total
            // After loop is done, divide the total by the length of the array
            int scoreTotal = 0;

                for (int i = 0; i < scores.Length; i++)
            {
                scoreTotal += scores[i];
            }
            double averageScore = (double)scoreTotal / scores.Length;
            Console.WriteLine($"Average score {averageScore}");
        }
    }
}
