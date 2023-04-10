namespace SoundPlay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isplay = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("sound.wav");
            if (isplay)
            {
                isplay = false;
                pictureBox1.Image = Properties.Resources._1;
                player.Stop();
            } else
            {
                pictureBox1.Image = Properties.Resources._2;
                player.Play();
                isplay = true;
            }
        }
    }
}