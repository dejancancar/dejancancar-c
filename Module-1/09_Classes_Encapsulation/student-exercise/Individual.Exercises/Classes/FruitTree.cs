namespace Individual.Exercises.Classes
{
    public class FruitTree
    {
        public string TypeOfFruit { get; private set; }

        public int PiecesOfFruitLeft { get; private set; }



        public FruitTree(string typeOfFruit, int piecesOfFruitLeft)
        {
            this.TypeOfFruit = typeOfFruit;
            this.PiecesOfFruitLeft = piecesOfFruitLeft;
        }

        //Method called PickFruit and accepts int called numberOfPiecesToRemove and returns a bool
        public bool PickFruit(int numberOfPiecesToRemove)
        {
            
            if (this.PiecesOfFruitLeft >= numberOfPiecesToRemove)
            {
               this.PiecesOfFruitLeft -= numberOfPiecesToRemove;
               return true;
            }
            return false;
        }

    }



}
