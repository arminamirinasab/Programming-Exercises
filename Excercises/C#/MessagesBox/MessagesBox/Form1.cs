namespace MessagesBox
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

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There Is a Problem Saving One Of The Files" , "Operation Paused" , MessageBoxButtons.AbortRetryIgnore , MessageBoxIcon.Warning);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Is a Simple Dialog." , "Simple Dialog");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do You Want To Save?", "Yes / No Dialog" , MessageBoxButtons.YesNo , MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We Have an Error In Saving Operation , Would you like to be saved mandatory?" , "Error In Save" , MessageBoxButtons.YesNoCancel , MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We Have n Error In Data Storage !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}