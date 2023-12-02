using System.Windows.Forms;

namespace PuzzleGame
{
    public class clsButtonTextProcessor
    {

        private string Letters;

        public string SelectClickedLetter(Button button)
        {
            Letters += button.Text;
            return Letters;
        }

        public string BackWord()
        {

            if (Letters.Length != 0)
            {
                Letters = Letters.Remove(Letters.Length - 1);
            }

            if (Letters.Length == 0)
            {
                ResetTextBox();
            }

            return Letters;
        }

        public string ResetTextBox()
        {
            Letters = "";
            return "Click Letter To Select";

        }

    }
}
