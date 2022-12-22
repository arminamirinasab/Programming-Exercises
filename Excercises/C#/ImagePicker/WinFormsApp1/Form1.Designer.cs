namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.changePicture1 = new System.Windows.Forms.Button();
            this.changePicture2 = new System.Windows.Forms.Button();
            this.changePicture3 = new System.Windows.Forms.Button();
            this.changePicture4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(12, 12);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(441, 382);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            // 
            // changePicture1
            // 
            this.changePicture1.Location = new System.Drawing.Point(12, 409);
            this.changePicture1.Name = "changePicture1";
            this.changePicture1.Size = new System.Drawing.Size(94, 29);
            this.changePicture1.TabIndex = 1;
            this.changePicture1.Text = "Picture 1";
            this.changePicture1.UseVisualStyleBackColor = true;
            this.changePicture1.Click += new System.EventHandler(this.changePicture1_Click);
            // 
            // changePicture2
            // 
            this.changePicture2.Location = new System.Drawing.Point(125, 409);
            this.changePicture2.Name = "changePicture2";
            this.changePicture2.Size = new System.Drawing.Size(94, 29);
            this.changePicture2.TabIndex = 2;
            this.changePicture2.Text = "Picture 2";
            this.changePicture2.UseVisualStyleBackColor = true;
            this.changePicture2.Click += new System.EventHandler(this.changePicture2_Click);
            // 
            // changePicture3
            // 
            this.changePicture3.Location = new System.Drawing.Point(244, 409);
            this.changePicture3.Name = "changePicture3";
            this.changePicture3.Size = new System.Drawing.Size(94, 29);
            this.changePicture3.TabIndex = 3;
            this.changePicture3.Text = "Picture 3";
            this.changePicture3.UseVisualStyleBackColor = true;
            this.changePicture3.Click += new System.EventHandler(this.changePicture3_Click);
            // 
            // changePicture4
            // 
            this.changePicture4.Location = new System.Drawing.Point(359, 409);
            this.changePicture4.Name = "changePicture4";
            this.changePicture4.Size = new System.Drawing.Size(94, 29);
            this.changePicture4.TabIndex = 4;
            this.changePicture4.Text = "Picture 4";
            this.changePicture4.UseVisualStyleBackColor = true;
            this.changePicture4.Click += new System.EventHandler(this.changePicture4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 450);
            this.Controls.Add(this.changePicture4);
            this.Controls.Add(this.changePicture3);
            this.Controls.Add(this.changePicture2);
            this.Controls.Add(this.changePicture1);
            this.Controls.Add(this.imageBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Image Picker";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox imageBox;
        private Button changePicture1;
        private Button changePicture2;
        private Button changePicture3;
        private Button changePicture4;
    }
}