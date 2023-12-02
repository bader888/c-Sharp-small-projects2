namespace PuzzleGame
{
    public class clsGameData
    {
        public string CurrentWord;
        public int HightScore;
        public int FailedAttempts;


        public string[] animals = { "cat", "dog", "fox", "lion" };
        public string[] Food = { "egg", "fish", "tea" };


        public int IncreaseTheNumberOfFailedAttempts()
        {
            FailedAttempts++;

            return FailedAttempts;
        }

        public int IncreaseTheHighestValue()
        {
            HightScore += 10;
            return HightScore;
        }

    }
}
