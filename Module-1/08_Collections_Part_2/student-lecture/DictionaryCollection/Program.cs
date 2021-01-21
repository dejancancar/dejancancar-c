using System;
using System.Collections.Generic;

namespace DictionaryCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter a State code: ");
            //string code = Console.ReadLine().ToUpper();
            //string state = LookUpStateUsingDictionary(code);
            //Console.WriteLine($"The state for code '{code}' is '{state}'");

            //DictionaryDemo();

            //HashSetDemo();

            // Build a name / height database and search it
            RunHeightDatabase();
        }

        static string LookupState(string stateCode)
        {
            List<string> stateCodes = new List<string>() { "AL", "AK", "AR", "AZ", "CA", "CO", "CT", "DE" };
            List<string> stateNames = new List<string>() { "Alabama", "Alaska", "Arkansas", "Arizona", "California", "Colorado",
                "Connecticut", "Deleware" };
            int index = stateCodes.IndexOf(stateCode);
            string stateName;

            if (index < 0)
            {
                stateName = "UNKNOWN";

            }
            else
                stateName = stateNames[index];
            return null;
        }

        static string LookUpStateUsingDictionary(string stateCode)
        {
            Dictionary<string, string> states = new Dictionary<string, string>()
            {
                { "AK", "Alaska" },// , between data types
                { "AR", "Arkansas" },
                { "AZ", "Arizona" },
                { "CO", "Colorado" },
                { "CA", "California"},



            }; // dont forget this semicolon
            string stateName = "UNKNOWN";
            if (states.ContainsKey(stateCode))
            {
                stateName = states[stateCode];
            }
            //else
            //{
            //    stateName = "UNKNOWN";
            //}

            return stateName;


        }
        static void DictionaryDemo()
        {

            // Demonstrate creating and searching a dictionary
        }

        static void HashSetDemo()
        {
            // Demonstrate a few HashSet methods

        }
        static void RunHeightDatabase()
        {
            // Display a greeting and menu

            //// 1. Let's create a new Dictionary that could hold string, ints
            ////      | "Josh"    | 70 |
            ////      | "Bob"     | 72 |
            ////      | "John"    | 75 |
            ////      | "Jack"    | 73 |
            Dictionary<string, int> heightDB = new Dictionary<string, int>()
            {
                { "ben", 71 },
                { "mike", 71},
                { "jaime", 70 },
                { "colin", 75}


            };

            

            string input;
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine(@" _    _      _       _     _     _____        _        _                    ");
                Console.WriteLine(@"| |  | |    (_)     | |   | |   |  __ \      | |      | |                   ");
                Console.WriteLine(@"| |__| | ___ _  __ _| |__ | |_  | |  | | __ _| |_ __ _| |__   __ _ ___  ___ ");
                Console.WriteLine(@"|  __  |/ _ \ |/ _` | '_ \| __| | |  | |/ _` | __/ _` | '_ \ / _` / __|/ _ \");
                Console.WriteLine(@"| |  | |  __/ | (_| | | | | |_  | |__| | (_| | || (_| | |_) | (_| \__ \  __/");
                Console.WriteLine(@"|_|  |_|\___|_|\__, |_| |_|\__| |_____/ \__,_|\__\__,_|_.__/ \__,_|___/\___|");
                Console.WriteLine(@"                __/ |                                                       ");
                Console.WriteLine(@"               |___/                                                        ");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("1) Add / update data");
                Console.WriteLine("2) Search the database");
                Console.WriteLine("3) Print the database");
                Console.WriteLine("4) Get Average Height");
                Console.WriteLine("Q) Quit");
                Console.WriteLine("");
                Console.ResetColor();
                Console.Write("Please enter selection: ");
                input = Console.ReadLine().ToLower();
                if (input.Length > 0)
                {
                    input = input.Substring(0, 1);
                }
                if (input == "q")
                {
                    break;
                }
                else if (input == "1")
                {
                    AddEditDB(heightDB);
                }
                else if (input == "2")
                {
                    SearchDB(heightDB);
                }
                else if (input == "3")
                {
                    PrintDB(heightDB);
                }
                else if (input == "4")
                {
                    ShowAverageHeight(heightDB);
                }
                else
                {
                    continue;
                }
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();

            }

            Console.WriteLine();
            Console.WriteLine("Done...");


        }

        public static void ShowAverageHeight(Dictionary<string, int> heightDB)
        {
            //7. Let's get the average height of the people in the dictionary

            //initialize a variable to sup up all the height
            int sumOfHeights = 0;
            // loop through the collection
                //add current height to sum
            foreach (KeyValuePair<string,int> kvp in heightDB)
            {
                //add current height to sum
                sumOfHeights = kvp.Value;
            }
            //calculate average by dividing the sum by the count
            if (heightDB.Count > 0)
            {
                Console.WriteLine($"The average height of the class is {(sumOfHeights/(double)heightDB.Count):n2} inches" );
            }
            else
            {
                Console.WriteLine("I'm sorry, I cannot calculate the average");
            }
        }

        public static void PrintDB(Dictionary<string, int> heightDB)
        {
            // Looping through a dictionary involves using a foreach loop
            // to look at each item, which is a key-value pair
            Console.WriteLine("Printing...");
            
            foreach (KeyValuePair<string,int> kvp in heightDB ) //kvp = key value pair or entry. its the pair
            {
                Console.WriteLine($"name: {kvp.Key}, height: {kvp.Value}");
            }

        }

        public static void AddEditDB(Dictionary<string, int> db)
        {
            Console.Write("What is the person's name?: ");
            string name = Console.ReadLine().ToLower();

            Console.Write("What is the person's height (in inches)?: ");
            int height = int.Parse(Console.ReadLine());

            // 2. Check to see if that name is in the dictionary
            //      bool exists = dictionaryVariable.ContainsKey(key)
            bool exists = db.ContainsKey(name);    // <-- change this

            if (!exists)
            {
                Console.WriteLine($"Adding {name} with new value.");
                // 3. Put the name and height into the dictionary
                //      dictionaryVariable[key] = value;
                //      OR dictionaryVariable.Add(key, value);
                db.Add(name, height);

            }
            else //The name already DOES exist in the db
            {
                Console.WriteLine($"Overwriting {name} with new value.");
                // 4. Overwrite the current key with a new value
                //      dictionaryVariable[key] = value;
                db[name] = height;
            }
        }
        public static void SearchDB(Dictionary<string, int> db)
        {
            Console.Write("Which name are you looking for? ");
            string input = Console.ReadLine().ToLower();

            //5. Let's get a specific name from the dictionary
            if(db.ContainsKey(input))
            {
                Console.WriteLine($"The name '{input}' exists, and is '{db[input]}' inches tall");
            }
            else
            {
                Console.WriteLine($"'{input}' does not exist in the database.");
            }



        }
    }
}
