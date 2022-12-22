namespace PhotoViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picBox_Click(object sender, EventArgs e)
        {

        }
        // Image Number For Navigate Pictures
        int imageNumber = 1;

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Plus Image Number
            imageNumber++;
            // Check & Back To First Image
            if(imageNumber == 4)
            {
                imageNumber = 1;
            }
            // Change Image
            picBox.ImageLocation = $"{imageNumber}.jpg";
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            // Minus Image Number
            imageNumber--;
            // Check & Back To Last Image
            if (imageNumber == 0)
            {
                imageNumber = 3;
            }
            // Change Image
            picBox.ImageLocation = $"{imageNumber}.jpg";
        }

        private void btnZoomout_Click(object sender, EventArgs e)
        {
            // Zoom Out
            picBox.Height -= 5;
            picBox.Width -= 8;
        }

        private void btnZoomin_Click(object sender, EventArgs e)
        {
            // Zoom In
            picBox.Height += 5;
            picBox.Width += 8;
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            // Change Location Only
            picBox.Top -= 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Change Location Only
            picBox.Top += 5;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            // Change Location Only
            picBox.Left -= 5;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            // Change Location Only
            picBox.Left += 5;
        }

        private void btnHorCenter_Click(object sender, EventArgs e)
        {
            // Horizontal Centering With Additional Values
            picBox.Left = this.Width / 2 - picBox.Width / 2 - 9;
        }

        private void btnVerCenter_Click(object sender, EventArgs e)
        {
            // Vertical Centering With Additional Values
            picBox.Top = this.Height / 2 - picBox.Height / 2 - 23;
        }
    }
}