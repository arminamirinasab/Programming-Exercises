namespace CursorPosition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // Show Postition Live With Mouse Move
            lblPosition.Text = e.X + " , " + e.Y;
        }
    }
}