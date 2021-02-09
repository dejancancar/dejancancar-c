using System;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = ".NET";
            s1.ToLower();

            Console.WriteLine(s1);
            // Use our custom Person data type (class)
<<<<<<< HEAD
            //CreatePerson();
=======
            Person p = CreatePerson();
            Console.WriteLine(p.FirstName);

>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4

            string name = "Ada Lovelace";

            // Strings are actually arrays of characters (char). 
            // Those characters can be accessed using [] notation.

            // 1. Write code that prints out the first and last characters
            //      of name.
            // Output: A
<<<<<<< HEAD

            // Output: e
            Console.WriteLine($"First char: {name[0]}, Last char: {name[name.Length - 1]}");
            // Console.WriteLine("First and Last Character. ");

            // 2. How do we write code that prints out the first three characters
            // Output: Ada

            Console.WriteLine($"First 3 characters: {name.Substring(0, 3)}");
            //
            // 3. Now print out the first three and the last three characters
            // Output: Adaace

            Console.WriteLine($"First 3 and Last 3 characters: {name.Substring(0, 3)} {name.Substring(name.Length - 3)}");

            // 4. What about the last word?
            // Output: Lovelace
            string[] words = name.Split(" ");

            Console.WriteLine($"Last Word: {words[words.Length - 1]}");
            //ALternate way
            int spaceIndex = name.IndexOf(" "); //name.LastIndexOf would find space the other way if she had a middle name
            Console.WriteLine($"Last Word: {name.Substring(spaceIndex + 1)}");

            // 5. Does the string contain inside of it "Love"?
            // Output: true
            //string lowerName = name.ToLower(); // Lowers originam name string, then we can check against lower
            Console.WriteLine($"Contains \"Love\": {name.Contains("Love")}"); // caps sensitive
=======
            // Output: e
            char firstChar = name[0];
            char lastChar = name[name.Length - 1];
            Console.WriteLine($"First and Last Character: {firstChar}-{lastChar} ");

            // 2. How do we write code that prints out the first three characters
            // Output: Ada
            string first3OfName = name.Substring(0, 3);
            Console.WriteLine($"First 3 characters: {first3OfName}");

            // 3. Now print out the first three and the last three characters
            // Output: Adaace
            Console.WriteLine($"Last 3 characters: {name.Substring(0,3)}-{name.Substring(name.Length-3,3)}");

            // 4. What about the last word?
            // Output: Lovelace
            string[] peicesOfName = name.Split(" ");
            Console.WriteLine($"Last Word: {peicesOfName[peicesOfName.Length-1]}");

            // 5. Does the string contain inside of it "Love"?
            // Output: true
            string[] words = name.Split(" ");
            Console.WriteLine("Contains \"Love\"");
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4

            // 6. Where does the string "lace" show up in name?
            // Output: 8
            int indexOfLace = name.IndexOf("lace");
<<<<<<< HEAD
            if (name.IndexOf("LACE") < 0) //if (indexOfLace < 0 ) is more maintainable
            {
                Console.WriteLine("NOT FOUND!");
            }
            Console.WriteLine($"Index of \"lace\": {name.IndexOf("lace")}"); //{indexOfLace}

            // 7. How many 'a's OR 'A's are in name?
            // Output: 3
            int countOfAs = 0;
            for (int i = 0; i < name.Length; i++)
            {
                //This way "chains" two methods together. Substring is "called on" name, and then ToLower is called on what gets returned from substring
                if (name.Substring(i, 1).ToLower() == "a")//could use || name.Substring(i,1) == "A" or chain methods
                {
                    countOfAs++;
                }
            }

            Console.WriteLine($"Number of \"a's\": {countOfAs}");

            // 8. Replace "Ada" with "Ada, Countess of Lovelace"
            //string newName = name.Replace("Ada", "Ada, Countess of Lovelace"); //or name = name.Replace
=======
            Console.WriteLine($"Index of \"lace\": {indexOfLace}");

            // 7. How many 'a's OR 'A's are in name?
            // Output: 3
            int countOfA = 0;
            for (int i=0;i<name.Length;i++) {
                if (name.Substring(i,1).ToLower() == "a") {
                    countOfA++;
                }
            }
            Console.WriteLine($"Number of \"a's\": {countOfA}");

            // 8. Replace "Ada" with "Ada, Countess of Lovelace"
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
            name = name.Replace("Ada", "Ada, Countess of Lovelace");
            Console.WriteLine(name);

            // 9. Set name equal to null.
            name = null;

            // 10. If name is equal to null or "", print out "All Done".
<<<<<<< HEAD
            if (string.IsNullOrEmpty(name)) ;
            {
                Console.WriteLine("All Done");
            }

            //Console.ReadLine();
=======
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("All Done");
            }


>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
        }

        public static Person CreatePerson()
        {
<<<<<<< HEAD
            // Create a new Person object from the Person class

            //Declare ********
            Person instructor;
            //Allocate memory (new) *********
            instructor = new Person();

            // Set the properties of this object - Assign *********
            instructor.FirstName = "Ben";
            instructor.LastName = "Kennedy";
            instructor.HeightInches = 71;

            // Create another person and set its value.
            //Declare and allocate
            Person student = new Person();

            student.FirstName = "Ariel";
            student.LastName = "Zaviezo";
            student.HeightInches = 72;

=======
            Person instructor;
            instructor = new Person();
            instructor.FirstName = "Ben";
            return instructor;
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
        }
    }

}