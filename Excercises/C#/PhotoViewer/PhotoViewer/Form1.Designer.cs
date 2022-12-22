namespace PhotoViewer
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
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnZoomin = new System.Windows.Forms.Button();
            this.btnZoomout = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHorCenter = new System.Windows.Forms.Button();
            this.btnVerCenter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.ImageLocation = "1.jpg";
            this.picBox.Location = new System.Drawing.Point(208, 105);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(384, 240);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(467, 361);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(125, 42);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(208, 361);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(125, 42);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnZoomin
            // 
            this.btnZoomin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnZoomin.Location = new System.Drawing.Point(746, 12);
            this.btnZoomin.Name = "btnZoomin";
            this.btnZoomin.Size = new System.Drawing.Size(42, 42);
            this.btnZoomin.TabIndex = 3;
            this.btnZoomin.Text = "➕";
            this.btnZoomin.UseVisualStyleBackColor = true;
            this.btnZoomin.Click += new System.EventHandler(this.btnZoomin_Click);
            // 
            // btnZoomout
            // 
            this.btnZoomout.Location = new System.Drawing.Point(12, 12);
            this.btnZoomout.Name = "btnZoomout";
            this.btnZoomout.Size = new System.Drawing.Size(42, 42);
            this.btnZoomout.TabIndex = 4;
            this.btnZoomout.Text = "➖";
            this.btnZoomout.UseVisualStyleBackColor = true;
            this.btnZoomout.Click += new System.EventHandler(this.btnZoomout_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRight.Location = new System.Drawing.Point(753, 208);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(35, 35);
            this.btnRight.TabIndex = 5;
            this.btnRight.Text = "👉";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLeft.Location = new System.Drawing.Point(12, 208);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(35, 35);
            this.btnLeft.TabIndex = 6;
            this.btnLeft.Text = "👈";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnTop
            // 
            this.btnTop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTop.Location = new System.Drawing.Point(383, 12);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(35, 35);
            this.btnTop.TabIndex = 7;
            this.btnTop.Text = "👆";
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(383, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "👇";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHorCenter
            // 
            this.btnHorCenter.Location = new System.Drawing.Point(636, 409);
            this.btnHorCenter.Name = "btnHorCenter";
            this.btnHorCenter.Size = new System.Drawing.Size(152, 29);
            this.btnHorCenter.TabIndex = 9;
            this.btnHorCenter.Text = "Horizontal Center";
            this.btnHorCenter.UseVisualStyleBackColor = true;
            this.btnHorCenter.Click += new System.EventHandler(this.btnHorCenter_Click);
            // 
            // btnVerCenter
            // 
            this.btnVerCenter.Location = new System.Drawing.Point(12, 409);
            this.btnVerCenter.Name = "btnVerCenter";
            this.btnVerCenter.Size = new System.Drawing.Size(152, 29);
            this.btnVerCenter.TabIndex = 10;
            this.btnVerCenter.Text = "Vertical Center";
            this.btnVerCenter.UseVisualStyleBackColor = true;
            this.btnVerCenter.Click += new System.EventHandler(this.btnVerCenter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerCenter);
            this.Controls.Add(this.btnHorCenter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnZoomout);
            this.Controls.Add(this.btnZoomin);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Photo Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picBox;
        private Button btnNext;
        private Button btnPrev;
        private Button btnZoomin;
        private Button btnZoomout;
        private Button btnRight;
        private Button btnLeft;
        private Button btnTop;
        private Button button1;
        private Button btnHorCenter;
        private Button btnVerCenter;
    }
}