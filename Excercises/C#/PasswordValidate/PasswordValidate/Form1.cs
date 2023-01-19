namespace PasswordValidate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Username: admin \n Password: admin", "Login Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check Login
            if(txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                // Show Successfuly Login Message
                MessageBox.Show("You Have Successfully Logged in" , "Successfuly" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            } else {
                // Show Error Message
              DialogResult myDialogMessage = MessageBox.Show("The Username Or Password Is Incorrect." , "Login Error" , MessageBoxButtons.RetryCancel , MessageBoxIcon.Error , MessageBoxDefaultButton.Button2);
                // Check DialogResult
                if(myDialogMessage == DialogResult.Retry) {
                    // Clear Fields When User Select Retry
                txtUsername.Clear();
                txtPassword.Clear();
                } else if(myDialogMessage == DialogResult.Cancel)
                {
                    // do nothing
                }
            }
        }
    }
}