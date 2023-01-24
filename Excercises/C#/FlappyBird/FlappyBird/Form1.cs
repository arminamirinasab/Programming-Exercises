using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Lose & GetCoin Flags
        bool lose = false;
        bool getcoin = false;
        private void godown_Tick(object sender, EventArgs e)
        {
            /*
            Checking the bird's fall using the location from top and
            the height of top bar of the window and the height of the bird 
             */

            if (picFlappy.Top < Height - picFlappy.Height - 40)
            {
                // Check Range of The Coin & Disapper It
                if ((picFlappy.Top + picFlappy.Height < 100 && picFlappy.Left > 650 - picFlappy.Width) && (picFlappy.Top + picFlappy.Height > 50 && picFlappy.Left - picFlappy.Width < 700))
                {
                    getcoin = true;
                    picCoin.Visible = false;
                }
                // Falling bird down
                picFlappy.Left += 15;
                picFlappy.Top += 10;
            }
            else
            {
                // Bird crash message
                godown.Enabled = false;
                MessageBox.Show("The bird fell to the ground :(", "You Lose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lose = true;
            }
            // The bird goes after the coin
            if (picFlappy.Left > Width)
            {
                godown.Enabled = false;
                // Check whether the bird get the coin or not?
                if (getcoin)
                {
                    MessageBox.Show("You Get The Flappy Coin :)", "You Won", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You Can't Get The Flappy Coin :/", "You Lose", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Double Click Go Up
            if (!lose)
            {
                picFlappy.Top -= 50;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Start Timer After Show The Help Message
            DialogResult r = MessageBox.Show("You can fly by double clicking on the window, you need to get the coin to win, watch out for the falling of the bird.", "Help");
            if (r == DialogResult.OK)
            {
                godown.Enabled = true;
            }
        }
    }
}