namespace CarMovement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void carTimer_Tick(object sender, EventArgs e)
        {
            // Check Location
            if (carPic.Left < 0)
            {
                // Stop The Car
                carPic.Left = 0;
                carTimer.Enabled = false;
                // Check Auto Gear 
                if (chkAuto.Checked)
                {
                    // Change To Front Gear
                    carSpeed.Value = 1;
                }
            }
            // Check Location
            else if (carPic.Left >= 880)
            {
                // Stop The Car
                carPic.Left = 879;
                carTimer.Enabled = false;
                // Check Auto Gear 
                if (chkAuto.Checked)
                {
                    // Change To Back Gear
                    carSpeed.Value = -2;
                }
            }
            else
            {
                // Moving Car
                carPic.Left += carSpeed.Value;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Enable Timer
            carTimer.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Disable Timer
            carTimer.Enabled = false;
        }
    }
}