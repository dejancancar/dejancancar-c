namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
        public int EarnedMarks { get; set; }
        public int PossibleMarks { get; private set; }
        public string SubmitterName { get; private set; }

        public string LetterGrade
        {
            get
            {
                if (this.PossibleMarks <= 0)
                {
                    return "Possible Marks cannot be 0";
                }
                //calculate the percentage based on earned / possible
                double percent = (this.EarnedMarks * 100.0) / this.PossibleMarks; // made the 100 a double to convert. Gives us a double over 1.
                //determine letter grade from the percentage                
                if(percent >= 90)
                {
                    return "A";
                }
                else if (percent >= 80)
                {
                    return "B";
                }
                else if (percent >= 70)
                {
                    return "C";
                }
                else if (percent >= 60)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }

            } 
        }
        public HomeworkAssignment (int possibleMarks, string submitterName)
        {
            this.SubmitterName = submitterName;
            this.PossibleMarks = possibleMarks;
        }



    }
}
