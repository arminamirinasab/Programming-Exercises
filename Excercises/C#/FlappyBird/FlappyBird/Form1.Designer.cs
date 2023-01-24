namespace FlappyBird
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
            this.components = new System.ComponentModel.Container();
            this.picFlappy = new System.Windows.Forms.PictureBox();
            this.picCoin = new System.Windows.Forms.PictureBox();
            this.godown = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picFlappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).BeginInit();
            this.SuspendLayout();
            // 
            // picFlappy
            // 
            this.picFlappy.BackColor = System.Drawing.Color.Transparent;
            this.picFlappy.Image = global::FlappyBird.Properties.Resources.NicePng_flappy_bird_pipes_png_5857711;
            this.picFlappy.Location = new System.Drawing.Point(30, 47);
            this.picFlappy.Name = "picFlappy";
            this.picFlappy.Size = new System.Drawing.Size(60, 58);
            this.picFlappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFlappy.TabIndex = 0;
            this.picFlappy.TabStop = false;
            // 
            // picCoin
            // 
            this.picCoin.BackColor = System.Drawing.Color.Transparent;
            this.picCoin.Image = global::FlappyBird.Properties.Resources.flappy_coin1;
            this.picCoin.Location = new System.Drawing.Point(650, 50);
            this.picCoin.Name = "picCoin";
            this.picCoin.Size = new System.Drawing.Size(60, 50);
            this.picCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoin.TabIndex = 1;
            this.picCoin.TabStop = false;
            // 
            // godown
            // 
            this.godown.Interval = 50;
            this.godown.Tick += new System.EventHandler(this.godown_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlappyBird.Properties.Resources._46888871_624a3900_ce7f_11e8_808e_99fd90c8a3f4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.picCoin);
            this.Controls.Add(this.picFlappy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.picFlappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picFlappy;
        private PictureBox picCoin;
        private System.Windows.Forms.Timer godown;
    }
}