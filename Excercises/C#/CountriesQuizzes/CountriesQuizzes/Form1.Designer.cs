namespace CountriesQuizzes
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
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.lblH1 = new System.Windows.Forms.Label();
            this.lblH2 = new System.Windows.Forms.Label();
            this.lblH3 = new System.Windows.Forms.Label();
            this.lblH4 = new System.Windows.Forms.Label();
            this.lblH7 = new System.Windows.Forms.Label();
            this.lblH5 = new System.Windows.Forms.Label();
            this.lblH6 = new System.Windows.Forms.Label();
            this.lblH9 = new System.Windows.Forms.Label();
            this.lblH8 = new System.Windows.Forms.Label();
            this.btnShowAnswer = new System.Windows.Forms.Button();
            this.chkCheats = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbRussia = new System.Windows.Forms.RadioButton();
            this.rdbUSA = new System.Windows.Forms.RadioButton();
            this.rdbFrance = new System.Windows.Forms.RadioButton();
            this.rdbIran = new System.Windows.Forms.RadioButton();
            this.rdbBrazil = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbImage
            // 
            this.pcbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbImage.Image = global::CountriesQuizzes.Properties.Resources._1;
            this.pcbImage.Location = new System.Drawing.Point(338, 12);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(450, 300);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImage.TabIndex = 0;
            this.pcbImage.TabStop = false;
            // 
            // lblH1
            // 
            this.lblH1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lblH1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblH1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblH1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblH1.ForeColor = System.Drawing.Color.Transparent;
            this.lblH1.Location = new System.Drawing.Point(338, 12);
            this.lblH1.Name = "lblH1";
            this.lblH1.Size = new System.Drawing.Size(150, 100);
            this.lblH1.TabIndex = 1;
            this.lblH1.Text = "Shadow 1";
            this.lblH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblH1.Click += new System.EventHandler(this.shadowHidden);
            // 
            // lblH2
            // 
            this.lblH2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblH2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblH2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblH2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblH2.ForeColor = System.Drawing.Color.Transparent;
            this.lblH2.Location = new System.Drawing.Point(488, 12);
            this.lblH2.Name = "lblH2";
            this.lblH2.Size = new System.Drawing.Size(150, 100);
            this.lblH2.TabIndex = 2;
            this.lblH2.Text = "Shadow 2";
            this.lblH2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblH2.Click += new System.EventHandler(this.shadowHidden);
            // 
            // lblH3
            // 
            this.lblH3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lblH3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblH3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblH3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblH3.ForeColor = System.Drawing.Color.Transparent;
            this.lblH3.Location = new System.Drawing.Point(638, 12);
            this.lblH3.Name = "lblH3";
            this.lblH3.Size = new System.Drawing.Size(150, 100);
            this.lblH3.TabIndex = 3;
            this.lblH3.Text = "Shadow 3";
            this.lblH3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblH3.Click += new System.EventHandler(this.shadowHidden);
            // 
            // lblH4
            // 
            this.lblH4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblH4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblH4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblH4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblH4.ForeColor = System.Drawing.Color.Transparent;
            this.lblH4.Location = new System.Drawing.Point(338, 112);
            this.lblH4.Name = "lblH4";
            this.lblH4.Size = new System.Drawing.Size(150, 100);
            this.lblH4.TabIndex = 4;
            this.lblH4.Text = "Shadow 4";
            this.lblH4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblH4.Click += new System.EventHandler(this.shadowHidden);
            // 
            // lblH7
            // 
            this.lblH7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lblH7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblH7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblH7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblH7.ForeColor = System.Drawing.Color.Transparent;
            this.lblH7.Location = new System.Drawing.Point(338, 212);
            this.lblH7.Name = "lblH7";
            this.lblH7.Size = new System.Drawing.Size(150, 100);
            this.lblH7.TabIndex = 5;
            this.lblH7.Text = "Shadow 7";
            this.lblH7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblH7.Click += new System.EventHandler(this.shadowHidden);
            // 
            // lblH5
            // 
            this.lblH5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lblH5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblH5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblH5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblH5.ForeColor = System.Drawing.Color.Transparent;
            this.lblH5.Location = new System.Drawing.Point(488, 112);
            this.lblH5.Name = "lblH5";
            this.lblH5.Size = new System.Drawing.Size(150, 100);
            this.lblH5.TabIndex = 6;
            this.lblH5.Text = "Shadow 5";
            this.lblH5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblH5.Click += new System.EventHandler(this.shadowHidden);
            // 
            // lblH6
            // 
            this.lblH6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblH6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblH6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblH6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblH6.ForeColor = System.Drawing.Color.Transparent;
            this.lblH6.Location = new System.Drawing.Point(638, 112);
            this.lblH6.Name = "lblH6";
            this.lblH6.Size = new System.Drawing.Size(150, 100);
            this.lblH6.TabIndex = 7;
            this.lblH6.Text = "Shadow 6";
            this.lblH6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblH6.Click += new System.EventHandler(this.shadowHidden);
            // 
            // lblH9
            // 
            this.lblH9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lblH9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblH9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblH9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblH9.ForeColor = System.Drawing.Color.Transparent;
            this.lblH9.Location = new System.Drawing.Point(638, 212);
            this.lblH9.Name = "lblH9";
            this.lblH9.Size = new System.Drawing.Size(150, 100);
            this.lblH9.TabIndex = 8;
            this.lblH9.Text = "Shadow 9";
            this.lblH9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblH9.Click += new System.EventHandler(this.shadowHidden);
            // 
            // lblH8
            // 
            this.lblH8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblH8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblH8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblH8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblH8.ForeColor = System.Drawing.Color.Transparent;
            this.lblH8.Location = new System.Drawing.Point(488, 212);
            this.lblH8.Name = "lblH8";
            this.lblH8.Size = new System.Drawing.Size(150, 100);
            this.lblH8.TabIndex = 9;
            this.lblH8.Text = "Shadow 8";
            this.lblH8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblH8.Click += new System.EventHandler(this.shadowHidden);
            // 
            // btnShowAnswer
            // 
            this.btnShowAnswer.Enabled = false;
            this.btnShowAnswer.Location = new System.Drawing.Point(615, 362);
            this.btnShowAnswer.Name = "btnShowAnswer";
            this.btnShowAnswer.Size = new System.Drawing.Size(161, 38);
            this.btnShowAnswer.TabIndex = 10;
            this.btnShowAnswer.Text = "Show Answer";
            this.btnShowAnswer.UseVisualStyleBackColor = true;
            this.btnShowAnswer.Click += new System.EventHandler(this.btnShowAnswer_Click);
            // 
            // chkCheats
            // 
            this.chkCheats.AutoSize = true;
            this.chkCheats.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkCheats.Location = new System.Drawing.Point(656, 332);
            this.chkCheats.Name = "chkCheats";
            this.chkCheats.Size = new System.Drawing.Size(120, 24);
            this.chkCheats.TabIndex = 11;
            this.chkCheats.Text = "Active Cheats";
            this.chkCheats.UseVisualStyleBackColor = true;
            this.chkCheats.CheckedChanged += new System.EventHandler(this.chkCheats_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbRussia);
            this.groupBox1.Controls.Add(this.rdbUSA);
            this.groupBox1.Controls.Add(this.rdbFrance);
            this.groupBox1.Controls.Add(this.rdbIran);
            this.groupBox1.Controls.Add(this.rdbBrazil);
            this.groupBox1.Location = new System.Drawing.Point(12, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 183);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "The Countries:";
            // 
            // rdbRussia
            // 
            this.rdbRussia.AutoSize = true;
            this.rdbRussia.Location = new System.Drawing.Point(16, 146);
            this.rdbRussia.Name = "rdbRussia";
            this.rdbRussia.Size = new System.Drawing.Size(71, 24);
            this.rdbRussia.TabIndex = 4;
            this.rdbRussia.Text = "Russia";
            this.rdbRussia.UseVisualStyleBackColor = true;
            // 
            // rdbUSA
            // 
            this.rdbUSA.AutoSize = true;
            this.rdbUSA.Location = new System.Drawing.Point(16, 116);
            this.rdbUSA.Name = "rdbUSA";
            this.rdbUSA.Size = new System.Drawing.Size(118, 24);
            this.rdbUSA.TabIndex = 3;
            this.rdbUSA.Text = "United States";
            this.rdbUSA.UseVisualStyleBackColor = true;
            // 
            // rdbFrance
            // 
            this.rdbFrance.AutoSize = true;
            this.rdbFrance.Location = new System.Drawing.Point(16, 86);
            this.rdbFrance.Name = "rdbFrance";
            this.rdbFrance.Size = new System.Drawing.Size(73, 24);
            this.rdbFrance.TabIndex = 2;
            this.rdbFrance.Text = "France";
            this.rdbFrance.UseVisualStyleBackColor = true;
            // 
            // rdbIran
            // 
            this.rdbIran.AutoSize = true;
            this.rdbIran.Location = new System.Drawing.Point(16, 56);
            this.rdbIran.Name = "rdbIran";
            this.rdbIran.Size = new System.Drawing.Size(55, 24);
            this.rdbIran.TabIndex = 1;
            this.rdbIran.Text = "Iran";
            this.rdbIran.UseVisualStyleBackColor = true;
            // 
            // rdbBrazil
            // 
            this.rdbBrazil.AutoSize = true;
            this.rdbBrazil.Checked = true;
            this.rdbBrazil.Location = new System.Drawing.Point(16, 26);
            this.rdbBrazil.Name = "rdbBrazil";
            this.rdbBrazil.Size = new System.Drawing.Size(67, 24);
            this.rdbBrazil.TabIndex = 0;
            this.rdbBrazil.TabStop = true;
            this.rdbBrazil.Text = "Brazil";
            this.rdbBrazil.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "In Which Country Is This Tourist Structure Located?";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 71);
            this.label2.TabIndex = 14;
            this.label2.Text = "Click on the shadows and guess based on the picture\r\n\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 38);
            this.button1.TabIndex = 15;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(448, 362);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(161, 38);
            this.btnChange.TabIndex = 16;
            this.btnChange.Text = "Change Image";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkCheats);
            this.Controls.Add(this.btnShowAnswer);
            this.Controls.Add(this.lblH8);
            this.Controls.Add(this.lblH9);
            this.Controls.Add(this.lblH6);
            this.Controls.Add(this.lblH5);
            this.Controls.Add(this.lblH7);
            this.Controls.Add(this.lblH4);
            this.Controls.Add(this.lblH3);
            this.Controls.Add(this.lblH2);
            this.Controls.Add(this.lblH1);
            this.Controls.Add(this.pcbImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Countries Quizzes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pcbImage;
        private Label lblH1;
        private Label lblH2;
        private Label lblH3;
        private Label lblH4;
        private Label lblH7;
        private Label lblH5;
        private Label lblH6;
        private Label lblH9;
        private Label lblH8;
        private Button btnShowAnswer;
        private CheckBox chkCheats;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private RadioButton rdbRussia;
        private RadioButton rdbUSA;
        private RadioButton rdbFrance;
        private RadioButton rdbIran;
        private RadioButton rdbBrazil;
        private Label label2;
        private Button button1;
        private Button btnChange;
    }
}