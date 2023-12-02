using System;
using System.Windows.Forms;

namespace PuzzleGame
{
    public partial class PuzzleGame : Form
    {
        clsPages pages = new clsPages();
        clsHint HintPicture = new clsHint();
        clsTimer ManageTimer = new clsTimer();
        clsGameData GameData = new clsGameData();
        clsPrgressPar progBar = new clsPrgressPar();
        clsValidateWord ValidateWord = new clsValidateWord();
        clsWordGenerator WordGenerator = new clsWordGenerator();
        clsButtonTextProcessor ButtonTextProcessor = new clsButtonTextProcessor();

        string ImageName;
        public PuzzleGame()
        {
            InitializeComponent();

        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {

            lblHeighScore.Text = "(00)";
            lblFailedAttempts.Text = "(0/3)";

            //generate word  
            WordGenerator.GeneratWord(TableTobLetters, comboWordType.Text.ToLower());
            ImageName = WordGenerator.ImageName();

            //move to play page
            pages.MoveToPage(clsPages.enPage.PlayGame, tabControlMain);

            //timer start count
            timer.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {

            if (btnPause.Tag.ToString() == "Stop")
            {
                timer.Stop();
                btnPause.Tag = "Play";
                panalBody.Enabled = false;
            }
            else
            {
                timer.Start();
                btnPause.Tag = "Stop";
                panalBody.Enabled = true;

            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = ManageTimer.IncreaseTimer().ToString();
            progBar.IncreasePrgressBarValue(progressBarMain, ManageTimer.TimerNumber());

            if (ManageTimer.CheckTimerNumber())
            {
                timer.Stop();

                MessageBox.Show("GAME OVER", "TIME IS OUT, THE GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information);

                pages.MoveToPage(clsPages.enPage.FinalResult, tabControlMain);


                //show final result 
                lblFinalFailedAttempts.Text = GameData.FailedAttempts.ToString();
                lblFinalHightScore.Text = GameData.HightScore.ToString();



            }

        }

        private void btnLetter_Tick(object sender, EventArgs e)
        {
            txtWord.Text = ButtonTextProcessor.SelectClickedLetter((Button)sender);
        }

        private void btnBackWord_Click(object sender, EventArgs e)
        {
            if (txtWord.TextLength < 10)
            {
                txtWord.Text = ButtonTextProcessor.BackWord();

            }

        }

        private void btnRefrsh_Click(object sender, EventArgs e)
        {
            WordGenerator.GeneratWord(TableTobLetters, comboWordType.Text.ToLower());
            ImageName = WordGenerator.ImageName();

            HintPicture.ClearHintPicture(picHint);

            txtWord.Text = ButtonTextProcessor.ResetTextBox();

        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (ValidateWord.WordExistsInWordArray(txtWord.Text, comboWordType.Text.ToString()))
            {
                lblHeighScore.Text = GameData.IncreaseTheHighestValue().ToString();

                //generat new random word
                btnRefrsh.PerformClick();
            }
            else
            {
                lblFailedAttempts.Text = $"({GameData.IncreaseTheNumberOfFailedAttempts().ToString()}/3)";

                if (GameData.FailedAttempts == 3)
                {
                    MessageBox.Show("Game Over");

                    pages.MoveToPage(clsPages.enPage.FinalResult, tabControlMain);

                    //show final result 
                    lblFinalFailedAttempts.Text = GameData.FailedAttempts.ToString();
                    lblFinalHightScore.Text = GameData.HightScore.ToString();
                }

            }
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            pages.MoveToPage(clsPages.enPage.starGame, tabControlMain);

            //reset the game 
            ManageTimer.RefrechTimer();

            GameData.FailedAttempts = 0;
            GameData.HightScore = 0;

            txtWord.Text = ButtonTextProcessor.ResetTextBox();

        }

        private void btnHint_Click(object sender, EventArgs e)
        {

            HintPicture.SelectHintPicture(picHint, ImageName);

        }
    }
}
