namespace UFO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // The Poison Reverse Controls
        bool Poison = false;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Check Poison
            if (Poison)
            {
                // Reverse Controls
                switch (e.KeyCode)
                {
                    case Keys.W:
                    case Keys.Up:
                        pictureBox1.Top += 5;
                        break;
                    case Keys.S:
                    case Keys.Down:
                        pictureBox1.Top -= 5;
                        break;
                    case Keys.A:
                    case Keys.Left:
                        pictureBox1.Left += 5;
                        break;
                    case Keys.D:
                    case Keys.Right:
                        pictureBox1.Left -= 5;
                        break;
                }
            }
            else
            {
                // Normal Controls
                switch (e.KeyCode)
                {
                    case Keys.W:
                    case Keys.Up:
                        pictureBox1.Top -= 5;
                        break;
                    case Keys.S:
                    case Keys.Down:
                        pictureBox1.Top += 5;
                        break;
                    case Keys.A:
                    case Keys.Left:
                        pictureBox1.Left -= 5;
                        break;
                    case Keys.D:
                    case Keys.Right:
                        pictureBox1.Left += 5;
                        break;
                }
            }
            // Check Walls And Active Poison
            if (pictureBox1.Left < 20 || pictureBox1.Top < 20 || pictureBox1.Top > this.Height - pictureBox1.Height - 50 || pictureBox1.Left > this.Width - pictureBox1.Width - 30)
            {
                if (Poison)
                {
                    Poison = false;
                    label1.BackColor = Color.Chartreuse;
                    label2.BackColor = Color.Chartreuse;
                    label3.BackColor = Color.Chartreuse;
                    label4.BackColor = Color.Chartreuse;
                }
                else
                {
                    Poison = true;
                    label1.BackColor = Color.Black;
                    label2.BackColor = Color.Black;
                    label3.BackColor = Color.Black;
                    label4.BackColor = Color.Black;
                }
            }
        }
    }
}