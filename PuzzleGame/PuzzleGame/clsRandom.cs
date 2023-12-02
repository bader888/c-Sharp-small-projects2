using System;

namespace PuzzleGame
{
    public class clsRandom
    {

        private static Random random = new Random();


        public int GetRandomNumberBetween(int min, int max)
        {
            int RandomNumber = random.Next(min, max + 1);

            return RandomNumber;

        }
    }
}
