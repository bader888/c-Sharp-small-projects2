using System.Drawing;
using System.Windows.Forms;

namespace PuzzleGame
{
    public class clsHint
    {

        public void SelectHintPicture(PictureBox picbox, string ImageName)
        {

            picbox.Image = Image.FromFile($"C:\\Users\\lenovo\\source\\repos\\PuzzleGame\\{ImageName}.png");

        }

        public void ClearHintPicture(PictureBox picbox)
        {
            picbox.Image = Image.FromFile($"C:\\Users\\lenovo\\source\\repos\\PuzzleGame\\problem.png");

        }
    }
}
