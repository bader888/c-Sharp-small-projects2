using System.Windows.Forms;

namespace PuzzleGame
{
    public class clsPages
    {
        public enum enPage
        {
            starGame = 0,
            PlayGame = 1,
            FinalResult = 2,
        }

        //Pages
        private void ActivePage(int PageIndex, TabControl tabControls)
        {
            //disable all pages first 
            tabControls.TabPages[0].Enabled = false;
            tabControls.TabPages[1].Enabled = false;
            tabControls.TabPages[2].Enabled = false;

            //enable the current page
            tabControls.SelectedTab = tabControls.TabPages[PageIndex];
            tabControls.TabPages[PageIndex].Enabled = true;
        }

        public void MoveToPage(enPage Page, TabControl AllPages)
        {

            switch (Page)
            {
                case enPage.starGame:

                    ActivePage(0, AllPages);
                    break;

                case enPage.PlayGame:

                    ActivePage(1, AllPages);
                    break;

                case enPage.FinalResult:

                    ActivePage(2, AllPages);
                    break;
            }
        }

    }
}
