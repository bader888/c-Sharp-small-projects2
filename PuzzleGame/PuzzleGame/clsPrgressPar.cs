using System.Windows.Forms;

namespace PuzzleGame
{
    public class clsPrgressPar
    {


        private bool IsProgressBarFull(int Value)
        {
            return Value == 49;
        }

        public void IncreasePrgressBarValue(ProgressBar progBar, int Value)
        {
            if (!IsProgressBarFull(Value))
            {

                progBar.Value = Value;
            }

        }

    }
}
