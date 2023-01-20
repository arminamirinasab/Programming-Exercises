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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show Submitted Message & Close
           DialogResult sure = MessageBox.Show("OK, you have been added to the crazy list", "I Knew It" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            if (sure == DialogResult.OK) {
                this.Close();
            }
        }
    }
}
