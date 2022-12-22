namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void changePicture1_Click(object sender, EventArgs e)
        {
            imageBox.Image = Properties.Resources.kevin_ku_w7ZyuGYNpRQ_unsplash;
        }

        private void changePicture2_Click(object sender, EventArgs e)
        {
            imageBox.Image = Properties.Resources.pexels_pixabay_510174;
        }

        private void changePicture3_Click(object sender, EventArgs e)
        {
            imageBox.Image = Properties.Resources.carl_heyerdahl_KE0nC8_58MQ_unsplash;
        }

        private void changePicture4_Click(object sender, EventArgs e)
        {
            imageBox.Image = Properties.Resources.walling_OvLXbURo9Wo_unsplash;

        }
    }
}