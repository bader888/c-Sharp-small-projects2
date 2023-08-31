using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //  txtInput.KeyPress += txtInput_KeyPress;
        }

        //global
        Button CleckedBtn;
        stCalculator mystCalculator;

        struct stCalculator
        {
            public int FirstNumber;
            public int SecondNumber;
            public int Result;
            public char Operation;
            public bool isOperationFill;
            public bool isFirstNumberFill;
            public bool isResltFill;
        }

        private void ClearCalculator()
        {
            mystCalculator.FirstNumber = 0;
            mystCalculator.SecondNumber = 0;
            mystCalculator.Operation = ' ';
            mystCalculator.Result = 0;

            txtInput.Clear();

            lblFinalResult.Text = null;

        }

        private void ResetCalculator()
        {
            mystCalculator.FirstNumber = 0;
            mystCalculator.SecondNumber = 0;
            mystCalculator.Operation = ' ';
            mystCalculator.isResltFill = false;

        }

        private void SetTheFirstNumber(char operation)
        {
            //empty input 
            if (txtInput.Text.Trim() == "")
            {

                //do operation on the previse result
                if (mystCalculator.Operation != ' ')
                {
                    mystCalculator.FirstNumber = mystCalculator.Result;


                }

            }
            else if (mystCalculator.isResltFill)
            {
                mystCalculator.SecondNumber = 0;
                mystCalculator.Result = 0;
                mystCalculator.FirstNumber = int.Parse(txtInput.Text);

                lblFinalResult.Text = null;
                txtInput.Clear();

            }
            else
            {
                mystCalculator.FirstNumber = int.Parse(txtInput.Text);
                txtInput.Clear();

            }

            mystCalculator.Operation = operation;


        }

        private void SetSecondNumber()
        {

            if (txtInput.Text.Trim() == "")
            {

                txtInput.Clear();

            }
            else
            {
                mystCalculator.SecondNumber = int.Parse(txtInput.Text);
                txtInput.Clear();

            }
        }

        private void ShowTheClickedNumber()
        {
            txtInput.Text += CleckedBtn.Text;
        }

        private void ShowFinalResult()
        {
            lblFinalResult.Text = $"{mystCalculator.FirstNumber}{mystCalculator.Operation}{mystCalculator.SecondNumber} = {mystCalculator.Result}";

        }

        private void CalculatTheResult()
        {
            switch (mystCalculator.Operation)
            {
                case '+':
                    mystCalculator.Result = mystCalculator.FirstNumber + mystCalculator.SecondNumber;


                    break;

                case '/':
                    mystCalculator.Result = mystCalculator.FirstNumber / mystCalculator.SecondNumber;

                    break;

                case '-':
                    mystCalculator.Result = mystCalculator.FirstNumber - mystCalculator.SecondNumber;

                    break;

                case '*':

                    mystCalculator.Result = mystCalculator.FirstNumber * mystCalculator.SecondNumber;

                    break;

            }
            mystCalculator.isResltFill = true;



        }

        private void StartCalculator()
        {
            switch (CleckedBtn.Tag.ToString())
            {
                case "Add":
                    SetTheFirstNumber('+');


                    break;

                case "Divid":
                    SetTheFirstNumber('/');

                    break;

                case "Sub":
                    SetTheFirstNumber('-');

                    break;

                case "Mult":
                    SetTheFirstNumber('*');

                    break;

                case "Equal":

                    SetSecondNumber();

                    CalculatTheResult();

                    ShowFinalResult();

                    break;

                case "Clear":

                    ClearCalculator();

                    break;

                default:

                    ShowTheClickedNumber();

                    break;
            }

        }

        private void btnResult_MouseClick(object sender, MouseEventArgs e)
        {

            txtInput.Focus();

            //this will hold the clecked button
            CleckedBtn = (Button)sender;

            StartCalculator();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ResetCalculator();

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("hi");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("ihihi");
        }

        private void txtInput_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char pressedKey = e.KeyChar;

            MessageBox.Show(pressedKey.ToString());





        }
    }
}
