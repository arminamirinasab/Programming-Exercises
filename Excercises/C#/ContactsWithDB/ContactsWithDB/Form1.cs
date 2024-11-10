using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ContactsWithDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pictureBox1.ImageLocation = "default.jpg";
            this.pictureBox2.ImageLocation = "default.jpg";
            // TODO: This line of code loads data into the 'contacts1DataSet.contacts' table. You can move, or remove it, as needed.
            this.contactsTableAdapter.Fill(this.contacts1DataSet.contacts);
            MessageBox.Show("OK");
            File.WriteAllText("" , "ai.");
        }

        string imagePath = "";

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagePath = "images/" + Path.GetFileName(openFileDialog1.FileName);
                pictureBox2.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.ImageLocation != "default.jpg")
            {
                if (!File.Exists(imagePath))
                {
                    File.WriteAllBytes(imagePath, File.ReadAllBytes(openFileDialog1.FileName));
                }
                else
                {
                    MessageBox.Show("We have a file with this name! Please Rename Your File", "Names Conflict", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }


            if (textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
            {
                this.contactsTableAdapter.InsertQuery(textBox2.Text, textBox3.Text, imagePath, textBox4.Text);
                MessageBox.Show("Contact Added Successfuly", "Succeded", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Contact Name Or Phone Is Empty !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
