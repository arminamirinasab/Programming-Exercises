namespace GoUP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool isUp = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Top > this.Height)
            {
                timer1.Enabled = false;
                MessageBox.Show("You Lose");
            }

            if (isUp)
            {
                pictureBox1.Top -= 3;
            } else
            {
                pictureBox1.Top += 3;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (pictureBox1.Top < 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("You Win");

            }
             else {
                timer1.Enabled = true;
                isUp = true;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            isUp = false;
        }
    }
}