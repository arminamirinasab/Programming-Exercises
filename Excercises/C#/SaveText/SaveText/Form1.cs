namespace SaveText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(textBox2.Text.Length > 0)
            {
                try
                {
                    System.IO.File.WriteAllText(textBox2.Text + ".txt", textBox1.Text);
                    MessageBox.Show("File Created Succesfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch {
                    MessageBox.Show("Error In Create File" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                }

            } else
            {
                MessageBox.Show("Your File Name Is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                try
                {
                    System.IO.File.WriteAllText(textBox2.Text + ".txt", textBox1.Text);
                    MessageBox.Show("File Updated Succesfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Error In Create File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Your File Name Is Empty (Use Your Past File Name)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}