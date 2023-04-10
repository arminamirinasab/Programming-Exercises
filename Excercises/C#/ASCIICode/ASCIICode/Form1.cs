namespace ASCIICode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label3.Text = e.KeyChar.ToString();
            label4.Text = ((int)e.KeyChar).ToString();
        }
    }
}