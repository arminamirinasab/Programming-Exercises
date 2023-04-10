namespace NotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.FromArgb(10, 10, 10);
            textBox1.ForeColor = Color.FromArgb(240, 240, 240);
            lightToolStripMenuItem.Checked = false;
            ToolStripMenuItem s = (ToolStripMenuItem)sender;
            s.Checked = true;
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.FromArgb(255, 255, 255);
            textBox1.ForeColor = Color.FromArgb(0, 0, 0);
            darkToolStripMenuItem.Checked= false;
            ToolStripMenuItem s = (ToolStripMenuItem)sender;
            s.Checked = true;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            this.Font = fontDialog1.Font;
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}