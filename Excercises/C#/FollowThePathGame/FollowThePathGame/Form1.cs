namespace FollowThePathGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool isStart = false;
        public bool isLose = false;

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            // Check Start & Lose
            if (isStart)
            {
                isLose = true;
            }

            if (isLose)
            {
                label37.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Start Game
            isStart = true;
            button1.Text= string.Empty;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            // Check Start & Win
            if (isStart)
            {
                label37.Text = "You Won";
                label37.ForeColor = Color.Chartreuse;
                label37.Visible = true;
            }
        }
    }
}