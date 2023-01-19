using System.Data;

namespace Stopwatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Get Short Time Every One Minute
        private void gettime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }
        // Get Short Time After Load
        private void Form1_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }
        // Stopwatch Variables
        int second = 0;
        int minute = 0;
        int hour = 0;

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Active / Deactive Buttons
            btnStart.Enabled = false;
            btnPause.Enabled = true;
            btnClear.Enabled = true;
            // Active / Deactive Timer
            time.Enabled = true;

            setTime();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult resetMessage = MessageBox.Show("Are You Sure To Reset The Stopwatch?", "Reset Stopwatch", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resetMessage == DialogResult.Yes)
            {
                // Reset Variables
                second = 0;
                minute = 0;
                hour = 0;
                // Active / Deactive Timer
                time.Enabled = false;
                // Active / Deactive Buttons
                btnClear.Enabled = false;
                btnStart.Enabled = true;
                btnStart.Text = "Start";
                btnPause.Enabled = false;

                setTime();
            }
        }

        // This Function Puts The Value Of The Variables In The Labels
        public void setTime()
        {
            // Check Seconds & Formatting
            if (second < 10)
                lblSecond.Text = "0" + second.ToString();
            else
                lblSecond.Text = second.ToString();
            // Check Minutes & Formatting
            if (minute < 10)
                lblMinute.Text = "0" + minute.ToString();
            else
                lblMinute.Text = minute.ToString();

            // Set Hour
            lblHour.Text = hour.ToString();

        }

        private void time_Tick(object sender, EventArgs e)
        {
            // Add Second
            second++;
            // Convert To Minute
            if (second == 60)
            {
                second = 0;
                minute++;
            }
            // Convert To Hour
            if (minute == 60)
            {
                minute = 0;
                hour++;
            }

            setTime();

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            // Active / Deactive Buttons
            time.Enabled = false;
            btnPause.Enabled = false;
            btnStart.Enabled = true;
            btnStart.Text = "Resume";
        }
    }
}