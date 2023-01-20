namespace FavouriteLanguage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            // Check Empty Input
            if(cmbSelect.SelectedIndex != -1)
            {
                // Move Languages
                lstSelect.Items.Add(cmbSelect.SelectedItem);
                cmbSelect.Items.Remove(cmbSelect.SelectedItem);
            } else
            {
                // Show Error Message
                MessageBox.Show("Your Input Is Empty" , "Empty Language" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            // Check Empty Input
            if (lstSelect.SelectedIndex != -1)
            {
                // Move Languages
                cmbSelect.Items.Add(lstSelect.SelectedItem);
                lstSelect.Items.Remove(lstSelect.SelectedItem);
            }
            else
            {
                // Show Error Message
                MessageBox.Show("Your Input Is Empty", "Empty Language", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear List Items
            DialogResult clearConfirm = MessageBox.Show("Are You Sure To Clear List Items?" , "Clear List" , MessageBoxButtons.YesNo , MessageBoxIcon.Warning);
            if(clearConfirm == DialogResult.Yes)
            {
                lstSelect.Items.Clear();
            }
        }
    }
}