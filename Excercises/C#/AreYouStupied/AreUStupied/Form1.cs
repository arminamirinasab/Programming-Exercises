using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreUStupied
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        // 
        Random myRandom = new Random();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Yes Button Event
        private void btnYes_Click(object sender, EventArgs e)
        {
            lblResult.Text = "I knew It O_O";
            btnYes.Visible = false;
            btnNo.Visible = false;
            this.Height = 100;
            btnX.Visible = true;
        }

        // No Button Event
        private void btnNo_Click(object sender, EventArgs e)
        {

            btnNo.Location = new Point(myRandom.Next(0, 200), myRandom.Next(0, 200));
        }

        // Close Event
        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
