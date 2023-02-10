namespace MouseWheel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Create Mouse Wheel Event
            this.MouseWheel += Form1_MouseWheel;
        }

        private void Form1_MouseWheel(object? sender, MouseEventArgs e)
        {
            // Check Wheel Rotate
            if (e.Delta > 0)
            {
                // Check Size
                if (pictureBox1.Height < this.Height && pictureBox1.Width < this.Width)
                {
                    // Zoom Image
                    pictureBox1.Width += 10;
                    pictureBox1.Height += 10;
                }
            }
            else
            {
                // Check Size
                if (pictureBox1.Height > 75 && pictureBox1.Width > 75)
                {
                    // Zoom Out
                    pictureBox1.Width -= 10;
                    pictureBox1.Height -= 10;
                }
            }
        }
    }
}