using CountriesQuizzes.Properties;

namespace CountriesQuizzes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Correct Answer Code
        int correctAnswer = 0;
        public void randomImage()
        {
            // Random Item
            Random randImage = new Random();
            int imagenum = randImage.Next(1, 6);
            // Set Image Random
            switch (imagenum)
            {
                case 1:
                    pcbImage.Image = Properties.Resources._1;
                    break;
                case 2:
                    pcbImage.Image = Properties.Resources._2;
                    break;
                case 3:
                    pcbImage.Image = Properties.Resources._3;
                    break;
                case 4:
                    pcbImage.Image = Properties.Resources._4;
                    break;
                case 5:
                    pcbImage.Image = Properties.Resources._5;
                    break;
            }
            // Change Correct Answer Variable
            correctAnswer = imagenum;
        }


        private void chkCheats_CheckedChanged(object sender, EventArgs e)
        {
            // Enable Button With Active Cheat Check Box
            btnShowAnswer.Enabled = chkCheats.Checked;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Random Image In Load
            randomImage();
        }
        // Chance Of Hidden Shadows
        int chance = 2;

        // Hidden Shadows
        private void lblH1_Click(object sender, EventArgs e)
        {
            if (!(chance <= 0))
            {
                lblH1.Visible = false;
                chance--;
            }
        }

        private void lblH2_Click(object sender, EventArgs e)
        {
            if (!(chance <= 0))
            {
                lblH2.Visible = false;
                chance--;
            }
        }

        private void lblH3_Click(object sender, EventArgs e)
        {
            if (!(chance <= 0))
            {
                lblH3.Visible = false;
                chance--;
            }
        }

        private void lblH4_Click(object sender, EventArgs e)
        {
            if (!(chance <= 0))
            {
                lblH4.Visible = false;
                chance--;
            }
        }

        private void lblH5_Click(object sender, EventArgs e)
        {
            if (!(chance <= 0))
            {
                lblH5.Visible = false;
                chance--;
            }
        }

        private void lblH6_Click(object sender, EventArgs e)
        {
            if (!(chance <= 0))
            {
                lblH6.Visible = false;
                chance--;
            }
        }

        private void lblH7_Click(object sender, EventArgs e)
        {
            if (!(chance <= 0))
            {
                lblH7.Visible = false;
                chance--;
            }
        }

        private void lblH8_Click(object sender, EventArgs e)
        {
            if (!(chance <= 0))
            {
                lblH8.Visible = false;
                chance--;
            }
        }

        private void lblH9_Click(object sender, EventArgs e)
        {
            if (!(chance <= 0))
            {
                lblH9.Visible = false;
                chance--;
            }
        }

        // Change Image With Change Image Button
        private void btnChange_Click(object sender, EventArgs e)
        {
            randomImage();
        }

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            // Show Correct Answer With Detect Code
            string correctString = "";
            switch (correctAnswer)
            {
                case 1:
                    correctString = "Paris";
                    break;
                case 2:
                    correctString = "United States";
                    break;
                case 3:
                    correctString = "Brazil";
                    break;
                case 4:
                    correctString = "Iran";
                    break;
                case 5:
                    correctString = "Russia";
                    break;
            }
            // Show Message
            MessageBox.Show("This Tourist Structure Is Located In " + correctString, "Correct Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check Correct Answer
            if ((rdbFrance.Checked && correctAnswer == 1) || (rdbUSA.Checked && correctAnswer == 2) || (rdbBrazil.Checked && correctAnswer == 3) || (rdbIran.Checked && correctAnswer == 4) || (rdbRussia.Checked && correctAnswer == 5))
            {
                MessageBox.Show("Your Answer Is Correct, It Hit The Target :)", "Hooray", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Error Message
                MessageBox.Show("Your Answer Is Not Correct", "Incorrect Answer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}