namespace BackgroundColorChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // Hide Label
            lblHelp.Hide();
            // Show Color Dialog & Check Result
            if(colorPicker.ShowDialog() == DialogResult.OK)
            {
                // Change Background
                this.BackColor = colorPicker.Color;
            }
            

        }
    }
}