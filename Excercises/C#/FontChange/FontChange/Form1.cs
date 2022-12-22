namespace FontChange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // Check & Show Font Dialog
            if (fontChange.ShowDialog() == DialogResult.OK)
            {
                // Change Font
                txtChange.Font = fontChange.Font;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}