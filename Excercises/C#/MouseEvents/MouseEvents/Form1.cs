namespace MouseEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lblStatus.Text= "Mouse Down";
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            lblStatus.Text = "Mouse Enter";
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            lblStatus.Text = "Mouse Leave";
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            lblStatus.Text = "Mouse Up";
        }
    }
}