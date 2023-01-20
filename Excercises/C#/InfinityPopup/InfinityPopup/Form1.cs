namespace InfinityPopup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void infinite_Tick(object sender, EventArgs e)
        {
            // New Popup
            Form2 f = new Form2();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}