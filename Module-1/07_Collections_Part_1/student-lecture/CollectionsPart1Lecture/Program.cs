using System;
using System.Collections.Generic;

namespace CollectionsPart1Lecture
{
    public class CollectionsPart1Lecture
	{
        static void Main(string[] args)
        {
			Console.WriteLine("####################");
			Console.WriteLine("       LISTS");
			Console.WriteLine("####################");

			List<string> characters;
			characters = new List<string>()
			{
				"Harry",
				"Ron",
				"Hermoine"
			};

			List<int> scores = new List<int>() { 90, 87, 67, 100, 87, 72 };
			scores.Add(99);

            // print using join
            Console.WriteLine(string.Join(" - ", scores));
			// can be written sideways
			//List<string> people = new List<string>() { "Dejan", "Michelle", "Cal" };

			//Grow list, add another character to the end of the list
			characters.Add("Voldemort");
			characters.Add("Albus");
			
				//Print the list by looping and CW
			for (int i = 0; i < characters.Count; i++)
			{
				Console.WriteLine(characters[i]);
			}


			Console.WriteLine("####################");
			Console.WriteLine("Lists are ordered");
			Console.WriteLine("####################");


			Console.WriteLine("####################");
			Console.WriteLine("Lists allow duplicates");
			Console.WriteLine("####################");

			characters.Add("Harry"); //Adds to the end of the List

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be inserted in the middle");
			Console.WriteLine("####################");

			characters.Insert(1, "Hagrid"); //need index AND item. Puts it in the front
			scores.Insert(0, 95);
			Console.WriteLine(string.Join(" - ", scores));

			string[] slitheren = new string[] { "Draco", "Crab", "Goyle" };
			//characters.AddRange(slitheren); //Adds range to the end of list
			characters.InsertRange(4, slitheren); // adds range to a specific index


			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be removed by index");
			Console.WriteLine("####################");

			characters.RemoveAt(1); //If you know what is at the current index
			characters.Remove("Harry"); // removes ONLY first item you typed
			scores.RemoveAt(0);
			scores.Remove(87);
			Console.WriteLine(string.Join(" - ", scores));

			Console.WriteLine("####################");
			Console.WriteLine("Find out if something is already in the List");
			Console.WriteLine("####################");
            Console.WriteLine($"Is there still an 87? {scores.Contains(87)}");

            Console.WriteLine($"Is Hermione in the list? {characters.Contains("Hermoine")}");
			Console.WriteLine($"Is HeWhoShallNotBeNamed in the list? {characters.Contains("HeWhoShallNotBeNamed")}");

			Console.WriteLine("####################");
			Console.WriteLine("Find index of item in List");
			Console.WriteLine("####################");

			Console.WriteLine($"Where is Hermione in the list? {characters.IndexOf("Hermoine")}");
			Console.WriteLine($"Where is HeWhoShallNotBeNamed in the list? {characters.IndexOf("HeWhoShallNotBeNamed")}");//can see in watch windows -1


			Console.WriteLine("####################");
			Console.WriteLine("Lists can be turned into an array");
			Console.WriteLine("####################");
			string[] charactersAsArray = characters.ToArray(); //new is implied not needed
			//create a list and populate it from an array
			List<string> newList = new List<string>(charactersAsArray);

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be sorted");
			Console.WriteLine("####################");
            Console.WriteLine(string.Join(",", characters));
			characters.Sort();
            Console.WriteLine(string.Join(",",characters));

			Console.WriteLine(string.Join(" - ", scores));
			scores.Sort();
			Console.WriteLine(string.Join(" - ", scores));
			//scores.Sort(); scores.Reverse(); sorts then reverses to get largest to smallest


			Console.WriteLine("####################");
			Console.WriteLine("Lists can be reversed too");
			Console.WriteLine("####################");
			// what ever order the list is currently in, takes it and reverses it.
			characters.Reverse();
			Console.WriteLine(string.Join(",", characters));

			Console.WriteLine("####################");
			Console.WriteLine("       FOREACH");
			Console.WriteLine("####################");
			Console.WriteLine();

			int result = 0;
			foreach (int score in scores)
            {
				result += score;
            }
            Console.WriteLine($"Total: {result}, Average Score: {(double)result / scores.Count}");


			//Print out all the characters

			//The classic way...
			for (int i = 0; i < characters.Count; i++)
            {
				string actor = characters[i];
                Console.WriteLine(actor);
            }
            Console.WriteLine("<=><=><=><=><=><=><=><=><=><=><=><=><=><=><=><=><=><=><=><=><=><=><=><=><=><=><=><=><=><=><=><=>");
			// the "foreach" way...
			foreach(string actor in characters)
            {
                Console.WriteLine(actor);

			
            }
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
			//clear the list
			characters.Clear(); // list is NOT null, its 0. Points to an element/index
			foreach(string actor in characters)
            {
                Console.WriteLine(actor);
            }

			//remove all values <75
			//Cannot remove or insert on a collection while in foreach LOOP
			/*foreach(int score in scores)
            {
				if (score < 75)
                {
					scores.Remove(score);

				}
            }
			*/

			//without i--; it would add 1 to i and you would never check 0 again. If you removed the first element, the 2nd element
			//becomes the first element, so you need i--
			for (int i = 0; i < scores.Count; i++)
            {
				if (scores[i] < 75)
				{
					scores.RemoveAt(i);
					i--;

				}
			}

		}
	}
}
