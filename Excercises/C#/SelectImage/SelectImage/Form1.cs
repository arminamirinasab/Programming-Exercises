namespace SelectImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            // Change Title
            ofdImage.Title = "Select Your Image :)";
            // Set Filters
            ofdImage.Filter = "JPG Image|*.jpg;*.jpeg|PNG Image|*.png";
            // Check & Show Dialog
            if (ofdImage.ShowDialog() == DialogResult.OK)
                // Change Image Location
                picBox.ImageLocation = ofdImage.FileName;
        }
    }
}