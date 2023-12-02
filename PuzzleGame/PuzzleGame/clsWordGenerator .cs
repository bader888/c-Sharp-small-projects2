using System;
using System.Windows.Forms;

namespace PuzzleGame
{
    public class clsWordGenerator
    {
        clsGameData GameData = new clsGameData();
        clsRandom Random = new clsRandom();
        private TableLayoutPanel LettersTable;
        public string CurrentWord;
        private string _WordType;
        private int arrLength;


        private string SelectCurrentWordType(int RandomNumber)
        {
            switch (_WordType)
            {
                case "animal":
                    arrLength = GameData.animals.Length;
                    return GameData.animals[RandomNumber];

                case "food":
                    arrLength = GameData.Food.Length;
                    return GameData.Food[RandomNumber];

                default:
                    return " ";
            }
        }

        private void SelectWord()
        {

            int RandomNumberForWord = Random.GetRandomNumberBetween(0, arrLength - 1); ;

            //get random word 
            CurrentWord = SelectCurrentWordType(RandomNumberForWord);


            for (int i = 0; i < CurrentWord.Length; i++)
            {
                int RandomNumberForLetter = Random.GetRandomNumberBetween(0, 7);
                LettersTable.Controls[RandomNumberForLetter].Text = CurrentWord[i].ToString().ToUpper();

            }
        }

        public string ImageName()
        {
            return CurrentWord;
        }

        //return true if the btn of letter is empty
        private bool IsEmpty(string bntText)
        {
            return bntText == "";
        }

        private void SelectRandomLetter()
        {

            ClearLetters();

            //select word
            SelectWord();

            //random letters to fill all letters btns
            foreach (Control control in LettersTable.Controls)
            {

                //add random letter if the btn is empty
                if (IsEmpty(control.Text))
                {
                    control.Text = Convert.ToChar(Random.GetRandomNumberBetween(65, 90)).ToString().ToUpper();

                }

            }


        }

        private void ClearLetters()
        {
            foreach (Control control in LettersTable.Controls)
            {
                control.Text = "";

            }
        }

        public void GeneratWord(TableLayoutPanel LettersTable, string WordType)
        {
            this.LettersTable = LettersTable;

            this._WordType = WordType;

            SelectRandomLetter();
        }

    }
}
