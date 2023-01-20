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

        // Yes Button Event
        private void btnYes_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            
        }
        Random myRandom = new Random();
        // No Button Event
        private void btnNo_Click(object sender, EventArgs e)
        {
            btnNo.Location = new Point(myRandom.Next(0, 200), myRandom.Next(0, 200));
        }
    }
}
