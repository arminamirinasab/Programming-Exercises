namespace SquareClickGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Score
        public int rem = 40;

        private void BlueClick(object sender, EventArgs e)
        {
            // Change Remaining And Remove Selected Square & Check Win
            rem--;
            Button selectedBtn = (Button)sender;
            selectedBtn.Visible = false;
            label1.Text = "Remaining: " + rem.ToString();
            if(rem <= 0) {
                MessageBox.Show("You Win :)", "Hooooooray", MessageBoxButtons.OK);
            }
                
        }

        private void BlackClick(object sender, EventArgs e)
        {
            // Disable Game & Change Texts
            Button selectedBtn = (Button)sender;
            selectedBtn.BackColor = Color.Red;
            groupBox1.Enabled = false;
            button121.Visible = false;
            label2.Text = "You Lost";
            label2.ForeColor = Color.Red;
            label3.Visible= false;
            MessageBox.Show("Boooooooooom", "💣", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}