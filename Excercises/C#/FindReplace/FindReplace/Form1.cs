namespace FindReplace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string text = txtString.Text.Trim();
            string find = txtFind.Text.Trim();
            int position = text.IndexOf(find , 0);
            if (position >= 0)
            {
                txtString.Focus();
                txtString.Select(position , find.Length);
            } else {
                MessageBox.Show("The Following Text Was Not Found", "Not Found");
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string text = txtString.Text.Trim();
            string find = txtFind.Text.Trim();
            string replace = txtReplace.Text.Trim();
            int position = text.IndexOf(find, 0);
            if (position >= 0)
            {
              txtString.Text = text.Replace(find, replace);
            }
            else
            {
                MessageBox.Show("The Following Text Was Not Found", "Not Found");
            }

        }
    }
}