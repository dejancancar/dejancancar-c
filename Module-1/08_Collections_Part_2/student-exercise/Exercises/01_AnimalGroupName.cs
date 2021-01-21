using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").
         *
         * The animal name should be case insensitive so "elephant", "Elephant", and
         * "ELEPHANT" should all return "herd".
         *
         * If the name of the animal is not found, null, or empty, return "unknown".
         *
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * AnimalGroupName("giraffe") → "Tower"
         * AnimalGroupName("") -> "unknown"
         * AnimalGroupName("walrus") -> "unknown"
         * AnimalGroupName("Rhino") -> "Crash"
         * AnimalGroupName("rhino") -> "Crash"
         * AnimalGroupName("elephants") -> "unknown"
         *
         */
        public string AnimalGroupName(string animalName)
        {

            //declare a dictionary and add names
            //animalName puts in a name
           
            Dictionary<string, string> animalGroup = new Dictionary<string, string>()
            {
                {"rhino", "Crash" },
                {"giraffe", "Tower" },
                {"elephant", "Herd"},
                {"lion", "Pride"},
                {"crow", "Murder"},
                {"pigeon", "Kit"},
                {"flamingo", "Pat"},
                {"deer", "Herd"},
                {"dog", "Pack"},
                {"crocodile", "Float"},

            };
            //take name and return the value (both string)
            //case insensitive
            //string groupType = "UNKNOWN";
            //if (animalName > 0)
            //{ }
            if (animalName == null)
            {
                return "unknown";
            }
            string animalNameLower = animalName.ToLower();
            foreach (KeyValuePair<string, string> kvp in animalGroup)
            {
                if(animalNameLower == (kvp.Key))
                {
                    return kvp.Value;
                }
                //return groupType = kvp.Value;
                
            }


            //if animal is not found return unknown






            return "unknown";
        }
    }
}
