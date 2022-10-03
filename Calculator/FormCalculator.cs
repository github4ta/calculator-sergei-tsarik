using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "1";
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "2";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "+";
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            textDisplay.Text = Calculator.parseStatement(textDisplay.Text);
        }
    }
}
