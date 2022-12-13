using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        // Clear Button Event

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumberOne.Clear();
            txtNumberTwo.Clear();
            // Change 'Clear' Text To 'Cleared'
            btnClear.Text = "Cleared";
        }

        // Change Clear Button Text To Clear

        private void txtNumberOne_Click(object sender, EventArgs e)
        {
            btnClear.Text = "Clear";
        }

        private void txtNumberTwo_Click(object sender, EventArgs e)
        {
            btnClear.Text = "Clear";
        }

        // Plus Event
        private void btnPlus_Click(object sender, EventArgs e)
        {
            double numberOne = double.Parse(txtNumberOne.Text);
            double numberTwo = double.Parse(txtNumberTwo.Text);
            double sum = numberOne + numberTwo;
            lblResult.Text = sum.ToString();
        }

        // Minus Event
        private void btnMinus_Click(object sender, EventArgs e)
        {
            double numberOne = double.Parse(txtNumberOne.Text);
            double numberTwo = double.Parse(txtNumberTwo.Text);
            double sum = numberOne - numberTwo;
            lblResult.Text = sum.ToString();
        }

        // Multi Event
        private void btnMulti_Click(object sender, EventArgs e)
        {
            double numberOne = double.Parse(txtNumberOne.Text);
            double numberTwo = double.Parse(txtNumberTwo.Text);
            double sum = numberOne * numberTwo;
            lblResult.Text = sum.ToString();
        }

        // Division Event
        private void btnDiv_Click(object sender, EventArgs e)
        {
            double numberOne = double.Parse(txtNumberOne.Text);
            double numberTwo = double.Parse(txtNumberTwo.Text);
            double sum = numberOne / numberTwo;
            lblResult.Text = sum.ToString();
        }

        // Close Button Event
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
