using System.Linq;

namespace PuzzleGame
{
    public class clsValidateWord
    {

        clsGameData GameDate = new clsGameData();

        public bool WordExistsInWordArray(string Word, string WordType)
        {

            switch (WordType.ToLower())
            {
                case "animal":
                    return GameDate.animals.Contains(Word.ToLower());


                case "food":
                    return GameDate.Food.Contains(Word.ToLower());

                default:
                    return false;
            }

        }

    }
}
