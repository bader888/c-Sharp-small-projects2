using System;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            MessageBox.Show(dateTimePicker1.Value.ToShortTimeString());
            MessageBox.Show(dateTimePicker1.Value.ToShortDateString().ToString());


        }
    }
}
